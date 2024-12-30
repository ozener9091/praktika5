using praktika5.AddWindows;
using praktika5.PrintWindows;
using System;
using System.Windows;
using Classes;
using System.Collections.ObjectModel;

namespace praktika5
{
    public partial class MainWindow : Window
    {
        static public ObservableCollection<MobileDevice> mobileDeviceList = new ObservableCollection<MobileDevice>();
        public MainWindow()
        {
            InitializeComponent();
            mobileDeviceList.Add(new MobileDevice());
            mobileDeviceList.Add(new Smartphone());
            mobileDeviceList.Add(new EBookReader());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow();
            addWindow.ShowDialog();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            var printWindow = new PrintWIndow();
            printWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
