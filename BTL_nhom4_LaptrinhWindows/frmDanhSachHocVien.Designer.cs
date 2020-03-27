namespace BTL_nhom4_LaptrinhWindows
{
    partial class frmDanhSachHocVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.thongkesinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTL_N04DataSet1 = new BTL_nhom4_LaptrinhWindows.BTL_N04DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongkesinhvienTableAdapter = new BTL_nhom4_LaptrinhWindows.BTL_N04DataSet1TableAdapters.thongkesinhvienTableAdapter();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.thongkesinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTL_N04DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // thongkesinhvienBindingSource
            // 
            this.thongkesinhvienBindingSource.DataMember = "thongkesinhvien";
            this.thongkesinhvienBindingSource.DataSource = this.BTL_N04DataSet1;
            // 
            // BTL_N04DataSet1
            // 
            this.BTL_N04DataSet1.DataSetName = "BTL_N04DataSet1";
            this.BTL_N04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongkesinhvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_nhom4_LaptrinhWindows.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1293, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongkesinhvienTableAdapter
            // 
            this.thongkesinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(409, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã lớp";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(482, 13);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(125, 20);
            this.textBoxX1.TabIndex = 2;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(641, 11);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Hiển thị";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmDanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 628);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDanhSachHocVien";
            this.Text = "frmDanhSachHocVien";
            this.Load += new System.EventHandler(this.frmDanhSachHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongkesinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTL_N04DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thongkesinhvienBindingSource;
        private BTL_N04DataSet1 BTL_N04DataSet1;
        private BTL_N04DataSet1TableAdapters.thongkesinhvienTableAdapter thongkesinhvienTableAdapter;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}