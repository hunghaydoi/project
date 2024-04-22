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
    public partial class frm_Position : Form
    {
        public frm_Position()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            if (!check_ID())
            {
                return;
            }
            dto_Position dto_Position= new dto_Position(txt_PositionID.Text, txt_PositionName.Text);
            if (bus_Positions.TM_Positions_Insert(dto_Position))
            {
                MessageBox.Show("Thêm dữ liệu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                load_grv();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            dto_Position dto_Position = new dto_Position(txt_PositionID.Text, txt_PositionName.Text);
            if (bus_Positions.TM_Positions_Update(dto_Position))
            {
                MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grv();
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_PositionID.Text == "")
            {
                MessageBox.Show("Chưa chọn dữ liệu để xoá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bus_Positions.TM_Positions_Delete(txt_PositionID.Text))
            {
                MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grv();
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Represt_Click(object sender, EventArgs e)
        {
            txt_PositionID.Text = "";
            txt_PositionName.Text = "";
        }
        private bool check()
        {
            List<string> list = new List<string>();
            if(txt_PositionID.Text == "")
            {
                list.Add("mã");
            }
            if(txt_PositionName.Text == "")
            {
                list.Add("tên");
            }
            if (list.Count > 0)
            {
                string message = "Thông tin " + string.Join(", ", list) + " của chức vụ không được để trống";
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool check_ID()
        {
            if (bus_Positions.TM_Positions_Check_ID(txt_PositionID.Text).Rows.Count > 0)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void load_grv()
        {
            grv_Position.DataSource=bus_Positions.getAllData();
        }

        private void frm_Position_Load(object sender, EventArgs e)
        {
            frm_Employee.PhanQuyen(btn_Add, btn_Update, btn_Delete, btn_Delete, btn_Delete);
            load_grv();
        }

        private void grv_Position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txt_PositionID.Text = grv_Position.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_PositionName.Text= grv_Position.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
