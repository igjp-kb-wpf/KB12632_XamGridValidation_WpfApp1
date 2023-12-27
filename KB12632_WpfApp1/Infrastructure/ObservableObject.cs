using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KB12632_WpfApp1.Infrastructure
{
    internal abstract class ObservableObject : INotifyPropertyChanged
    {
        public ObservableObject()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
