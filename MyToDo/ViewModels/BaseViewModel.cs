using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyToDo.ViewModels
{

    /*
    public class BaseViewModel : 
    {
        public BaseViewModel()
        {
        }
    }
*/


    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        

        //[NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    }
}

