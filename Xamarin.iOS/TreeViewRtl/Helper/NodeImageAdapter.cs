using System;
using Syncfusion.iOS.TreeView;
using UIKit;

namespace Blank
{
    public class NodeImageAdapter : TreeViewAdapter
    {
        public NodeImageAdapter()
        {
        }

        protected override UIView CreateContentView(TreeViewItemInfoBase itemInfo)
        {
            var gridView = new NodeImageView(itemInfo.TreeView);
            return gridView;
        }

        protected override void UpdateContentView(UIView view, TreeViewItemInfoBase itemInfo)
        {
            var grid = view as NodeImageView;
            var treeViewNode = itemInfo.Node;
            if (grid != null)
            {
                var imageView = grid.Subviews[0] as UIImageView;
                if (imageView != null)
                    imageView.Image = (treeViewNode.Content as FileManager).ImageIcon;
                var label1 = grid.Subviews[1] as UILabel;
                if (label1 != null)
                    label1.Text = (treeViewNode.Content as FileManager).FileName;
            }
        }
    }
}
