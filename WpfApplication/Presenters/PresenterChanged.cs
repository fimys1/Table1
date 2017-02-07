using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.LogicFolder;

namespace WpfApplication
{
    class PresenterChanged
    {
        IChengedColumn window;
        public PresenterChanged(IChengedColumn iCC)
        {
            this.window = iCC;
            window.ChengedColumn += Window_ChengedColumn;
        }
        

        private void Window_ChengedColumn(object sender, EventArgs e)
        {
            window.CloseWindow();
        }
    }
}
