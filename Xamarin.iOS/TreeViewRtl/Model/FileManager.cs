using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UIKit;

namespace Blank
{
    public class FileManager : INotifyPropertyChanged
    {
        private string fileName;
        private UIImage imageIcon;
        private ObservableCollection<FileManager> subFolder;

        public ObservableCollection<FileManager> SubFiles
        {
            get
            {
                return subFolder;
            }

            set
            {
                subFolder = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FileName");
            }
        }

        public UIImage ImageIcon
        {
            get
            {
                return imageIcon;
            }

            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        public FileManager()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}
