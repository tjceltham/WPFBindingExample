using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp2
{
    class Board : INotifyPropertyChanged
    {

        private string colourT;
        public event PropertyChangedEventHandler PropertyChanged;
        public Board()
        {
            colourT = "White";
        }
        public string ColourText
        {
            get { return colourT; }
            set { colourT = value;
               OnPropertyChanged("ColourText");
            }
        }

       

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }


        }




    }
}
