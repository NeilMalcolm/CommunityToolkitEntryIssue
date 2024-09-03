using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkitEntryIssue.Popups;

namespace CommunityToolkitEntryIssue;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private void ShowPopup()
    {
        // Show our popup
        App.Current.MainPage.ShowPopup(new TestPopup()
        {
            BindingContext = new TestPopupViewModel()
        });
    }
}