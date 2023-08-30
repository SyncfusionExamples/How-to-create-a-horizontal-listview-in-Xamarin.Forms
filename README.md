# How to create a horizontal listview in Xamarin.Forms

This example demonstrates how to create a horizontal listview using Xamarin.Forms SfListView.

```
<syncfusion:SfListView x:Name="listView" Orientation="Horizontal" Padding="10,10,10,10"
                                   SelectionMode="None" Grid.Row="1"
                                   ItemsSource="{Binding Gallerynfo}"
                                   ItemSpacing="3">
                <syncfusion:SfListView.ItemTemplate>
                  <!-- your content Template here..-->
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
```

See [How to create a horizontal listview in Xamarin.Forms](https://www.syncfusion.com/kb/9631/how-to-create-a-horizontal-listview-in-xamarin-forms) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
