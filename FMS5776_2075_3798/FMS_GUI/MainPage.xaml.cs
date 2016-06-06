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

namespace FMS_GUI
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public CreateOpenDiskPage codp { get; set; }
        public MainPage()
        {
            InitializeComponent();
            codp = new CreateOpenDiskPage();
            this.codpContentControl.DataContext = this;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ChooseUserPage usersPage = new ChooseUserPage();
            this.NavigationService.Navigate(usersPage); 
        }
    }
}