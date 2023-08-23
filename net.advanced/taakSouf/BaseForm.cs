using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taakSouf
{
    public class BaseForm : Form
    {
        private HomeForm _homeForm { get; set; }
        private Guid _guid { get; set; }

        public BaseForm(HomeForm homeform, Guid g)
        {
                _homeForm = homeform;
                _guid = g;
                _homeForm.NewWindow += _homeForm_NewWindow;
        }

        private void _homeForm_NewWindow(object? sender, Guid e)
        {
            if (e != _guid) this.Hide();
        }
    }


}
