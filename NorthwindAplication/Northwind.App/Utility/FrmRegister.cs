using Northwind.BLL_api;
using Northwind.BLL_service;
using Northwind.Helper;
using Northwind.Helper.UI.Template;
using Northwind.Model;
using Syncfusion.Windows.Forms.Grid;
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
        private IAuthBLL _authBLL;
        private IRoleBLL _roleBLL;

        private IList<User> _lstUser = new List<User>();
        private IList<Roles> _lstRole = new List<Roles>();
        //private List<Roles> _lstRole2;

        public FrmRegister()
        {
            InitializeComponent();
        }

        public FrmRegister(string header) : base(header)
        {
            InitializeComponent();
            _authBLL = new AuthBLL();
            _roleBLL = new RoleBLL();
            LoadData();
            InitGrid();
            LockButton(true, false);
            LockField(false, false);
            LoadRole();
        }

        private void LoadRole()
        {
            cboGroup.DataSource = _lstRole;
            cboGroup.DisplayMember = "Name";
            cboGroup.ValueMember = "Id";

            cboGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LockField(bool v, bool w)
        {
            txtUserID.Enabled = w;
            txtPassword.Enabled = w;
            txtFirst.Enabled = v;
            txtLast.Enabled = v;
            cboGroup.Enabled = v;
        }

        private void InitGrid()
        {
            var glProp = new List<GridListControlProperties>();

            glProp.Add(new GridListControlProperties { Header = "No", Width = 30 });
            glProp.Add(new GridListControlProperties { Header = "User Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "First Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "Last Name", Width = 300 });
            glProp.Add(new GridListControlProperties { Header = "Roles", Width = 200 });


            GridListControlHelper.InitializeGridListControl<User>(grdLstUser, _lstUser, glProp);

            if (_lstUser.Count > 0)
                this.grdLstUser.SetSelected(0, true);

            grdLstUser.Grid.QueryCellInfo += delegate (object sender, GridQueryCellInfoEventArgs e)
            {
                if (_lstUser.Count > 0)
                {
                    if (e.RowIndex > 0)
                    {
                        var rowIndex = e.RowIndex - 1;
                        if (rowIndex < _lstUser.Count)
                        {
                            var users = _lstUser[rowIndex];
                            switch (e.ColIndex)
                            {
                                case 2:
                                    e.Style.CellValue = users.userId;
                                    break;
                                case 3:
                                    e.Style.CellValue = users.firstName;
                                    break;
                                case 4:
                                    e.Style.CellValue = users.lastName;
                                    break;
                                case 5:
                                    e.Style.CellValue = users.roles;
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            };


        }

        protected override void LoadData()
        {
            _lstUser = _authBLL.GetAll().ToList();
            _lstRole = _roleBLL.GetAll().ToList();
        }

        protected override void btnAddAksi()
        {
            ClearArea();
            LockButton(false, true);
            LockField(true, true);
        }

        protected override void SaveData()
        {
            var userReg = new UserForRegister
            {
                FirstName = txtFirst.Text,
                LastName = txtLast.Text,
                Password = txtPassword.Text,
                UserId = txtUserID.Text,
                Roles = Convert.ToInt32(cboGroup.SelectedValue.ToString())
            };

            var result = _authBLL.Register(userReg);

            if(result == 1)
            {
                LoadData();
                InitGrid();
                LockButton(true, false);
                LockField(false, false);
                LoadRole();
                MessageBox.Show("User Has Been Created");
            }else if(result == 2)
            {
                MessageBox.Show("User Already Exists");
            }
            else
            {
                MessageBox.Show("User Has Been Failed");
            }
                
            
        }

        protected override void BtnEditAksi()
        {
            ClearArea();
            LockButton(false, true);
            LockField(true, false);
            GetDataFromList();
            
        }

        protected override void ClearArea()
        {
            txtUserID.Text = "";
            txtFirst.Text = "";
            txtLast.Text = "";
            txtUserID.Text = "";
            cboGroup.SelectedValue = "";
        }

        private void GetDataFromList()
        {
            var index = grdLstUser.SelectedIndex;
            var user = _lstUser[index];

            txtUserID.Text = user.userId;
            txtFirst.Text = user.firstName;
            txtLast.Text = user.lastName;
            cboGroup.SelectedValue = user.roles;
        }
    }
}
