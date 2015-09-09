using System.ComponentModel;
using System.IO;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ionic.Crc;
using Ionic.Zip;
using Microsoft.Win32;
using mshtml;
using Verifier.Exceptions;
using Verifier.Reources;
using Verifier.Utility;


namespace Verifier.UI.Template
{
    /// <summary>
    /// Interaction logic for Wrapper.xaml
    /// </summary>
    public partial class Wrapper : ModernWindow
    {
        public Wrapper()
        {
            InitializeComponent();
        }

        public void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "نقص اطلاعات", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            ShowError();
        }

        public void ShowError()
        {
            imgCross.Visibility = Visibility.Visible;
            imgTick.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
            webBrowser.Visibility = Visibility.Collapsed;
            lblMessage.Text = "اطلاعات قابل تایید نمی باشند!";
        }

        private void BtnUploadFile_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog { Multiselect = false };
                dialog.Filter = "Zip files (*.zip)|*.zip|Rar files (*.rar)|*.rar|All files (*.*)|*.*";

                if (dialog.ShowDialog() == true)
                {
                    String path = dialog.FileName;
                    byte[] data = GetByte(path, "original_file");
                    byte[] signed = GetByte(path, "signed_file");
                    bool verificationStatus = Utility.Verifier.Verify(data, signed);
                    if (verificationStatus == true)
                    {
                        imgCross.Visibility = Visibility.Collapsed;
                        imgTick.Visibility = Visibility.Visible;
                        lblMessage.Text = "اطلاعات مورد تایید می باشد.";
                        webBrowser.NavigateToString(Encoding.UTF8.GetString(data)); 
                        imgLogo.Visibility = Visibility.Collapsed;
                        webBrowser.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ShowError();
                    }
                }
            }
            catch (UserInterfaceException ex)
            {
                ShowError(ex);
            }
            catch (FormatException ex)
            {
                //Log.Error("Format Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30002, ExceptionMessage.Format, ex);
                ShowError(exception);
            }
            catch (Exception ex)
            {
                //Log.Error("Unspecific Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30001, ExceptionMessage.FileOpenError, ex);
                ShowError(exception);
            }
        }

        private byte[] GetByte(String path, String entryName)
        {
            using (ZipFile zip = ZipFile.Read(path))
            {
                // here, we extract every entry, but we could extract conditionally
                // based on entry name, size, date, checkbox status, etc.  
                foreach (ZipEntry entry in zip)
                {
                    if (entry.FileName.Equals(entryName))
                    {
                        Stream stream = entry.OpenReader();
                        byte[] buf = new byte[stream.Length];
                        stream.Read(buf, 0, buf.Length); // read from stream to byte array   
                        return buf;
                    }
                }
                throw new UserInterfaceException(30003, String.Format(ExceptionMessage.FileNotFound, entryName));
            }
        }

        private void WebBrowser_OnNavigated(object sender, NavigationEventArgs e)
        {
            WebBrowserHelper.SetSilent(webBrowser, true); // make it silent
        }

        private void WebBrowser_OnLoadCompleted(object sender, NavigationEventArgs e)
        {
//            var doc = webBrowser.Document as HTMLDocument;
//            var collection = doc.getElementsByTagName("body");
//
//            foreach (IHTMLElement input in collection)
//            {
//                input.style.setAttribute("overflow", "hidden");
//            }
//            const string script = "document.body.style.overflow ='hidden'";
//            webBrowser.InvokeScript("execScript", new Object[] { script, "JavaScript" });
        }
    }
}
