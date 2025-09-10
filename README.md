# Right to left example of Xamarin.Forms, Xamarin.Android and Xamarin.iOS TreeView?

This example describes how SfTreeView works with right-to-left when device language or device layout direction changed.  

## Sample
You can use SfTreeView with RTL in Xamarin.Forms by setting the FlowDirection property for SfTreeView.

### Xaml
Set FlowDirection as RightToLeft to TreeView.
```xaml
<treeview:SfTreeView x:Name="treeView" ItemHeight="40" Indentation="15" ExpanderWidth="40" AutoExpandMode="AllNodesExpanded" VerticalOptions="Center"
                        FlowDirection="{OnPlatform Android='RightToLeft',iOS='RightToLeft'}" ItemTemplateContextType="Node" ChildPropertyName="SubFiles" 
                        ItemsSource="{Binding ImageNodeInfo}">
    <treeview:SfTreeView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid x:Name="grid" Padding="5,5,5,5" RowSpacing="0">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="40" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <Image Source="{Binding Content.ImageIcon}" VerticalOptions="Center" HorizontalOptions="Center"
                                HeightRequest="35" WidthRequest="35"/>
                        <Grid Grid.Column="1" RowSpacing="1" Padding="1,0,0,0" VerticalOptions="Center">
                            <Label Text="{Binding Content.ItemName}" LineBreakMode="NoWrap" VerticalTextAlignment="Center" HorizontalOptions="{OnPlatform iOS='StartAndExpand'}"/>
                        </Grid>
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </treeview:SfTreeView.ItemTemplate>
</treeview:SfTreeView>
```
In UWP platform, the ScrollView is not changed when RTL is enabled (framework issue). To overcome this issue, set the FlowDirection property in constructor of MainPage in UWP renderer.

### C#
Set FlowDirection to RightToLeft in constructor of MainPage
```csharp
namespace TreeViewXamarin.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.FlowDirection = FlowDirection.RightToLeft;
            SfTreeViewRenderer.Init();
            LoadApplication(new TreeViewXamarin.App());
        }
    }
}
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.