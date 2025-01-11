namespace QuanLyDuAn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find_da = new System.Windows.Forms.TextBox();
            this.cb_find_da = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_nv_id = new System.Windows.Forms.ComboBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_da_load = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.erp_loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.colMaDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKinhPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVienPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_da_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_find_da);
            this.groupBox1.Controls.Add(this.cb_find_da);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim Kiem";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(7, 193);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(237, 41);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(8, 146);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(237, 41);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(7, 99);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(237, 41);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "Tim Kiem";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find_da
            // 
            this.txt_find_da.Location = new System.Drawing.Point(10, 61);
            this.txt_find_da.Name = "txt_find_da";
            this.txt_find_da.Size = new System.Drawing.Size(235, 24);
            this.txt_find_da.TabIndex = 1;
            // 
            // cb_find_da
            // 
            this.cb_find_da.AutoSize = true;
            this.cb_find_da.Location = new System.Drawing.Point(6, 23);
            this.cb_find_da.Name = "cb_find_da";
            this.cb_find_da.Size = new System.Drawing.Size(93, 22);
            this.cb_find_da.TabIndex = 0;
            this.cb_find_da.Text = "Tim Kiem";
            this.cb_find_da.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbb_nv_id);
            this.groupBox2.Controls.Add(this.txt_cost);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong Tin Du An";
            // 
            // cbb_nv_id
            // 
            this.cbb_nv_id.DisplayMember = "HoTen";
            this.cbb_nv_id.FormattingEnabled = true;
            this.cbb_nv_id.Location = new System.Drawing.Point(196, 172);
            this.cbb_nv_id.Name = "cbb_nv_id";
            this.cbb_nv_id.Size = new System.Drawing.Size(229, 26);
            this.cbb_nv_id.TabIndex = 8;
            this.cbb_nv_id.ValueMember = "MaNhanVienPhuTrach";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(191, 104);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(235, 24);
            this.txt_cost.TabIndex = 7;
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(191, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(235, 24);
            this.txt_name.TabIndex = 6;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(191, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(235, 24);
            this.txt_id.TabIndex = 5;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaNhanVienPhuTrach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TongKinhPhi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenDuAn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaDuAn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(314, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc Nang";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(278, 18);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 63);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(142, 18);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 63);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 63);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Them";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_da_load);
            this.groupBox4.Location = new System.Drawing.Point(314, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 385);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Du Lieu";
            // 
            // dgv_da_load
            // 
            this.dgv_da_load.AllowUserToAddRows = false;
            this.dgv_da_load.AllowUserToDeleteRows = false;
            this.dgv_da_load.AllowUserToResizeColumns = false;
            this.dgv_da_load.AllowUserToResizeRows = false;
            this.dgv_da_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_da_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDuAn,
            this.colTenDuAn,
            this.colTongKinhPhi,
            this.colMaNhanVienPhuTrach});
            this.dgv_da_load.Location = new System.Drawing.Point(8, 20);
            this.dgv_da_load.Name = "dgv_da_load";
            this.dgv_da_load.ReadOnly = true;
            this.dgv_da_load.RowHeadersWidth = 51;
            this.dgv_da_load.RowTemplate.Height = 24;
            this.dgv_da_load.Size = new System.Drawing.Size(812, 354);
            this.dgv_da_load.TabIndex = 0;
            this.dgv_da_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_da_load_RowEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "MaNhanVienPhuTrach";
            // 
            // erp_loi
            // 
            this.erp_loi.ContainerControl = this;
            // 
            // colMaDuAn
            // 
            this.colMaDuAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMaDuAn.DataPropertyName = "MaDuAn";
            this.colMaDuAn.HeaderText = "MaDuAn";
            this.colMaDuAn.MinimumWidth = 6;
            this.colMaDuAn.Name = "colMaDuAn";
            this.colMaDuAn.ReadOnly = true;
            this.colMaDuAn.Width = 94;
            // 
            // colTenDuAn
            // 
            this.colTenDuAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDuAn.DataPropertyName = "TenDuAn";
            this.colTenDuAn.HeaderText = "TenDuAn";
            this.colTenDuAn.MinimumWidth = 6;
            this.colTenDuAn.Name = "colTenDuAn";
            this.colTenDuAn.ReadOnly = true;
            // 
            // colTongKinhPhi
            // 
            this.colTongKinhPhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTongKinhPhi.DataPropertyName = "TongKinhPhi";
            this.colTongKinhPhi.HeaderText = "TongKinhPhi";
            this.colTongKinhPhi.MinimumWidth = 6;
            this.colTongKinhPhi.Name = "colTongKinhPhi";
            this.colTongKinhPhi.ReadOnly = true;
            this.colTongKinhPhi.Width = 121;
            // 
            // colMaNhanVienPhuTrach
            // 
            this.colMaNhanVienPhuTrach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNhanVienPhuTrach.DataPropertyName = "MaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.HeaderText = "MaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.MinimumWidth = 6;
            this.colMaNhanVienPhuTrach.Name = "colMaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 745);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_da_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find_da;
        private System.Windows.Forms.CheckBox cb_find_da;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_nv_id;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_da_load;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider erp_loi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKinhPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVienPhuTrach;
    }
}

