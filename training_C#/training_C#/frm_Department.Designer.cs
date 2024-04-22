namespace training_C_
{
    partial class frm_Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Represt = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grv_Department = new System.Windows.Forms.DataGridView();
            this.col_DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DepartmentID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Department)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1602, 833);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 833);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_Represt);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.grv_Department);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_DepartmentName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_DepartmentID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 833);
            this.panel2.TabIndex = 0;
            // 
            // btn_Represt
            // 
            this.btn_Represt.Location = new System.Drawing.Point(436, 148);
            this.btn_Represt.Name = "btn_Represt";
            this.btn_Represt.Size = new System.Drawing.Size(96, 33);
            this.btn_Represt.TabIndex = 3;
            this.btn_Represt.Text = "Làm mới";
            this.btn_Represt.UseVisualStyleBackColor = true;
            this.btn_Represt.Click += new System.EventHandler(this.btn_Represt_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(312, 148);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 33);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(188, 148);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 33);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(64, 148);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 33);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grv_Department
            // 
            this.grv_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DepartmentID,
            this.col_DepartmentName});
            this.grv_Department.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grv_Department.Location = new System.Drawing.Point(0, 243);
            this.grv_Department.Name = "grv_Department";
            this.grv_Department.RowHeadersWidth = 51;
            this.grv_Department.RowTemplate.Height = 24;
            this.grv_Department.Size = new System.Drawing.Size(685, 590);
            this.grv_Department.TabIndex = 2;
            this.grv_Department.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Department_CellClick);
            // 
            // col_DepartmentID
            // 
            this.col_DepartmentID.DataPropertyName = "DepartmentID";
            this.col_DepartmentID.HeaderText = "Mã phòng ban";
            this.col_DepartmentID.MinimumWidth = 6;
            this.col_DepartmentID.Name = "col_DepartmentID";
            this.col_DepartmentID.Width = 200;
            // 
            // col_DepartmentName
            // 
            this.col_DepartmentName.DataPropertyName = "DepartmentName";
            this.col_DepartmentName.HeaderText = "Tên phòng ban";
            this.col_DepartmentName.MinimumWidth = 6;
            this.col_DepartmentName.Name = "col_DepartmentName";
            this.col_DepartmentName.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng ban";
            // 
            // txt_DepartmentName
            // 
            this.txt_DepartmentName.Location = new System.Drawing.Point(187, 94);
            this.txt_DepartmentName.Name = "txt_DepartmentName";
            this.txt_DepartmentName.Size = new System.Drawing.Size(196, 22);
            this.txt_DepartmentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng ban";
            // 
            // txt_DepartmentID
            // 
            this.txt_DepartmentID.Location = new System.Drawing.Point(187, 51);
            this.txt_DepartmentID.Name = "txt_DepartmentID";
            this.txt_DepartmentID.Size = new System.Drawing.Size(196, 22);
            this.txt_DepartmentID.TabIndex = 0;
            // 
            // frm_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 833);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Department";
            this.Text = "frm_Department";
            this.Load += new System.EventHandler(this.frm_Department_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Department)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Represt;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView grv_Department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DepartmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DepartmentName;
    }
}