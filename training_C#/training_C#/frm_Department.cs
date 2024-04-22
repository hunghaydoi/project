using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_C_
{
    public partial class frm_Department : Form
    {
        public frm_Department()
        {
            InitializeComponent();
        }
        private bool check()
        {
            List<string> list= new List<string>();
            if (txt_DepartmentID.Text == "")
            {
                list.Add("Mã");
            }
            if (txt_DepartmentName.Text == "")
            {
                list.Add("Tên");
            }
            if(list.Count > 0)
            {
                string mes="Thông tin "+string.Join(",", list)+" của phòng ban không được bỏ trống";
                MessageBox.Show(mes,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool check_ID()
        {
            if(bus_Department.TM_Department_Check_ID(txt_DepartmentID.Text).Rows.Count > 0)
            {
                MessageBox.Show("Mã đã tồn tại trong cơ sở dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
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
            dto_Department dto_Department= new dto_Department(txt_DepartmentID.Text,txt_DepartmentName.Text);
            try
            {
                bus_Department.TM_Departments_Insert(dto_Department);
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                return;
            }
            dto_Department dto_Department = new dto_Department(txt_DepartmentID.Text, txt_DepartmentName.Text);
            try
            {
                bus_Department.TM_Deparment_Update(dto_Department);
                MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_DepartmentID.Text == "")
            {
                MessageBox.Show("Chưa chọn dữ liệu để xoá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                bus_Department.TM_Department_Delete(txt_DepartmentID.Text);
                MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Represt_Click(object sender, EventArgs e)
        {
            txt_DepartmentID.Text = "";
            txt_DepartmentName.Text = "";
        }
        private void load()
        {
            grv_Department.DataSource = bus_Department.getAllData();

        }
        private void frm_Department_Load(object sender, EventArgs e)
        {
            frm_Employee.PhanQuyen(btn_Add, btn_Update, btn_Delete, btn_Delete, btn_Delete);
            load();
        }

        private void grv_Department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txt_DepartmentID.Text = grv_Department.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_DepartmentName.Text = grv_Department.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
