using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OptionTrader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           populateOrderBookTable();
        }

        private void populateOrderBookTable()
        {
            populateOrderBookTableRow(this.BestBidBook.row0,  "PHLX", 0.4, 400);
            populateOrderBookTableRow(this.BestBidBook.row1, "ISE", 0.45, 95);           

        }
        private void populateOrderBookTableRow(OrderBookTableRow row, string exchange, double price, int volume) {
            row.exchange.Content = exchange;
            row.price.Content = price;
            row.volume.Content = volume;
        }
    }
}
