using Classes;
using System;
using System.Windows;
using System.Windows.Controls;

namespace praktika5.AddWindows
{
    public partial class AddWindow : Window
    {
        static public ComboBoxItem selectedItem = null;
        public AddWindow()
        {
            InitializeComponent();
        }

        private void SelectDeviceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Получаем выбранный элемент ComboBox
            selectedItem = (ComboBoxItem)SelectDeviceType.SelectedItem;

            // В зависимости от выбранного элемента показываем или скрываем элементы
            if (selectedItem != null)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Мобильное устройство":

                        ModelText.Visibility = Visibility.Visible;
                        ModelEnter.Visibility = Visibility.Visible;

                        ManufacturerText.Visibility = Visibility.Visible;
                        ManufacturerEnter.Visibility = Visibility.Visible;

                        PriceText.Visibility = Visibility.Visible;
                        PriceEnter.Visibility = Visibility.Visible;

                        YearText.Visibility = Visibility.Visible;
                        YearEnter.Visibility = Visibility.Visible;

                        ScreeSizeText.Visibility = Visibility.Collapsed;
                        ScreenSizeEnter.Visibility = Visibility.Collapsed;

                        ScreenResolutionText.Visibility = Visibility.Collapsed;
                        ScreenResolutionEnter.Visibility = Visibility.Collapsed;

                        CameraSizeText.Visibility = Visibility.Collapsed;
                        CameraSizeEnter.Visibility = Visibility.Collapsed;

                        RamSizeText.Visibility = Visibility.Collapsed;
                        RamSizeEnter.Visibility = Visibility.Collapsed;

                        ScreenTypeText.Visibility = Visibility.Collapsed;
                        ScreenTypeEnter.Visibility = Visibility.Collapsed;

                        BatteryCapacityText.Visibility = Visibility.Collapsed;
                        BatteryCapacityEnter.Visibility = Visibility.Collapsed;

                        FormatText.Visibility = Visibility.Collapsed;
                        FormatEnter.Visibility = Visibility.Collapsed;



                        break;
                    case "Смартфон":
                        ModelText.Visibility = Visibility.Visible;
                        ModelEnter.Visibility = Visibility.Visible;

                        ManufacturerText.Visibility = Visibility.Visible;
                        ManufacturerEnter.Visibility = Visibility.Visible;

                        PriceText.Visibility = Visibility.Visible;
                        PriceEnter.Visibility = Visibility.Visible;

                        YearText.Visibility = Visibility.Visible;
                        YearEnter.Visibility = Visibility.Visible;

                        ScreeSizeText.Visibility = Visibility.Visible;
                        ScreenSizeEnter.Visibility = Visibility.Visible;

                        ScreenResolutionText.Visibility = Visibility.Visible;
                        ScreenResolutionEnter.Visibility = Visibility.Visible;

                        CameraSizeText.Visibility = Visibility.Visible;
                        CameraSizeEnter.Visibility = Visibility.Visible;

                        RamSizeText.Visibility = Visibility.Visible;
                        RamSizeEnter.Visibility = Visibility.Visible;

                        ScreenTypeText.Visibility = Visibility.Collapsed;
                        ScreenTypeEnter.Visibility = Visibility.Collapsed;

                        FormatText.Visibility = Visibility.Collapsed;
                        FormatEnter.Visibility = Visibility.Collapsed;

                        BatteryCapacityText.Visibility = Visibility.Collapsed;
                        BatteryCapacityEnter.Visibility = Visibility.Collapsed;

                        break;
                    case "Электронная книга":
                        ModelText.Visibility = Visibility.Visible;
                        ModelEnter.Visibility = Visibility.Visible;

                        ManufacturerText.Visibility = Visibility.Visible;
                        ManufacturerEnter.Visibility = Visibility.Visible;

                        PriceText.Visibility = Visibility.Visible;
                        PriceEnter.Visibility = Visibility.Visible;

                        YearText.Visibility = Visibility.Visible;
                        YearEnter.Visibility = Visibility.Visible;

                        ScreeSizeText.Visibility= Visibility.Visible;
                        ScreenSizeEnter.Visibility= Visibility.Visible;

                        ScreenTypeText.Visibility = Visibility.Visible;
                        ScreenTypeEnter.Visibility = Visibility.Visible;

                        FormatText.Visibility = Visibility.Visible;
                        FormatEnter.Visibility = Visibility.Visible;

                        BatteryCapacityText.Visibility = Visibility.Visible;
                        BatteryCapacityEnter.Visibility = Visibility.Visible;

                        ScreenResolutionText.Visibility = Visibility.Collapsed;
                        ScreenResolutionEnter.Visibility = Visibility.Collapsed;

                        CameraSizeText.Visibility = Visibility.Collapsed;
                        CameraSizeEnter.Visibility = Visibility.Collapsed;

                        RamSizeText.Visibility = Visibility.Collapsed;
                        RamSizeEnter.Visibility = Visibility.Collapsed;

                        break;
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedItem == null)
                {
                    MessageBox.Show(
                        "Выберите тип устройства", // Текст ошибки
                        "Ошибка",   // Заголовок окна
                        MessageBoxButton.OK, // Кнопки в окне
                        MessageBoxImage.Warning // Иконка ошибки
                        );
                }
                else
                {
                    switch (selectedItem.Content)
                    {
                        case "Мобильное устройство":
                            var newMobileDevice = new MobileDevice(
                                ModelEnter.Text,
                                ManufacturerEnter.Text,
                                double.Parse(PriceEnter.Text),
                                int.Parse(YearEnter.Text));
                            MainWindow.mobileDeviceList.Add(newMobileDevice);
                            Close();
                            break;

                        case "Смартфон":

                            var newSmartphone = new Smartphone(
                                ModelEnter.Text,
                                ManufacturerEnter.Text,
                                double.Parse(PriceEnter.Text),
                                int.Parse(YearEnter.Text),
                                double.Parse(ScreenSizeEnter.Text),
                                ScreenResolutionEnter.Text,
                                int.Parse(CameraSizeEnter.Text),
                                int.Parse(RamSizeEnter.Text)
                                );
                            MainWindow.mobileDeviceList.Add(newSmartphone);
                            Close();
                            break;

                        case "Электронная книга":

                            var newEBook = new EBookReader(
                                ModelEnter.Text,
                                ManufacturerEnter.Text,
                                double.Parse(PriceEnter.Text),
                                int.Parse(YearEnter.Text),
                                double.Parse(ScreenSizeEnter.Text),
                                ScreenTypeEnter.Text,
                                FormatEnter.Text,
                                int.Parse(BatteryCapacityEnter.Text)
                                );
                            MainWindow.mobileDeviceList.Add(newEBook);
                            Close();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, // Текст ошибки
                    "Ошибка",   // Заголовок окна
                    MessageBoxButton.OK, // Кнопки в окне
                    MessageBoxImage.Error // Иконка ошибки
                );
            }
        }
    }
}
