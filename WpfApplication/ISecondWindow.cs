using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    interface ISecondWindow
    {
        event EventHandler addColumn;
        Customer Column { get; }
        void CloseWindow();    
    }
}
