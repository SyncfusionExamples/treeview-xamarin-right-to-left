using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using Syncfusion.iOS.TreeView;

namespace Blank
{
    [Register("CustomViewController")]
    public class CustomViewController : UIViewController
    {
        public CustomViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;
            SfTreeView treeView = new SfTreeView(View.Bounds);
            
            treeView.SemanticContentAttribute = UISemanticContentAttribute.ForceRightToLeft;
            FileManagerViewModel viewModel = new FileManagerViewModel();
            treeView.AutoExpandMode = Syncfusion.TreeView.Engine.AutoExpandMode.RootNodesExpanded;
            treeView.ChildPropertyName = "SubFiles";
            treeView.ItemsSource = viewModel.Folders;
            treeView.Adapter = new NodeImageAdapter();
            // Perform any additional setup after loading the view
            Add(treeView);
        }
    }
}