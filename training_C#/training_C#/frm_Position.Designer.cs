namespace training_C_
{
    partial class frm_Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Position));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Represt = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grv_Position = new System.Windows.Forms.DataGridView();
            this.col_PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PositionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PositionID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Position)).BeginInit();
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
            this.panel2.Controls.Add(this.grv_Position);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_PositionName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_PositionID);
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
            // grv_Position
            // 
            this.grv_Position.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Position.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_PositionID,
            this.col_PositionName});
            this.grv_Position.Location = new System.Drawing.Point(0, 243);
            this.grv_Position.Name = "grv_Position";
            this.grv_Position.RowHeadersWidth = 51;
            this.grv_Position.RowTemplate.Height = 24;
            this.grv_Position.Size = new System.Drawing.Size(679, 590);
            this.grv_Position.TabIndex = 2;
            this.grv_Position.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Position_CellClick);
            // 
            // col_PositionID
            // 
            this.col_PositionID.DataPropertyName = "PositionID";
            this.col_PositionID.HeaderText = "Mã chức vụ";
            this.col_PositionID.MinimumWidth = 6;
            this.col_PositionID.Name = "col_PositionID";
            this.col_PositionID.Width = 200;
            // 
            // col_PositionName
            // 
            this.col_PositionName.DataPropertyName = "PositionName";
            this.col_PositionName.HeaderText = "Tên chức vụ";
            this.col_PositionName.MinimumWidth = 6;
            this.col_PositionName.Name = "col_PositionName";
            this.col_PositionName.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // txt_PositionName
            // 
            this.txt_PositionName.Location = new System.Drawing.Point(187, 94);
            this.txt_PositionName.Name = "txt_PositionName";
            this.txt_PositionName.Size = new System.Drawing.Size(196, 22);
            this.txt_PositionName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chức vụ";
            // 
            // txt_PositionID
            // 
            this.txt_PositionID.Location = new System.Drawing.Point(187, 51);
            this.txt_PositionID.Name = "txt_PositionID";
            this.txt_PositionID.Size = new System.Drawing.Size(196, 22);
            this.txt_PositionID.TabIndex = 0;
            // 
            // frm_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 833);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Position";
            this.Text = "frm_Position";
            this.Load += new System.EventHandler(this.frm_Position_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Position)).EndInit();
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
        private System.Windows.Forms.DataGridView grv_Position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PositionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PositionName;
    }
}