using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.Style;
using System.Diagnostics;
namespace training_C_
{
    public partial class frm_Employee : Form
    {
        public frm_Employee()
        {
            InitializeComponent();
        }
        public bool check_Data()
        {
            List<string> emptyFields = new List<string>();

            // Kiểm tra TextBox
            if (string.IsNullOrWhiteSpace(txt_EmployeeID.Text))
            {
                emptyFields.Add("mã");
            }

            if (string.IsNullOrWhiteSpace(txt_FullName.Text))
            {
                emptyFields.Add("họ tên");
            }

            if (dtp_BirdDate.Checked ==false)
            {
                emptyFields.Add("ngày sinh");
            }

            // Kiểm tra ComboBox
            if (cbo_Gender.SelectedIndex == -1)
            {
                emptyFields.Add("giới tính");
            }
            if(cbo_Department.SelectedIndex == -1)
            {
                emptyFields.Add("phòng ban");
            }
            if (cklb_Position.CheckedItems.Count == 0)
            {
                emptyFields.Add("chức vụ");
            }
            if(string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                emptyFields.Add("địa chỉ");
            }
            if (string.IsNullOrWhiteSpace(txt_PhoneNumber.Text))
            {
                emptyFields.Add("số điện thoại");   
            }
            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                emptyFields.Add("email");
            }
            if(dtp_StartDate.Checked == false)
            {
                emptyFields.Add("ngày bắt đầu");
            }
            if (emptyFields.Count > 0)
            {
                //string message = "Vui lòng điền thông tin vào các ô sau:\n" + string.Join("\n", emptyFields);
                //MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string message = "Thông tin "+ string.Join(", ", emptyFields) + " của nhân viên không được để trống";
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool check_phone()
        {
            string input = txt_PhoneNumber.Text;
            if (input.Length == 10 && input.All(char.IsDigit) && input[0] == '0')
            {
                return true;
            }
            else
            {
                MessageBox.Show("Bạn nhập sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool check_email()
        {
            string input = txt_Email.Text;
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"; // Biểu thức chính quy kiểm tra email

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Bạn nhập sai định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (check_Data())
            {
                if (check_employeeID())
                {
                    return;
                }
                if (!check_phone())
                {
                    return;
                }
                if (!check_email())
                {
                    return;
                }
                string position;
                List<string> itemsChecked = new List<string>();
                foreach (object itemChecked in cklb_Position.CheckedItems)
                {
                    itemsChecked.Add(itemChecked.ToString());
                }
                position = string.Join(", ", itemsChecked);
                if(dtp_EndDate.Checked == false)
                {
                    dto_employee dto_Employee = new dto_employee(txt_EmployeeID.Text, txt_FullName.Text, dtp_BirdDate.Value, cbo_Gender.Text, txt_Address.Text, txt_PhoneNumber.Text, txt_Email.Text, cbo_Department.Text, position, dtp_StartDate.Value, DBNull.Value);
                    if (bus_employee.TM_Employees_Insert(dto_Employee))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dto_employee dto_Employee = new dto_employee(txt_EmployeeID.Text, txt_FullName.Text, dtp_BirdDate.Value, cbo_Gender.Text, txt_Address.Text, txt_PhoneNumber.Text, txt_Email.Text, cbo_Department.Text, position, dtp_StartDate.Value, dtp_EndDate.Value);
                    if (bus_employee.TM_Employees_Insert(dto_Employee))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void load()
        {
            grv_Employee.DataSource = bus_employee.getAllData();
        }
        public void load_cbo_Department()
        {
            cbo_Department.DataSource = bus_Department.getAllData();
            cbo_Department.ValueMember = "DepartmentID";
            cbo_Department.DisplayMember = "DepartmentName";
        }
        public void load_cklb_Position()
        {
            DataTable dt= bus_Positions.getAllData();
            foreach (DataRow row in dt.Rows)
            {
                // Lấy giá trị từ cột thứ 2 (index 1) của mỗi dòng và thêm vào CheckedListBox
                cklb_Position.Items.Add(row[1]);
            }
        }
        public static void PhanQuyen(System.Windows.Forms.Button add, System.Windows.Forms.Button fix, System.Windows.Forms.Button delete, System.Windows.Forms.Button choosefile , System.Windows.Forms.Button AddFile)
        {
            if (frm_Account.permission == "admin")
            {
                add.Enabled = true; // Cho phép sử dụng nút "add"
                fix.Enabled = true; // Cho phép sử dụng nút "fix"
                delete.Enabled = true; // Cho phép sử dụng nút "delete"
                choosefile.Enabled = true;
                AddFile.Enabled = true;
            }
            else
            {
                add.Enabled = false; // Không cho phép sử dụng nút "add"
                fix.Enabled = false; // Không cho phép sử dụng nút "fix"
                delete.Enabled = false; // Không cho phép sử dụng nút "delete"
                choosefile.Enabled = false;
                AddFile.Enabled = false;
            }
        }

        private void frm_Employee_Load(object sender, EventArgs e)
        {
            PhanQuyen(btn_Add,btn_Update,btn_Delete,btn_FileChoose,btn_Add_Excel);
            load();
            load_cbo_Department();
            load_cklb_Position();
        }

        private void grv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txt_EmployeeID.Text = grv_Employee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_FullName.Text = grv_Employee.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbo_Gender.Text = grv_Employee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_PhoneNumber.Text= grv_Employee.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_Address.Text = grv_Employee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Email.Text = grv_Employee.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbo_Department.Text = grv_Employee.Rows[e.RowIndex].Cells[7].Value.ToString();
                string data = grv_Employee.Rows[e.RowIndex].Cells[8].Value.ToString();
                string[] values = data.Split(',');

                // Đặt tất cả các mục trong CheckedListBox thành false
                for (int i = 0; i < cklb_Position.Items.Count; i++)
                {
                    cklb_Position.SetItemChecked(i, false);
                }
                // Thiết lập các mục được chọn dựa trên dữ liệu từ ô grv_Employee
                foreach (string value in values)
                {
                    string trimmedValue = value.Trim(); // Loại bỏ khoảng trắng thừa
                    int index = cklb_Position.Items.IndexOf(trimmedValue);
                    if (index != -1)
                    {
                        cklb_Position.SetItemChecked(index, true);
                    }
                }

                object cellValue = grv_Employee.Rows[e.RowIndex].Cells[2].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    dtp_BirdDate.Checked = true;
                    DateTime dateTimeValue;
                    if (DateTime.TryParse(cellValue.ToString(), out dateTimeValue))
                    {
                        dtp_BirdDate.Value = dateTimeValue;
                    }
                }
                else
                {
                    dtp_BirdDate.Checked= false;
                }
                object cellValue1 = grv_Employee.Rows[e.RowIndex].Cells[9].Value;
                if (cellValue1 != null && cellValue1 != DBNull.Value)
                {
                    dtp_StartDate.Checked = true;
                    DateTime dateTimeValue;
                    if (DateTime.TryParse(cellValue1.ToString(), out dateTimeValue))
                    {
                        dtp_StartDate.Value = dateTimeValue;
                    }
                }
                else
                {
                    dtp_StartDate.Checked = false;
                }
                object cellValue2 = grv_Employee.Rows[e.RowIndex].Cells[10].Value;
                if (cellValue2 != null && cellValue2 != DBNull.Value)
                {
                    dtp_EndDate.Checked = true;
                    DateTime dateTimeValue;
                    if (DateTime.TryParse(cellValue2.ToString(), out dateTimeValue))
                    {
                        dtp_EndDate.Value = dateTimeValue;
                    }
                }
                else
                {
                    dtp_EndDate.Checked = false;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (check_Data())
            {
                if (!check_phone())
                {
                    return;
                }
                if (!check_email())
                {
                    return;
                }
                string position;
                List<string> itemsChecked = new List<string>();
                foreach (object itemChecked in cklb_Position.CheckedItems)
                {
                    itemsChecked.Add(itemChecked.ToString());
                }
                position = string.Join(", ", itemsChecked);
                if (dtp_EndDate.Checked == false)
                {
                    dto_employee dto_Employee = new dto_employee(txt_EmployeeID.Text, txt_FullName.Text, dtp_BirdDate.Value, cbo_Gender.Text, txt_Address.Text, txt_PhoneNumber.Text, txt_Email.Text, cbo_Department.Text, position, dtp_StartDate.Value, DBNull.Value);
                    if (bus_employee.TM_Employees_Update(dto_Employee))
                    {
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dto_employee dto_Employee = new dto_employee(txt_EmployeeID.Text, txt_FullName.Text, dtp_BirdDate.Value, cbo_Gender.Text, txt_Address.Text, txt_PhoneNumber.Text, txt_Email.Text, cbo_Department.Text, position, dtp_StartDate.Value, dtp_EndDate.Value);
                    if (bus_employee.TM_Employees_Insert(dto_Employee))
                    {
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_EmployeeID.Text == "")
            {
                MessageBox.Show("Chưa chọn dữ liệu để xoá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bus_employee.TM_Employees_Delete(txt_EmployeeID.Text))
            {
                MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool check_employeeID()
        {
            if (bus_employee.TM_Employees_Check_Employee(txt_EmployeeID.Text).Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_EmployeeID.Focus();
                return true;
            }
            return false;
        }
        private void txt_EmployeeID_Leave(object sender, EventArgs e)
        {
            //if(check_employeeID())
            //{
            //    return;
            //}
        }

        private void txt_EmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_FullName.Focus();
            }
        }

        private void btn_FileChoose_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    txt_link.Text = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Đường dẫn trống.");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Đã hủy chọn tệp.");
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("Quá trình chọn tệp bị hủy.");
            }
            else if (result == DialogResult.Ignore)
            {
                MessageBox.Show("Đã bỏ qua chọn tệp.");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Không có tệp nào được chọn.");
            }
            else if (result == DialogResult.None)
            {
                MessageBox.Show("Không có hành động nào được thực hiện.");
            }
            else
            {
                MessageBox.Show("Lỗi không xác định.");
            }
        }
        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false; // Tệp không bị khóa, tức là không đang mở
                }
            }
            catch (IOException)
            {
                return true; // Tệp đang bị khóa, tức là đang mở
            }
        }
        private bool check_excel()
        {
            if (IsFileLocked(txt_link.Text))
            {
                MessageBox.Show("Tập tin Excel đang mở. Vui lòng đóng tập tin trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            bool hasError = false;
            bool Error= false;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(txt_link.Text)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int rowCount = worksheet.Dimension.Rows;

                if (rowCount < 1)
                {
                    MessageBox.Show("Không có dữ liệu trong tập tin Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col < 11; col++) // Duyệt qua tất cả các cột từ 1 đến 11
                        {
                            if (string.IsNullOrWhiteSpace(worksheet.Cells[row, col].Value?.ToString()))
                            {
                                worksheet.Cells[row, col].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[row, col].Style.Fill.BackgroundColor.SetColor(Color.Red);
                                hasError = true; // Đặt cờ lỗi
                            }
                        }
                    }
                }
                if (hasError)
                {
                    MessageBox.Show("Xuất hiện dữ liệu trống trong file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    package.Save();
                    Process.Start(txt_link.Text);
                    return false;
                }
                else
                {
                    for (int row = 1; row <= rowCount; row++)
                    {
                        if (bus_employee.TM_Employees_Check_Employee(worksheet.Cells[row, 1].Value?.ToString()).Rows.Count > 0)
                        {
                            worksheet.Cells[row, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[row, 1].Style.Fill.BackgroundColor.SetColor(Color.Violet);
                            Error = true; // Đặt cờ lỗi
                        }
                    }
                }
                if (Error)
                {
                    MessageBox.Show("Xuất hiện mã nhân viên đã tồn tại trong CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    package.Save();
                    Process.Start(txt_link.Text);
                    return false;

                }
            }
            return true;
        }
        private void btn_Add_Excel_Click(object sender, EventArgs e)
        {
            if(txt_link.Text== "")
            {
                MessageBox.Show("Chưa chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!check_excel())
            {
                return;
            }
            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(txt_link.Text)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // Assuming data is in the first worksheet

                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;



                    for (int row = 1; row <= rowCount; row++)
                    {

                        // Chèn dữ liệu vào cơ sở dữ liệu
                        dto_employee dto_Employee = new dto_employee(worksheet.Cells[row, 1].Value.ToString(), worksheet.Cells[row, 2].Value.ToString(), worksheet.Cells[row, 3].Value, worksheet.Cells[row, 4].Value.ToString(), worksheet.Cells[row, 5].Value.ToString(), worksheet.Cells[row, 6].Value.ToString(), worksheet.Cells[row, 7].Value.ToString(), worksheet.Cells[row, 8].Value.ToString(), worksheet.Cells[row, 9].Value.ToString(), worksheet.Cells[row, 10].Value, worksheet.Cells[row, 11].Value ?? DBNull.Value);
                        bus_employee.TM_Employees_Insert(dto_Employee);
                    }
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Represt_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.Text = "";
            txt_FullName.Text = "";
            dtp_BirdDate.Checked = false;
            cbo_Gender.SelectedIndex = -1;
            cbo_Department.SelectedIndex = -1;
            for (int i = 0; i < cklb_Position.Items.Count; i++)
            {
                cklb_Position.SetItemChecked(i, false);
            }
            txt_Address.Text = "";
            txt_PhoneNumber.Text = "";
            txt_Email.Text = "";
            dtp_StartDate.Checked = false;
            dtp_EndDate.Checked=false;
            txt_link.Text = "";
            txt_Search.Text = "";
            cbo_Search.SelectedIndex = -1;
        }
        private bool check_txt_search()
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Nhập dữ liệu cần tìm kiếm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return true;
            }
            if(cbo_Search.SelectedIndex== -1)
            {
                MessageBox.Show("Chọn tìm kiếm theo danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void search_employee()
        {
            bus_employee.TM_Employees_Search_Employee(txt_Search.Text);
            grv_Employee.DataSource = bus_employee.TM_Employees_Search_Employee(txt_Search.Text);
        }
        private void search_fullname()
        {
            bus_employee.TM_Employees_Search_FullName(txt_Search.Text);
            grv_Employee.DataSource = bus_employee.TM_Employees_Search_FullName(txt_Search.Text);
        }
        private void search_gender()
        {
            bus_employee.TM_Employees_Search_Gender(txt_Search.Text);
            grv_Employee.DataSource=bus_employee.TM_Employees_Search_Gender(txt_Search.Text);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(check_txt_search())
            {
                return;
            }
            if(cbo_Search.Text=="Mã nhân viên")
            {
                search_employee();
            }
            if(cbo_Search.Text=="Họ tên")
            {
                search_fullname();
            }
            if(cbo_Search.Text=="Giới tính")
            {
                search_gender();
            }
            MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
