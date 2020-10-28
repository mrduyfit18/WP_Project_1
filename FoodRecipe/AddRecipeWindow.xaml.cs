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

        class StepDao
        {
            public static BindingList<Step> GetAll()
            {
                var list = new BindingList<Step>()
                {
                    new Step(){ Order = 1, ImagePath="images/Splash/0.jpg", Content = "abc"},
                };
                return list;
            }
        }

        public AddRecipeWindow()
        {
            InitializeComponent();
        }


        BindingList<Step> _list;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _list = StepDao.GetAll();
            newlist.ItemsSource = _list;
        }

        private void abc(object sender, RoutedEventArgs e)
        {
            Step a = new Step() { Order = _list[_list.Count-1].Order+1};
            _list.Add(a);
        }

    }
}
