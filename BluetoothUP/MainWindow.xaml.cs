using System;
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


namespace BluetoothUP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BluetoothLogic btL;
        public MainWindow()
        {
            // order is very important!!
            InitializeComponent();
            btL = new BluetoothLogic();
            this.DataContext = btL;
        }

        private void ClickAdapters_Button(object sender, RoutedEventArgs e)
        {
            btL.UpdateAdapters();
        }

        private void ClickSearch_Button(object sender, RoutedEventArgs e)
        {
            btL.SearchForDevices();
        }

        private void ClickPair_Button(object sender, RoutedEventArgs e)
        {
            btL.ConnectToDevice();
        }
    }

    
}
