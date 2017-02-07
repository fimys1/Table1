using System;
using System.Windows;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для WindowChangeTable.xaml
    /// </summary>
    public partial class WindowChangeTable : Window , ISecondWindow
    {
        public WindowChangeTable()
        {
            InitializeComponent();
            new SecondPresentor(this, new CustomerRepository());
        }

        public Customer Column
        {
            get
            {
                return new Customer()
                {
                    Age = int.Parse(textBox.Text),
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Email = textBox3.Text
                };
            }
        }

        public event EventHandler addColumn = null;

        public void CloseWindow()
        {
            this.Close();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (addColumn != null)
                addColumn.Invoke(sender, e);
        }
    }
}
