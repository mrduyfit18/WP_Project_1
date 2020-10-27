using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Window
    {

        class Food : INotifyPropertyChanged
        {
            public string ID { get; set; }              //ID món ăn 
            public string Name { get; set; }            // Tên món ăn
            public string Material { get; set; }        //Danh sách nguyên liệu
            public bool IsFavorite { get; set; }        //Món yêu thích
            public DateTime DateAdd { get; set; }       //ngày thêm
            public string ImagePath { get; set; }       //đường dẫn ảnh
            public string VideoLink { get; set; }       //link video

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public HomeScreen()
        {
            InitializeComponent();
        }
    }
}
