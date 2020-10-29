﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board b;
        public MainWindow()
        {
            InitializeComponent();
            b = new Board();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string r = sender.ToString();
            
            if (r== "System.Windows.Controls.Button: White")
            {
                b.setColour(0);
            }
            if(r== "System.Windows.Controls.Button: Red")
            {
                b.setColour(1);
            }
            if (r == "System.Windows.Controls.Button: Yellow")
            {
                b.setColour(2);
            }
        }
    }
}
