using System.Windows;

namespace praktika5.PrintWindows
{
    public partial class PrintWIndow : Window
    {
        public PrintWIndow()
        {
            InitializeComponent();
            DevicesList.ItemsSource = MainWindow.mobileDeviceList;
        }
    }
}
