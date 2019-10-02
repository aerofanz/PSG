using Northwind.Helper.UI.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.App.Utility
{
    public partial class FrmRegister : FrmEntryMaster
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        public FrmRegister(string header) : base(header)
        {
            InitializeComponent();
        }
    }
}
