using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    interface IChengedColumn
    {
        event EventHandler ChengedColumn;
        void CloseWindow();
        Customer Feald
        {
            set;
            get;
        }        
    }
}
