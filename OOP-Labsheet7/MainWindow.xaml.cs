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

namespace OOP_Labsheet7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Method will run when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create 3 Expense Objects
            Expense e1 = new Expense() { Category = "Travel", Amount = 19.95m, ExpenseDate = new DateTime(2019, 6, 30) };

            Expense e2 = new Expense() { Category = "Entertainment", Amount = 99.95m, ExpenseDate = new DateTime(2019, 7, 30) };

            Expense e3 = new Expense() { Category = "Office", Amount = 9.99m, ExpenseDate = new DateTime(2019, 6, 25) };

            //Add those to a list
            List<Expense> expenses = new List<Expense>();
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            //Display ListBox
            lbxExpenses.ItemsSource = expenses;

        }
    }
}
