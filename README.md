# How to create a horizontal listview in Xamarin.Forms

This example demonstrates how to create a horizontal listview using Xamarin.Forms SfListView.

## Sample
```xaml
        <Grid>
            <syncfusion:SfListView x:Name="listView"
                                   Orientation="Horizontal"
                                   ItemsSource="{Binding Gallerynfo}">

                <syncfusion:SfListView.ItemTemplate>
                    <DataTemplate>
                        <Frame BackgroundColor="#EEEEEE" Padding="2">
                            <Frame.HasShadow>
                                <OnPlatform x:TypeArguments="x:Boolean">
                                    <On Platform="Android" Value="True"/>
                                    <On Platform="UWP" Value="True"/>
                                    <On Platform="iOS,macOS" Value="False"/>
                                </OnPlatform>
                            </Frame.HasShadow>
                            <Grid RowSpacing="0" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="*" />
                                    <RowDefinition Height="48" />
                                </Grid.RowDefinitions>
                                <Image Source="{Binding Image}" Aspect="Fill"/>
                                <Label Grid.Row="1" Text="{Binding ImageTitle}"
                                       LineBreakMode="WordWrap"
                                       HorizontalTextAlignment="Start"
                                       VerticalTextAlignment="Center"
                                       TextColor="Black" Opacity="0.87"
                                       Margin="16,0,0,0" FontSize="16">
                                </Label>
                            </Grid>
                        </Frame>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
        </Grid>
```

See [How to create a horizontal listview in Xamarin.Forms](https://www.syncfusion.com/kb/9631/how-to-create-a-horizontal-listview-in-xamarin-forms) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
