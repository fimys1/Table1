using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication;

namespace WpfApplication.LogicFolder
{
    class CustomerRepository : IRepository<Customer>
    {
        AppContext appContext;
        public CustomerRepository()
        {
            appContext = new AppContext();
        }

        public void Create(Customer item)
        {
            appContext.Customers.Add(item);
        }

        public void Delete(int id)
        {
            Customer cust = appContext.Customers.Find(id);
            if(cust!=null)
            appContext.Customers.Remove(cust);
        }

        public Customer GetItem(int id)
        {
            return appContext.Customers.Find(id);
        }

        public IEnumerable<Customer> GetItemsList()
        {
            return appContext.Customers;
        }

        public void Save()
        {
            appContext.SaveChanges();
        }

        public void Update(Customer item)
        {
            //Customer tempitem = item;
            //appContext.Entry(tempitem).State = System.Data.Entity.EntityState.Modified;
            Customer tempCust = appContext.Customers.Find(item.Id);
            if (tempCust != null)
            {
                tempCust.FirstName = item.FirstName;
                tempCust.LastName = item.LastName;
                tempCust.Email = item.Email;
                tempCust.Age = item.Age;
                appContext.Entry(tempCust).State = System.Data.Entity.EntityState.Modified;
            }            
        }
    }
}
