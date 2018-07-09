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

namespace CarsApplicationV3.Views
{
    /// <summary>
    /// Interaction logic for LoadCars.xaml
    /// </summary>
    public partial class LoadCars : Page
    {
        public LoadCars()
        {
            this.DataContext = new ViewModel.LoadVehiclesVM();
            InitializeComponent();
        }
    }
}