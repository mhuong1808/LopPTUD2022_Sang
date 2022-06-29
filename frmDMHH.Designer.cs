
namespace LopPTUD2022_Sang
{
    partial class frmDMHH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtDgvnd = new System.Windows.Forms.TextBox();
            this.txtSanXuat = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxuatbaocao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan ly danh muc hang hoa";
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.dvt,
            this.Dgvnd,
            this.SanXuat});
            this.grdData.Location = new System.Drawing.Point(12, 61);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(553, 308);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaNhom.HeaderText = "Nhóm hàng";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 87;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHH.HeaderText = "Mã HH ";
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 69;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHH.HeaderText = "Tên HH ";
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 73;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            this.dvt.Width = 85;
            // 
            // Dgvnd
            // 
            this.Dgvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dgvnd.DataPropertyName = "Dgvnd";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Dgvnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgvnd.HeaderText = "Đơn giá VND";
            this.Dgvnd.Name = "Dgvnd";
            this.Dgvnd.Width = 95;
            // 
            // SanXuat
            // 
            this.SanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SanXuat.DataPropertyName = "SanXuat";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanXuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.SanXuat.HeaderText = "Nước sản xuất";
            this.SanXuat.Name = "SanXuat";
            this.SanXuat.Width = 101;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(593, 147);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(53, 13);
            this.a.TabIndex = 9;
            this.a.Text = "Mã Nhóm";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(593, 188);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(51, 13);
            this.b.TabIndex = 10;
            this.b.Text = "Mã Hàng";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(593, 229);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(55, 13);
            this.c.TabIndex = 11;
            this.c.Text = "Tên Hàng";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(593, 270);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(60, 13);
            this.d.TabIndex = 12;
            this.d.Text = "Đơn vị tính";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(593, 311);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(70, 13);
            this.e.TabIndex = 13;
            this.e.Text = "Đơn giá VND";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Location = new System.Drawing.Point(682, 142);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(215, 23);
            this.txtMaNhom.TabIndex = 2;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.Location = new System.Drawing.Point(682, 183);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(215, 23);
            this.txtMaHH.TabIndex = 4;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.Location = new System.Drawing.Point(682, 224);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(215, 23);
            this.txtTenHH.TabIndex = 5;
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(682, 265);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(215, 23);
            this.txtdvt.TabIndex = 6;
            // 
            // txtDgvnd
            // 
            this.txtDgvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgvnd.Location = new System.Drawing.Point(682, 306);
            this.txtDgvnd.Name = "txtDgvnd";
            this.txtDgvnd.Size = new System.Drawing.Size(215, 23);
            this.txtDgvnd.TabIndex = 7;
            // 
            // txtSanXuat
            // 
            this.txtSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanXuat.Location = new System.Drawing.Point(682, 347);
            this.txtSanXuat.Name = "txtSanXuat";
            this.txtSanXuat.Size = new System.Drawing.Size(215, 23);
            this.txtSanXuat.TabIndex = 14;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(593, 352);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(76, 13);
            this.f.TabIndex = 15;
            this.f.Text = "Nước sản xuất";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(18, 398);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(52, 28);
            this.btnfirst.TabIndex = 16;
            this.btnfirst.Text = "Dau";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(90, 398);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(52, 28);
            this.btnpre.TabIndex = 17;
            this.btnpre.Text = "Truoc";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(162, 398);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(52, 28);
            this.btnnext.TabIndex = 18;
            this.btnnext.Text = "Sau";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(234, 398);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(52, 28);
            this.btnlast.TabIndex = 19;
            this.btnlast.Text = "Cuoi";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxuatbaocao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnloc);
            this.groupBox1.Controls.Add(this.comGT);
            this.groupBox1.Controls.Add(this.comTenTruong);
            this.groupBox1.Location = new System.Drawing.Point(583, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 104);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btnxuatbaocao
            // 
            this.btnxuatbaocao.Location = new System.Drawing.Point(133, 69);
            this.btnxuatbaocao.Name = "btnxuatbaocao";
            this.btnxuatbaocao.Size = new System.Drawing.Size(91, 27);
            this.btnxuatbaocao.TabIndex = 7;
            this.btnxuatbaocao.Text = "Xuất báo cáo";
            this.btnxuatbaocao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá trị lọc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc theo";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(230, 69);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(84, 26);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Hủy lọc ";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(13, 68);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(73, 27);
            this.btnloc.TabIndex = 2;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // comGT
            // 
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(118, 44);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(207, 21);
            this.comGT.TabIndex = 1;
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "MaNhom",
            "TenHH",
            "SanXuat"});
            this.comTenTruong.Location = new System.Drawing.Point(6, 44);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(87, 21);
            this.comTenTruong.TabIndex = 0;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(860, 398);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 28);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Ket thuc";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(765, 398);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 28);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Cap nhat ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(670, 398);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 28);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Xoa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfix
            // 
            this.btnfix.Location = new System.Drawing.Point(575, 398);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(75, 28);
            this.btnfix.TabIndex = 24;
            this.btnfix.Text = "Sua ";
            this.btnfix.UseVisualStyleBackColor = true;
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(480, 398);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(75, 28);
            this.btnaddnew.TabIndex = 25;
            this.btnaddnew.Text = "Them moi ";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // frmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.btnfix);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.f);
            this.Controls.Add(this.txtSanXuat);
            this.Controls.Add(this.e);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtDgvnd);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmDMHH";
            this.Load += new System.EventHandler(this.frmDMHH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMHH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtDgvnd;
        private System.Windows.Forms.TextBox txtSanXuat;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanXuat;
        private System.Windows.Forms.Button btnxuatbaocao;
    }
}