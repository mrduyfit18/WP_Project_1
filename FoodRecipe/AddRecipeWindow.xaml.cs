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
using System.Windows.Shapes;
using System.ComponentModel;


namespace FoodRecipe
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        class Step : INotifyPropertyChanged
        {
            public int Order { get; set; }              //thứ tự bước
            public string ImagePath { get; set; }       //đường dẫn ảnh của bước
            public string Content { get; set; }         //mô tả bước

            public event PropertyChangedEventHandler PropertyChanged;
        }

        

        public AddRecipeWindow()
        {
            InitializeComponent();
        }

   
        private void newClick(object sender, RoutedEventArgs e)
        {
            var a = new ListBoxItem();
            a.Template = newlist.Resources["addStepForm"] as ControlTemplate;
            newlist.Children.Add(a);
        }
    }

}
