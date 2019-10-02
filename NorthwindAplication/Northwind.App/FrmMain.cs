using Northwind.App.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Northwind.App
{
    public partial class FrmMain : Form
    {
        private FrmRegister _frmRegister;

        public bool IsLogout { get; internal set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private bool IsChildFromExists(Form frm)
        {
            return !(frm == null || frm.IsDisposed);
        }

        private void ShowForm<T>(object sender,  ref T form)
        {
            var header = GetMenuTitle(sender);
            if (!IsChildFromExists((DockContent)(object)form))
                form = (T)Activator.CreateInstance(typeof(T), header);

            ((DockContent)(object)form).Show(this.mainDock);
        }

        private string GetMenuTitle(object sender)
        {
            var title = string.Empty;
            if (sender is ToolStripMenuItem)
                title = ((ToolStripMenuItem)sender).Text;
            else
                title = ((ToolStripButton)sender).Text;

            return title;
        }

        private void MnuRegister_Click(object sender, EventArgs e)
        {
            ShowForm<FrmRegister>(sender, ref _frmRegister);
        }
    }
}
