using System.ComponentModel;
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
using Microsoft.Win32;
using Verifier.Exceptions;
using Verifier.Reources;

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
        }

        private void BtnUploadFile_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog { Multiselect = false };
                dialog.Filter = "Text files (*.html)|*.html|All files (*.*)|*.*";

                if (dialog.ShowDialog() == true)
                {
                    String path = dialog.FileName;
                }
            }
            catch (UserInterfaceException ex)
            {
                ShowError(ex);
            }
            catch (FormatException ex)
            {
                //Log.Error("Format Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(20002, ExceptionMessage.Format, ex);
                ShowError(exception);
            }
            catch (Exception ex)
            {
                //Log.Error("Unspecific Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(10001, ExceptionMessage.VoyageOpenError, ex);
                ShowError(exception);
            }
        }
    }
}
