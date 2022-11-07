
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleMVVM.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    // these are the items we want to watch for changes
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _isBusy;
    [ObservableProperty]
    string _pageTitle;

    public bool IsNotBusy => !IsBusy;









    //public bool IsBusy
    //{
    //    get => _isBusy;

    //    set
    //    {
    //        if (_isBusy == value)
    //            return;
    //        _isBusy = value;
    //        //OnPropertyChanged(nameof(IsBusy));  // same as OnPropertyChanged("IsBusy");
    //        //OnPropertyChanged(nameof(IsNotBusy));

    //        OnPropertyChanged();
    //    }
    //}

    //public string PageTitle
    //{
    //    get => _pageTitle;

    //    set
    //    {
    //        if (_pageTitle == value)
    //            return;
    //        _pageTitle = value;
    //        //OnPropertyChanged(nameof(PageTitle)); not needed due to [callerMemberName]
    //        OnPropertyChanged();
    //    }
    //}


    //// This is a delegate, a method that will handle the PropertyChanged event when raised when a property chaanges value
    //// This is the event that the .net maui uses to upddate the view when the data in the viewModel changes
    //public event PropertyChangedEventHandler PropertyChanged;

    //public void OnPropertyChanged([CallerMemberName] string name = null)
    //{

    //    // [CallerMemberName] is a runtime compiler service which looks up at runtime which property invoked the onpropertyChanged method
    //    // and passes the name of the property

    //    // PropertyChanged is the event defined above as the propertyChangedEventHAndler
    //    // the ? is a null check which checks if anything is currently subscribes to the event
    //    // and if so invoke the event, passing itself (the viewmodel) and the name of teh property that has changed 
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}
}
