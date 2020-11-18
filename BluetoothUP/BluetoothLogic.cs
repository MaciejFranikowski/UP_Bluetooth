using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace BluetoothUP
{
    class BluetoothLogic : INotifyPropertyChanged
    {
        // Bluetooth adapters on the server
        public ObservableCollection<BluetoothRadio> BtAdapters { get; set; }
        // Chosen bluetooth adapter on the server
        public BluetoothRadio CurrentAdapter
        {
            get { return currentAdapter; }
            set
            {
                currentAdapter = value;
                this.OnPropertyChanged("CurrentAdapter");
            }
        }
        private BluetoothRadio currentAdapter;

        // Creating the servers I think
        private BluetoothEndPoint localEndPoint;
        // The client
        private BluetoothClient client;
        // Available bt devices
        public ObservableCollection<BluetoothDeviceInfo> BluetoothDevices { get; set; }
        // Chosen BT device

        public BluetoothDeviceInfo ChosenDevice 
        {
            get { return chosenDevice; }
            set
            {
                chosenDevice = value;
                this.OnPropertyChanged("ChosenDevice");
            }
        }
        private BluetoothDeviceInfo chosenDevice;


        public BluetoothLogic() 
        {
            BtAdapters = new ObservableCollection<BluetoothRadio>();
            BluetoothDevices = new ObservableCollection<BluetoothDeviceInfo>();
        }
        public void UpdateAdapters()
        {
            BtAdapters.Clear();
            BluetoothRadio[] temp = BluetoothRadio.AllRadios;
           
            foreach (BluetoothRadio adapter in temp)
            {
                BtAdapters.Add(adapter);
            }

            if (BtAdapters.Any())
            {
                // If we write currentAdapter = BtAdapters[0], this doesnt update instatnly. Why?
                // Property assignment vs variable?
                CurrentAdapter = BtAdapters[0];
            }
            else
            {
                MessageBox.Show("No adapters were found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                

        }

        public void SearchForDevices()
        {
            BluetoothDevices.Clear();
            localEndPoint = new BluetoothEndPoint(CurrentAdapter.LocalAddress, BluetoothService.SerialPort);
            client = new BluetoothClient(localEndPoint);
            foreach (BluetoothDeviceInfo device in client.DiscoverDevices())
            {
                BluetoothDevices.Add(device);
            }
           
            if (BluetoothDevices.Any())
            {
                ChosenDevice = BluetoothDevices[0];
            }
            else
            {
                MessageBox.Show("No bluetooth devices were found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void ConnectToDevice()
        {
            try
            {
                BluetoothSecurity.PairRequest(ChosenDevice.DeviceAddress, "123456");
            }
            catch
            {
                Console.WriteLine("Couldn't pair with" + ChosenDevice.DeviceName.ToString());
            }
        }

        #region INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        #endregion
    }

}
