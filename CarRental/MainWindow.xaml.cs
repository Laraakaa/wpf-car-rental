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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarRental.Data;

namespace CarRental
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RentalDB3Entities _context = new RentalDB3Entities();

        public MainWindow()
        {
            //DataContext = _context;
            //Login login = new Login();
            //login.ShowDialog();
            InitializeComponent();

            Car car = _context.Cars.ToList()[0];

            List.Items.Add(car);

            for (int i = 0; i < _context.Rentals.Count(); i++)
            {
                Rental rental = _context.Rentals.ToList()[i];
                FutureRentals.RowDefinitions.Add(new RowDefinition()
                {
                    Height = GridLength.Auto
                });

                Label pickup = new Label
                {
                    Content = rental.Pickup,
                    FontSize = 25
                };
                Grid.SetRow(pickup, i);
                Grid.SetColumn(pickup, 0);
                FutureRentals.Children.Add(pickup);

                Label description = new Label
                {
                    Content = rental.Car.ExtendedDescription,
                    FontSize = 25
                };
                Grid.SetRow(description, i);
                Grid.SetColumn(description, 1);
                FutureRentals.Children.Add(description);

                Label price = new Label
                {
                    Content = rental.Price,
                    FontSize = 25,
                    HorizontalAlignment = HorizontalAlignment.Right
                };
                Grid.SetRow(price, i);
                Grid.SetColumn(price, 2);
                FutureRentals.Children.Add(price);

                Button button = new Button
                {
                    Content = "X",
                    FontSize = 25,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Padding = new Thickness
                    {
                        Left = 5,
                        Right = 5
                    }
                };
                Grid.SetRow(button, i);
                Grid.SetColumn(button, 3);
                FutureRentals.Children.Add(button);
            }
        }
    }
}
