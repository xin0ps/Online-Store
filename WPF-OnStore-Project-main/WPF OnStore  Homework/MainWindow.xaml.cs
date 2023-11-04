using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPF_OnStore__Homework;

namespace WPF_OnStore__Homework {
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public ObservableCollection<Product> products { get; set; } = new();
        public ObservableCollection<Product> productsInOrder { get; set; } = new();

        public MainWindow() {
            InitializeComponent();

            products = new ObservableCollection<Product>() {
                new Product() {
                    Id = Guid.NewGuid(),
                    Name = "Coca-Cola",
                    ImageUrl = "https://w1.pngwing.com/pngs/940/1013/png-transparent-coca-cola-fizzy-drinks-cocacola-diet-coke-cocacola-zero-sugar-cocacola-life-coca-cola-drink-supermarket.png",
                    Price = 1.5
                },
                new Product() {
                    Id = Guid.NewGuid(),
                    Name = "Fanta",
                    ImageUrl = "https://pngfre.com/wp-content/uploads/Fanta-1-300x300.png",
                    Price = 1.5
                },
            };

            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void ListView_Selected(object sender, RoutedEventArgs e) {
            ListView? listView = sender as ListView;
            productsInOrder.Add((listView!.SelectedItem as Product)!);
           
            MessageBox.Show(productsInOrder.Count.ToString());
            MessageBox.Show(productsInOrder[0].Name);
        }

        private void CartPagebt_Click(object sender, RoutedEventArgs e) {
            ProductsView.Visibility = Visibility.Hidden;
            ProductsInOrderView.Visibility = Visibility.Visible;
        }

        private void HomePagebt_Click(object sender, RoutedEventArgs e) {
            ProductsView.Visibility = Visibility.Visible;
            ProductsInOrderView.Visibility = Visibility.Hidden;
        }
    }
}
