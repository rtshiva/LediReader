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

namespace LediReader.Gui
{
    /// <summary>
    /// Interaction logic for BookSettingsControl.xaml
    /// </summary>
    public partial class BookSettingsControl : UserControl
    {
        public BookSettingsControl()
        {
            InitializeComponent();

            this.DataContext = new BookSettingsController();
        }

        public BookSettingsController Controller
        {
            get
            {
                return (BookSettingsController)(this.DataContext);
            }
        }


    }
}
