using System;
using System.Collections.ObjectModel;
using UIKit;

namespace Blank
{

    public class FileManagerViewModel
    {
        public ObservableCollection<FileManager> Folders { get; set; }

        public FileManagerViewModel()
        {
            GenerateFiles();
        }

        private void GenerateFiles()
        {
            var doc = new FileManager() { FileName = "Documents", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };
            var download = new FileManager() { FileName = "Downloads", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };
            var mp3 = new FileManager() { FileName = "Music", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };
            var pictures = new FileManager() { FileName = "Pictures", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };
            var video = new FileManager() { FileName = "Videos", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };

            var pollution = new FileManager() { FileName = "Environmental Pollution.docx", ImageIcon = UIImage.FromBundle("Images/treeview_word.png") };
            var globalWarming = new FileManager() { FileName = "Global Warming.ppt", ImageIcon = UIImage.FromBundle("Images/treeview_ppt.png") };
            var sanitation = new FileManager() { FileName = "Sanitation.docx", ImageIcon = UIImage.FromBundle("Images/treeview_word.png") };
            var socialNetwork = new FileManager() { FileName = "Social Network.pdf", ImageIcon = UIImage.FromBundle("Images/treeview_pdf.png") };
            var youthEmpower = new FileManager() { FileName = "Youth Empowerment.pdf", ImageIcon = UIImage.FromBundle("Images/treeview_pdf.png") };

            var game = new FileManager() { FileName = "Game.exe", ImageIcon = UIImage.FromBundle("Images/treeview_exe.png") };
            var tutorials = new FileManager() { FileName = "Tutorials.zip", ImageIcon = UIImage.FromBundle("Images/treeview_zip.png") };
            var typescript = new FileManager() { FileName = "TypeScript.7z", ImageIcon = UIImage.FromBundle("Images/treeview_zip.png") };
            var uiGuide = new FileManager() { FileName = "UI-Guide.pdf", ImageIcon = UIImage.FromBundle("Images/treeview_pdf.png") };

            var song = new FileManager() { FileName = "Goutiest", ImageIcon = UIImage.FromBundle("Images/treeview_mp3.png") };

            var camera = new FileManager() { FileName = "Camera Roll", ImageIcon = UIImage.FromBundle("Images/treeview_folder.png") };
            var stone = new FileManager() { FileName = "Stone.jpg", ImageIcon = UIImage.FromBundle("Images/treeview_png.png") };
            var wind = new FileManager() { FileName = "Wind.jpg", ImageIcon = UIImage.FromBundle("Images/treeview_png.png") };

            var img0 = new FileManager() { FileName = "WIN_20160726_094117.JPG", ImageIcon = UIImage.FromBundle("Images/treeview_img0.png") };
            var img1 = new FileManager() { FileName = "WIN_20160726_094118.JPG", ImageIcon = UIImage.FromBundle("Images/treeview_img1.png") };

            var video0 = new FileManager() { FileName = "Naturals.mp4", ImageIcon = UIImage.FromBundle("Images/treeview_video.png") };
            var video1 = new FileManager() { FileName = "Wild.mpg", ImageIcon = UIImage.FromBundle("Images/treeview_video.png") };

            doc.SubFiles = new ObservableCollection<FileManager>
            {
         pollution,
         globalWarming,
         sanitation,
         socialNetwork,
         youthEmpower
            };

            download.SubFiles = new ObservableCollection<FileManager>
      {
                game,
         tutorials,
         typescript,
         uiGuide
            };

            mp3.SubFiles = new ObservableCollection<FileManager>
      {
         song
            };

            pictures.SubFiles = new ObservableCollection<FileManager>
      {
         camera,
         stone,
         wind
            };

            camera.SubFiles = new ObservableCollection<FileManager>
      {
         img0,
         img1
            };

            video.SubFiles = new ObservableCollection<FileManager>
      {
         video0,
         video1
            };
            Folders = new ObservableCollection<FileManager>();
            Folders.Add(doc);
            Folders.Add(download);
            Folders.Add(mp3);
            Folders.Add(pictures);
            Folders.Add(video);
        }
    }
}