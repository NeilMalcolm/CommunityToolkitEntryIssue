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
    private void ShowIssue1Popup()
    {
        // Show our popup
        ShowPopup(new TestPopup()
        {
            BindingContext = new TestPopupViewModel()
        });
    }
    
    [RelayCommand]
    private void ShowIssue2Popup()
    {
        // Show our popup
        ShowPopup(new TestPopup2()
        {
            BindingContext = new TestPopup2ViewModel()
        });
    }

    private void ShowPopup(Popup popupToShow)
    {
        App.Current.MainPage.ShowPopup(popupToShow);
    }
}