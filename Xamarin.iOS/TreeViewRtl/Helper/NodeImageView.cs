using System;
using CoreGraphics;
using UIKit;
using Syncfusion.iOS.TreeView;

namespace Blank
{
    public class NodeImageView : UIView
    {
        UILabel label1;
        UIImageView imageIcon;
        SfTreeView view;
        public NodeImageView(SfTreeView treeView)
        {
            view = treeView;
            label1 = new UILabel();
            if (GetUserInterfaceLayoutDirection(view.SemanticContentAttribute) == UIUserInterfaceLayoutDirection.RightToLeft)
                label1.TextAlignment = UITextAlignment.Right;
            imageIcon = new UIImageView();
            imageIcon.ClipsToBounds = true;
            imageIcon.AdjustsImageSizeForAccessibilityContentSizeCategory = true;
            imageIcon.InsetsLayoutMarginsFromSafeArea = true;
            this.AddSubview(imageIcon);
            this.AddSubview(label1);
        }

        public override void LayoutSubviews()
        {
            var imageWidth = 40;
            if (GetUserInterfaceLayoutDirection(view.SemanticContentAttribute) == UIUserInterfaceLayoutDirection.RightToLeft)
            {
                this.imageIcon.Frame = new CGRect(this.Frame.Width - imageWidth, 0, imageWidth, this.Frame.Height);
                this.label1.Frame = new CGRect(0, 0, this.Frame.Width - imageWidth, this.Frame.Height);
            }
            else
            {
                this.imageIcon.Frame = new CGRect(0, 0, imageWidth, this.Frame.Height);
                this.label1.Frame = new CGRect(imageWidth, 0, this.Frame.Width, this.Frame.Height);
            }
            base.LayoutSubviews();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
