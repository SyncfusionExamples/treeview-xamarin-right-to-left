using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Syncfusion.Android.TreeView;
namespace TreeViewRtl
{
    public class NodeImageView : LinearLayout
    {
        #region Fields

        private ContentLabel label1;
        private ImageViewExt imageIcon;
        SfTreeView view;

        #endregion

        #region Constructor

        public NodeImageView(Context context, SfTreeView treeView) : base(context)
        {
            view = treeView;
            this.Orientation = Orientation.Horizontal;
            label1 = new ContentLabel(context);
            label1.Gravity = GravityFlags.CenterVertical;
            if (view.LayoutDirection == Android.Views.LayoutDirection.Rtl)
                label1.TextDirection = TextDirection.Rtl;
            imageIcon = new ImageViewExt(context);
            this.AddView(imageIcon);
            this.AddView(label1);
        }

        #endregion

        #region Methods

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            var density = Resources.DisplayMetrics.Density;
            var measuredWidth = (int)(40 * density);
            var measuredHeight = (int)(45 * density);
            var labelWidth = Math.Abs(widthMeasureSpec - measuredWidth);
            this.label1.SetMinimumHeight(measuredHeight);
            this.label1.SetMinimumWidth(labelWidth);
            this.imageIcon.SetMinimumHeight(measuredHeight);
            this.imageIcon.SetMinimumWidth(measuredWidth);
            this.imageIcon.Measure(measuredWidth, measuredHeight);
            this.label1.Measure(labelWidth, measuredHeight);
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            var density = Resources.DisplayMetrics.Density;
            var measuredWidth = (int)(40 * density);
            var measuredHeight = (int)(45 * density);
            if (view.LayoutDirection == Android.Views.LayoutDirection.Rtl)
            {
                this.imageIcon.Layout(Width - measuredWidth, 0, Width, measuredHeight);
                this.label1.Layout(0, 0, Width - measuredWidth, measuredHeight);
            }
            else
            {
                this.imageIcon.Layout(0, 0, measuredWidth, measuredHeight);
                this.label1.Layout(measuredWidth, 0, Width, measuredHeight);
            }
        }

        #endregion
    }

    internal class ContentLabel : TextView
    {
        public ContentLabel(Context context) : base(context)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            this.SetMeasuredDimension(widthMeasureSpec, heightMeasureSpec);
        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            base.OnLayout(changed, left, top, right, bottom);
        }
    }

    internal class ImageViewExt : ImageView
    {
        public ImageViewExt(Context context) : base(context)
        {
            this.SetScaleType(ScaleType.CenterInside);
            var padding = (int)(5 * Resources.DisplayMetrics.Density);
            this.SetPadding(padding, padding, padding, padding);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            this.SetMeasuredDimension(widthMeasureSpec, heightMeasureSpec);
        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            base.OnLayout(changed, left, top, right, bottom);
        }
    }
}