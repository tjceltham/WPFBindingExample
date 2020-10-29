using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    class Board
    {
        private int colour = 0;
        private string colourT = "White";
        public void setColour(int c)
        {
            colour = c;
        }
        
        public string ColourText
        {
            get { return colourT; }
            set { colourT = value; }
        }
    }
}
