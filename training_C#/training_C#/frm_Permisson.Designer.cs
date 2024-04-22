namespace training_C_
{
    partial class frm_Permisson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Permisson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Represt = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grv_Permission = new System.Windows.Forms.DataGridView();
            this.col_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Permisson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.hihi = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Permission)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.panel2.Controls.Add(this.grv_Permission);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Permisson);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.hihi);
            this.panel2.Controls.Add(this.txt_UserID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 833);
            this.panel2.TabIndex = 0;
            // 
            // btn_Represt
            // 
            this.btn_Represt.Location = new System.Drawing.Point(436, 177);
            this.btn_Represt.Name = "btn_Represt";
            this.btn_Represt.Size = new System.Drawing.Size(96, 33);
            this.btn_Represt.TabIndex = 3;
            this.btn_Represt.Text = "Làm mới";
            this.btn_Represt.UseVisualStyleBackColor = true;
            this.btn_Represt.Click += new System.EventHandler(this.btn_Represt_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(312, 177);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 33);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(188, 177);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 33);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(64, 177);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 33);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grv_Permission
            // 
            this.grv_Permission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Permission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_UserID,
            this.col_Password,
            this.Column1});
            this.grv_Permission.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grv_Permission.Location = new System.Drawing.Point(0, 243);
            this.grv_Permission.Name = "grv_Permission";
            this.grv_Permission.RowHeadersWidth = 51;
            this.grv_Permission.RowTemplate.Height = 24;
            this.grv_Permission.Size = new System.Drawing.Size(685, 590);
            this.grv_Permission.TabIndex = 2;
            this.grv_Permission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Department_CellClick);
            // 
            // col_UserID
            // 
            this.col_UserID.DataPropertyName = "employeeID";
            this.col_UserID.HeaderText = "UserID";
            this.col_UserID.MinimumWidth = 6;
            this.col_UserID.Name = "col_UserID";
            this.col_UserID.Width = 200;
            // 
            // col_Password
            // 
            this.col_Password.DataPropertyName = "password";
            this.col_Password.HeaderText = "Password";
            this.col_Password.MinimumWidth = 6;
            this.col_Password.Name = "col_Password";
            this.col_Password.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "permission";
            this.Column1.HeaderText = "Quyền";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân quyền";
            // 
            // txt_Permisson
            // 
            this.txt_Permisson.Location = new System.Drawing.Point(187, 137);
            this.txt_Permisson.Name = "txt_Permisson";
            this.txt_Permisson.Size = new System.Drawing.Size(196, 22);
            this.txt_Permisson.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(187, 94);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(196, 22);
            this.txt_Password.TabIndex = 0;
            // 
            // hihi
            // 
            this.hihi.AutoSize = true;
            this.hihi.Location = new System.Drawing.Point(61, 54);
            this.hihi.Name = "hihi";
            this.hihi.Size = new System.Drawing.Size(49, 16);
            this.hihi.TabIndex = 1;
            this.hihi.Text = "UserID";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(187, 51);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(196, 22);
            this.txt_UserID.TabIndex = 0;
            // 
            // frm_Permisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 833);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Permisson";
            this.Text = "frm_permisson";
            this.Load += new System.EventHandler(this.frm_Permisson_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Permission)).EndInit();
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
        private System.Windows.Forms.DataGridView grv_Permission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label hihi;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Permisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}