using HotelAdmin.Models;
using HotelAdmin.Pages;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace HotelAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Storage));
            StreamReader sr = new StreamReader("storage.xml");
            Storage.Instance = (Storage)xmlSerializer.Deserialize(sr);
            sr.Close();

            frameMain.Navigate(new MainPage());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Storage));
            StreamWriter streamWriter = new StreamWriter("storage.xml");
            xmlSerializer.Serialize(streamWriter, Storage.Instance);

            streamWriter.Close();
        }
    }
}
