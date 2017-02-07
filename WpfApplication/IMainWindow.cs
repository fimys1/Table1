using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    interface IMainWindow
    {
        List<Customer> Customers
        {
            get;
            set;
        }
        event EventHandler DeletedColumn;
        event EventHandler AddColumn;
        event EventHandler UpdateColumn;
        event EventHandler ChengedColumn;
        Customer SelectedCustomer
        {
            get;
        }
        void ShowEditCastomerWindow();
        Customer ShowChenged(Customer arg);
    }
}
