using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace TestExpanderr;

public partial class MainPage : ContentPage
{
    ExpanderViewModel viewModel;

    public MainPage(ExpanderViewModel vm) {
        InitializeComponent();
        BindingContext = viewModel = vm;
    }

    async void Expander_ExpandedChanged(object sender, ExpandedChangedEventArgs e) {
        var collapsedText = e.IsExpanded ? "expanded" : "collapsed";
        await Toast.Make($"Expander is {collapsedText}").Show(CancellationToken.None);
    }
}

