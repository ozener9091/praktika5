using System;

namespace Classes
{

    public class MobileDevice
    {
        protected string model;
        protected string manufacturer;
        protected double price;
        protected int year;

        //Конструктор
        public MobileDevice(string _model = "Неизвестно", string _manufacturer = "Неизвестно", double _price = 0.0, int _year = 2000)
        {
            Model = _model;
            Manufacturer = _manufacturer;
            Price = _price;
            Year = _year;
        }

        public override string ToString()
        {
            return $"Модель: '{Model}'   Производитель: '{Manufacturer}'   Цена: {Price} руб.   Год: {Year}";
        }

        //Свойства
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new NullReferenceException("Название модели не может быть пустым."); }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Название производителя не может быть пустым."); }
                manufacturer = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) { throw new ArgumentException("Цена не может быть отрицательной."); }
                price = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < 1980 || value > currentYear) { throw new ArgumentException($"Год должен быть между 1980 и {currentYear}."); }
                year = value;
            }
        }

    }

    public class Smartphone : MobileDevice
    {
        private double screenSize;
        private string screenResolution;
        private int cameraSize;
        private int ramSize;

        //Конструктор
        public Smartphone(string _model = "Неизвестно", string _manufacturer = "Неизвестно", double _price = 0.0, int _year = 2000,
            double _screenSize = 15.0, string _screenResolution = "1920x1080", int _cameraSize = 2, int _ramSize = 4) : base(_model, _manufacturer, _price, _year)
        {
            ScreenSize = _screenSize;
            ScreenResolution = _screenResolution;
            CameraSize = _cameraSize;
            RamSize = _ramSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nРазмер экрана: {screenSize} дюймов    Разрешение экрана: {screenResolution}    Камера: {cameraSize} МП.    Память: {ramSize} ГБ";
        }

        // Свойства
        public double ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (value <= 0) { throw new NullReferenceException("Размер экрана должен быть положительным."); }
                screenSize = value;
            }
        }

        public string ScreenResolution
        {
            get { return screenResolution; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new NullReferenceException("Разрешение экрана не может быть пустым."); }
                screenResolution = value;
            }
        }

        public int CameraSize
        {
            get { return cameraSize; }
            set
            {
                if (value <= 0) { throw new NullReferenceException("Разрешение камеры должно быть положительным."); }
                cameraSize = value;
            }
        }

        public int RamSize
        {
            get { return ramSize; }
            set
            {
                if (value <= 0) { throw new NullReferenceException("Память должна быть положительной."); }
                ramSize = value;
            }
        }
    }

    public class EBookReader : MobileDevice
    {
        private double screenSize;
        private string screenType;
        private string supportedFormats;
        private int batteryCapacity;


        public EBookReader(string _model = "Неизвестно", string _manufacturer = "Неизвестно", double _price = 0.0, int _year = 2000,
            double _screenSize = 6.0, string _screenType = "E-Ink", string _supportedFormats = "PDF, EPUB", int _batteryCapacity = 1000)
            : base(_model, _manufacturer, _price, _year)
        {
            ScreenSize = _screenSize;
            ScreenType = _screenType;
            SupportedFormats = _supportedFormats;
            BatteryCapacity = _batteryCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nРазмер экрана: {screenSize} дюйм    Тип экрана: {screenType}    Форматы: {supportedFormats}    Аккумулятор: {batteryCapacity} мАч";
        }

        //Свойства
        public double ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (value <= 0) { throw new NullReferenceException("Размер экрана должен быть положительным."); }
                screenSize = value;
            }
        }
        public string ScreenType
        {
            get { return screenType; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new NullReferenceException("Тип экрана не может быть пустым."); }
                screenType = value;
            }
        }
        public string SupportedFormats
        {
            get { return supportedFormats; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new NullReferenceException("Поддерживаемые форматы не могут быть пустыми."); }
                supportedFormats = value;
            }
        }
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            set
            {
                if (value <= 0) { throw new NullReferenceException("Ёмкость аккумулятора должна быть положительной."); }
                batteryCapacity = value;
            }
        }
    }
}
