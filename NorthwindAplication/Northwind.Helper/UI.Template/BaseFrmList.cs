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

namespace Northwind.Helper.UI.Template
{
    public class BaseFrmList : DockContent
    {
        //public BaseFrmList()
        //{
        //    this.InitializeComponent();
        //}
        protected bool _isNewData;
        protected virtual void Tambah()
        {

        }

        protected virtual void Ubah()
        {

        }

        //Fungsi Load Data
        protected virtual void LoadData()
        {

        }

        // Fungsi Clear Data
        protected virtual void ClearArea()
        {

        }

        // Fungsi Save Data
        protected virtual void SaveData()
        {

        }

        //Fungsi Delete Data
        protected virtual void DeleteData()
        {

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(481, 316);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular,
                                                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BaseFrmList";
            this.TabText = " ";
            this.Text = " ";
            this.ResumeLayout(false);
        }
    }
}
