using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Timers;
using System.IO;
using System.Drawing;
using System.ComponentModel;

namespace FoodRecipe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
    
        public SplashScreen()
        {
            InitializeComponent();
        }

        public string Select { get; set; }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var value = ConfigurationManager.AppSettings["ShowSplashScreen"];
            var status = bool.Parse(value);


            if (status == false)
            {
                var screen = new HomeScreen();
                screen.Show();
                this.Close();
            }
            Random rng = new Random();
            int sel = rng.Next(4);
            string sel_c = sel.ToString();
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = $"{folder}data/splashInfo.txt";
            picture a = new picture
            {
                PicPath = $"{folder}images/Splash/{sel_c}.jpg"
            };
            this.DataContext = a;
            var splashInfo = File.ReadAllLines(filePath);
            txtAmazingInfo.Text = splashInfo[sel];           
        }


        private void NotShowSplashScreen_check(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(
                 ConfigurationUserLevel.None);
            config.AppSettings.Settings["ShowSplashScreen"].Value = "false";
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void NotShowSplashScreen_uncheck(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(
                 ConfigurationUserLevel.None);
            config.AppSettings.Settings["ShowSplashScreen"].Value = "true";
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            var screen = new HomeScreen();
            screen.Show();
            this.Close();
        }
    }

    
    public class picture
    {
        public string PicPath { get; set; }

    }
}
