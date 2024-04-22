using BUS;
using DTO;
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
    public partial class frm_Account : Form
    {
        public static string permission;
        public frm_Account()
        {
            InitializeComponent();
        }
        bool check()
        {
            if(txt_username.Text =="" || txt_pass.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
                return true;
            }
            return false;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(check())
            {
                return;
            }
            dto_Account dto_Account=new dto_Account(txt_username.Text, txt_pass.Text,txt_pass.Text);
            if (bus_Account.Login(dto_Account).Rows.Count > 0)
            {
                permission = bus_Account.Login(dto_Account).Rows[0]["permission"].ToString();
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Main frm= new frm_Main();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
