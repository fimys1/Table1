using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    class Presenter
    {
        IMainWindow mainWindow;
        IRepository<Customer> customer;
        public Presenter(IMainWindow mainWindow,IRepository<Customer> cust)
        {
            this.mainWindow = mainWindow;
            this.customer = cust;
            this.mainWindow.DeletedColumn += MainWindow_DeletedColumn;
            this.mainWindow.AddColumn += MainWindow_ChangeTable;
            this.mainWindow.UpdateColumn += MainWindow_UpdateColumn;
            this.mainWindow.ChengedColumn += MainWindow_ChengedColumn;
        }

        private void MainWindow_ChengedColumn(object sender, EventArgs e)
        {
            Customer custom = mainWindow.ShowChenged(mainWindow.SelectedCustomer);
            //customer = new CustomerRepository();
            customer.Update(custom);
            customer.Save();
            mainWindow.Customers = customer.GetItemsList().ToList();
        }

        private void MainWindow_DeletedColumn(object sender, EventArgs e)
        {   //удаление строки по ID

            customer.Delete(mainWindow.SelectedCustomer.Id);
            customer.Save();
            mainWindow.Customers = customer.GetItemsList().ToList();
        }

        private async void MainWindow_UpdateColumn(object sender, EventArgs e)
        {
            mainWindow.Customers = await Task<List<Customer>>.Factory.StartNew(() => customer.GetItemsList().ToList());
        }

        private void MainWindow_ChangeTable(object sender, EventArgs e)
        {   //добавление строки
            mainWindow.ShowEditCastomerWindow();
            mainWindow.Customers = customer.GetItemsList().ToList();
        }
    }
}
