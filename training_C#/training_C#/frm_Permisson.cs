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
    public partial class frm_Permisson : Form
    {
        public frm_Permisson()
        {
            InitializeComponent();
        }
        void Load_grv()
        {
            grv_Permission.DataSource= bus_Account.TM_Account_GetAll();
        }
        private void frm_Permisson_Load(object sender, EventArgs e)
        {
            Load_grv();
        }

        private void grv_Department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_UserID.Text= grv_Permission.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Password.Text = grv_Permission.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Permisson.Text = grv_Permission.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        bool check()
        {
            if(txt_UserID.Text=="" || txt_Password.Text=="" || txt_Permisson.Text == "")
            {
                MessageBox.Show("Cần nhập đủ thông tin","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        bool check_ID()
        {
            if (bus_Account.TM_Account_Check_ID(txt_UserID.Text).Rows.Count > 0)
            {
                MessageBox.Show("userID đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            if (check_ID())
            {
                return;
            }
            dto_Account dto_Account = new dto_Account(txt_UserID.Text, txt_Password.Text, txt_Permisson.Text);
            bus_Account.TM_Account_Insert(dto_Account);
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_grv();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            dto_Account dto_Account = new dto_Account(txt_UserID.Text, txt_Password.Text, txt_Permisson.Text);
            bus_Account.TM_Account_Update(dto_Account);
            MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_grv();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            bus_Account.TM_Account_Delete(txt_UserID.Text);
            MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_grv();

        }

        private void btn_Represt_Click(object sender, EventArgs e)
        {
            txt_UserID.Text = "";
            txt_Permisson.Text = "";
            txt_Password.Text = "";
        }
    }
}
