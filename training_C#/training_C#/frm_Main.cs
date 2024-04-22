using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_C_
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag=ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Employee());
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Department());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Position());
            
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (frm_Account.permission == "admin")
            {
                phânQuyềnToolStripMenuItem.Enabled = true;
            }
            else if(frm_Account.permission == "user")
            {
                phânQuyềnToolStripMenuItem.Enabled = false;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Account frm = new frm_Account();
            frm.ShowDialog();
            this.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Permisson());
        }
    }
}
