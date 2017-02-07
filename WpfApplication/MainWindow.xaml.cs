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
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow 
    {
        IRepository<Customer> cust;
        public MainWindow()
        {
            cust = new CustomerRepository();
            InitializeComponent();
            new Presenter(this, cust);
        }

        public List<Customer> Customers
        {
            get
            {
                return (List<Customer>)listBox.ItemsSource;
            }

            set
            {
                listBox.ItemsSource = value;
            }
        }

        public Customer SelectedCustomer
        {
            get
            {
                return (Customer)listBox.SelectedItem;
            }
        }

        public event EventHandler UpdateColumn = null;
        public event EventHandler AddColumn = null;
        public event EventHandler DeletedColumn = null;
        public event EventHandler ChengedColumn = null;

        public void ShowEditCastomerWindow()
        { //открытие под-окна для добавления строки
            WindowChangeTable window = new WindowChangeTable();
            window.ShowDialog();                                      
        }

        private void Add_Column_Click(object sender, RoutedEventArgs e)
        { //Запуск обработчика события добавления строки в таблицу
            if (AddColumn != null)
                AddColumn.Invoke(sender, e);
        }

        private void Database_Loaded(object sender, RoutedEventArgs e)
        { //Запуск обработчика события обновления таблици при запуске программы
            if (UpdateColumn != null)
                UpdateColumn.Invoke(sender, e);
        }

        private void Deleted_Column_Click(object sender, RoutedEventArgs e)
        { //Запуск обработчика события удаление строки из таблицу
            if (DeletedColumn != null)
                DeletedColumn.Invoke(sender, e);
        }

        private void Сhanged_Column_Click(object sender, RoutedEventArgs e)
        {   //открытие под-окна для изменения строки            
            if (ChengedColumn != null)
                ChengedColumn.Invoke(sender, e);
        }

        public Customer ShowChenged(Customer arg)
        {
            ChangedWindow changedWindow = new ChangedWindow(arg);
            changedWindow.ShowDialog();
            return changedWindow.Feald;
        }
    }
}
