using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkitEntryIssue.Popups;

public partial class TestPopup2ViewModel : ObservableObject
{
    [ObservableProperty] 
    string _textValue = string.Empty;

    [ObservableProperty] 
    bool _switchValue = false;

    [RelayCommand]
    private void ShowSecondPopup()
    {
        App.Current.MainPage.ShowPopup(new SecondPopup());
    }
}