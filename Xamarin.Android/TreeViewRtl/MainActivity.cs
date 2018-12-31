using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Syncfusion.TreeView.Engine;
using Syncfusion.Android.TreeView;

namespace TreeViewRtl
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SfTreeView treeView = FindViewById<SfTreeView>(Resource.Id.sfTreeView1);
            FileManagerViewModel viewModel = new FileManagerViewModel();

            // You can also change layout direction of treeview by changing device layout direction
            treeView.LayoutDirection = Android.Views.LayoutDirection.Rtl;
            treeView.AutoExpandMode = AutoExpandMode.RootNodesExpanded;
            treeView.ChildPropertyName = "SubFiles";
            treeView.ItemsSource = viewModel.Folders;
            treeView.Adapter = new CustomAdapter();

        }
    }
}