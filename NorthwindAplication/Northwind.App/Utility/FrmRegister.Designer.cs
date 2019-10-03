namespace Northwind.App.Utility
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdLstUser = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLstUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 312);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboGroup);
            this.panel3.Controls.Add(this.txtFirst);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtLast);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUserID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 306);
            this.panel3.TabIndex = 0;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(101, 131);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(209, 24);
            this.cboGroup.TabIndex = 36;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(101, 67);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(209, 22);
            this.txtFirst.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Group";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(101, 98);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(209, 22);
            this.txtLast.TabIndex = 32;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(101, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 22);
            this.txtPassword.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Last Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(101, 11);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(209, 22);
            this.txtUserID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "User Id";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdLstUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(403, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 306);
            this.panel4.TabIndex = 1;
            // 
            // grdLstUser
            // 
            this.grdLstUser.BackColor = System.Drawing.SystemColors.Control;
            this.grdLstUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdLstUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLstUser.ItemHeight = 17;
            this.grdLstUser.Location = new System.Drawing.Point(0, 0);
            this.grdLstUser.Name = "grdLstUser";
            this.grdLstUser.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdLstUser.SelectedIndex = -1;
            this.grdLstUser.Size = new System.Drawing.Size(394, 306);
            this.grdLstUser.TabIndex = 0;
            this.grdLstUser.TopIndex = 0;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FrmRegister";
            this.TabText = "FrmRegister";
            this.Text = "FrmRegister";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLstUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Grid.GridListControl grdLstUser;
    }
}