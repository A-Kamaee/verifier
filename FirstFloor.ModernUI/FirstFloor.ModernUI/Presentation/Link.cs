using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FirstFloor.ModernUI.Presentation
{
    /// <summary>
    /// Represents a displayable link.
    /// </summary>
    public class Link
        : Displayable
    {
        private Uri source;

        private ImageSource imageSource;

        private Boolean isEnabled;

        /// <summary>
        /// Gets or sets the source uri.
        /// </summary>
        /// <value>The source.</value>
        public Uri Source
        {
            get { return this.source; }
            set
            {
                if (this.source != value) {
                    this.source = value;
                    OnPropertyChanged("Source");
                }
            }
        }

        /// <summary>
        /// Gets or sets the source image.
        /// </summary>
        /// <value>The source.</value>
        public ImageSource ImageSource
        {
            get { return this.imageSource; }
            set
            {
                if (this.imageSource != value)
                {
                    this.imageSource = value;
                    OnPropertyChanged("ImageSource");
                }
            }
        }

        /// <summary>
        /// Gets or sets the source image.
        /// </summary>
        /// <value>The source.</value>
        public Boolean IsEnabled
        {
            get { return this.isEnabled; }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }
    }
}
