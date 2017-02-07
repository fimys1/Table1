using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    class SecondPresentor
    {
        ISecondWindow main;
        IRepository<Customer> customer;

        public SecondPresentor(ISecondWindow main, IRepository<Customer> cust)
        {
            this.main = main;
            customer = cust;
            this.main.addColumn += Main_addColumn;
        }

        private void Main_addColumn(object sender, EventArgs e)
        {
            customer.Create(main.Column);
            customer.Save();
            main.CloseWindow();
        }
    }
}
