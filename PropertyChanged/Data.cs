using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PropertyChanged
{
    class Data : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int data1;

        public int Data1
        {
            get => data1;
            set
            {
                data1 = value; 
                OnPropertyChanged("Data1");
            }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
