﻿namespace BTL_nhom4_LaptrinhWindows.UCs
{
    partial class ucDanhSachLop
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

        #region Component Designer generated code

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtHoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThemVaoLop = new DevComponents.DotNetBar.ButtonX();
            this.dtgvDanhsachsinhvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboThoiGian = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnXoaKhoiLop = new DevComponents.DotNetBar.ButtonX();
            this.dtgvDanhsachsvcualop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachsinhvien)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachsvcualop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel4);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 509);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 16;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.txtHoten);
            this.groupPanel3.Controls.Add(this.txtSdt);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel3.DrawTitleBox = false;
            this.groupPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.IsShadowEnabled = true;
            this.groupPanel3.Location = new System.Drawing.Point(0, 0);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(439, 52);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel3.Style.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 6;
            this.groupPanel3.Text = "Tìm kiếm";
            this.groupPanel3.Click += new System.EventHandler(this.groupPanel3_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtHoten.Border.Class = "TextBoxBorder";
            this.txtHoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoten.Location = new System.Drawing.Point(80, 1);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(123, 24);
            this.txtHoten.TabIndex = 14;
            this.txtHoten.TextChanged += new System.EventHandler(this.textBoxX4_TextChanged);
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtSdt.Border.Class = "TextBoxBorder";
            this.txtSdt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSdt.Location = new System.Drawing.Point(276, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(131, 24);
            this.txtSdt.TabIndex = 3;
            this.txtSdt.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(230, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Sđt:";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 1);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Họ tên:";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnThemVaoLop);
            this.groupPanel2.Controls.Add(this.dtgvDanhsachsinhvien);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel2.DrawTitleBox = false;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(0, 66);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(439, 443);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.AliceBlue;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "Danh sách sinh viên chung";
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // btnThemVaoLop
            // 
            this.btnThemVaoLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemVaoLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemVaoLop.BackColor = System.Drawing.Color.White;
            this.btnThemVaoLop.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThemVaoLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoLop.Location = new System.Drawing.Point(147, 356);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(143, 35);
            this.btnThemVaoLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnThemVaoLop.TabIndex = 11;
            this.btnThemVaoLop.Text = "Thêm vào lớp";
            this.btnThemVaoLop.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dtgvDanhsachsinhvien
            // 
            this.dtgvDanhsachsinhvien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhsachsinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhsachsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhsachsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sodienthoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhsachsinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhsachsinhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvDanhsachsinhvien.EnableHeadersVisualStyles = false;
            this.dtgvDanhsachsinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvDanhsachsinhvien.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhsachsinhvien.Name = "dtgvDanhsachsinhvien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhsachsinhvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhsachsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhsachsinhvien.Size = new System.Drawing.Size(433, 340);
            this.dtgvDanhsachsinhvien.TabIndex = 0;
            this.dtgvDanhsachsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 47;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Visible = false;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Visible = false;
            // 
            // sodienthoai
            // 
            this.sodienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cboThoiGian);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.cboLop);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cboKhoa);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.DrawTitleBox = false;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(603, 52);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel1.Style.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "Tìm kiếm";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboThoiGian.DisplayMember = "Text";
            this.cboThoiGian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThoiGian.FormattingEnabled = true;
            this.cboThoiGian.ItemHeight = 18;
            this.cboThoiGian.Location = new System.Drawing.Point(286, 0);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(124, 24);
            this.cboThoiGian.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThoiGian.TabIndex = 12;
            this.cboThoiGian.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx2_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(215, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(103, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Thời gian:";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // cboLop
            // 
            this.cboLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 18;
            this.cboLop.Location = new System.Drawing.Point(479, 1);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(124, 24);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 12;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(441, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Lớp:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboKhoa.DisplayMember = "Text";
            this.cboKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.ItemHeight = 18;
            this.cboKhoa.Location = new System.Drawing.Point(63, 1);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(134, 24);
            this.cboKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboKhoa.TabIndex = 12;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx3_SelectedIndexChanged);
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(-7, 2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(103, 23);
            this.labelX10.TabIndex = 8;
            this.labelX10.Text = "Khóa học:";
            this.labelX10.Click += new System.EventHandler(this.labelX10_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.btnXoaKhoiLop);
            this.groupPanel4.Controls.Add(this.dtgvDanhsachsvcualop);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel4.DrawTitleBox = false;
            this.groupPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel4.Location = new System.Drawing.Point(0, 66);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(603, 443);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPanel4.Style.BackColor2 = System.Drawing.Color.AliceBlue;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 5;
            this.groupPanel4.Text = "Danh sách sinh viên thuộc lớp";
            this.groupPanel4.Click += new System.EventHandler(this.groupPanel4_Click);
            // 
            // btnXoaKhoiLop
            // 
            this.btnXoaKhoiLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaKhoiLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaKhoiLop.BackColor = System.Drawing.Color.White;
            this.btnXoaKhoiLop.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoaKhoiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoiLop.Location = new System.Drawing.Point(242, 356);
            this.btnXoaKhoiLop.Name = "btnXoaKhoiLop";
            this.btnXoaKhoiLop.Size = new System.Drawing.Size(143, 35);
            this.btnXoaKhoiLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnXoaKhoiLop.TabIndex = 11;
            this.btnXoaKhoiLop.Text = "Xóa khỏi lớp";
            this.btnXoaKhoiLop.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // dtgvDanhsachsvcualop
            // 
            this.dtgvDanhsachsvcualop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhsachsvcualop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDanhsachsvcualop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhsachsvcualop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.hoten2,
            this.lop,
            this.ngaysinh2,
            this.thoigiandangky,
            this.diemtongket,
            this.xeploai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhsachsvcualop.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDanhsachsvcualop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvDanhsachsvcualop.EnableHeadersVisualStyles = false;
            this.dtgvDanhsachsvcualop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvDanhsachsvcualop.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhsachsvcualop.Name = "dtgvDanhsachsvcualop";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhsachsvcualop.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvDanhsachsvcualop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhsachsvcualop.Size = new System.Drawing.Size(597, 340);
            this.dtgvDanhsachsvcualop.TabIndex = 0;
            this.dtgvDanhsachsvcualop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX2_CellContentClick);
            // 
            // id2
            // 
            this.id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.Width = 47;
            // 
            // hoten2
            // 
            this.hoten2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten2.DataPropertyName = "hoten";
            this.hoten2.HeaderText = "Họ tên";
            this.hoten2.Name = "hoten2";
            // 
            // lop
            // 
            this.lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lop.DataPropertyName = "ten";
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            this.lop.Visible = false;
            // 
            // ngaysinh2
            // 
            this.ngaysinh2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ngaysinh2.DataPropertyName = "ngaysinh";
            this.ngaysinh2.HeaderText = "Ngày sinh";
            this.ngaysinh2.Name = "ngaysinh2";
            this.ngaysinh2.Width = 90;
            // 
            // thoigiandangky
            // 
            this.thoigiandangky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.thoigiandangky.DataPropertyName = "thoigiandangky";
            this.thoigiandangky.HeaderText = "Thời gian đăng ký";
            this.thoigiandangky.Name = "thoigiandangky";
            this.thoigiandangky.Width = 122;
            // 
            // diemtongket
            // 
            this.diemtongket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diemtongket.DataPropertyName = "diemtongket";
            this.diemtongket.HeaderText = "Điểm tổng kết";
            this.diemtongket.Name = "diemtongket";
            this.diemtongket.Width = 96;
            // 
            // xeploai
            // 
            this.xeploai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.Name = "xeploai";
            this.xeploai.Width = 59;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Red;
            this.labelX6.Location = new System.Drawing.Point(0, 0);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(1046, 61);
            this.labelX6.TabIndex = 15;
            this.labelX6.Text = "ĐĂNG KÝ HỌC";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelX6);
            this.Name = "ucDanhSachLop";
            this.Size = new System.Drawing.Size(1046, 570);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachsinhvien)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachsvcualop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoten;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSdt;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvDanhsachsinhvien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvDanhsachsvcualop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThoiGian;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnThemVaoLop;
        private DevComponents.DotNetBar.ButtonX btnXoaKhoiLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandangky;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
