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
using WpfApplication.LogicFolder;
using WpfApplication;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для ChangedWindow.xaml
    /// </summary>
    public partial class ChangedWindow : Window , IChengedColumn
    {
        public ChangedWindow(Customer cust)
        {
            InitializeComponent();
            new PresenterChanged(this);
            Feald = cust;
        }
        
        private int id;
        public Customer Feald
        {
            set
            {
                id = value.Id;
                textBoxFirstName.Text = value.FirstName;
                textBoxLastName.Text = value.LastName;
                textBoxEmail.Text = value.Email;
                textBoxAge.Text = value.Age.ToString();                
            }
            get
            {
                return new Customer
                {
                    Id = id,
                    Age = int.Parse(textBoxAge.Text),
                    Email = textBoxEmail.Text,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text
                };
            }
        }

        public event EventHandler ChengedColumn = null;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ChengedColumn != null)
                ChengedColumn.Invoke(sender, e);
        }
        
        public void CloseWindow()
        {
            this.Close();
        }
    }
}
