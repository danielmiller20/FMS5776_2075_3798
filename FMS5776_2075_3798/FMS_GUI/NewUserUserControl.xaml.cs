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
using System.Windows.Shapes;
using FMS_adapter;

namespace FMS_GUI
{
    /// <summary>
    /// Interaction logic for NewUserUserControl.xaml
    /// </summary>
    public partial class NewUserUserControl : UserControl
    {
        public NewUserUserControl()
        {
            InitializeComponent();
            this.SLevelComboBox.ItemsSource = Enum.GetValues(typeof(SLEVEL));
        }

        private void newUserButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow w = Window.GetWindow(this) as MainWindow;
                var x = w.MainFrame.Content as MainPage;
                x.codpContentControl.Content = null;
                x.shadowRectangle.Visibility = Visibility.Collapsed;
                x.disk.addUser(this.UserNameTextBox.Text,(SLEVEL) SLevelComboBox.SelectedItem,this.DiskPwdBox.Password,x.disk.getCU().SLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
