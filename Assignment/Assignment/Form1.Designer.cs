
namespace Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSV = new System.Windows.Forms.ComboBox();
            this.dgvGirdView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenSV = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.MaKhoa = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // cbbSV
            // 
            this.cbbSV.FormattingEnabled = true;
            this.cbbSV.Location = new System.Drawing.Point(470, 67);
            this.cbbSV.Name = "cbbSV";
            this.cbbSV.Size = new System.Drawing.Size(141, 24);
            this.cbbSV.TabIndex = 1;
            this.cbbSV.SelectedIndexChanged += new System.EventHandler(this.cbbSV_SelectedIndexChanged);
            // 
            // dgvGirdView
            // 
            this.dgvGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGirdView.Location = new System.Drawing.Point(58, 281);
            this.dgvGirdView.Name = "dgvGirdView";
            this.dgvGirdView.RowHeadersWidth = 51;
            this.dgvGirdView.RowTemplate.Height = 24;
            this.dgvGirdView.Size = new System.Drawing.Size(684, 224);
            this.dgvGirdView.TabIndex = 2;
            this.dgvGirdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGirdView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Khoa";
            // 
            // TenSV
            // 
            this.TenSV.Location = new System.Drawing.Point(155, 28);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(144, 22);
            this.TenSV.TabIndex = 7;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(155, 86);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(144, 22);
            this.NgaySinh.TabIndex = 8;
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(155, 147);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(144, 22);
            this.Sex.TabIndex = 9;
            // 
            // MaKhoa
            // 
            this.MaKhoa.Location = new System.Drawing.Point(155, 204);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(144, 22);
            this.MaKhoa.TabIndex = 10;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(655, 68);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.TenSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGirdView);
            this.Controls.Add(this.cbbSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSV;
        private System.Windows.Forms.DataGridView dgvGirdView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TenSV;
        private System.Windows.Forms.TextBox NgaySinh;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.TextBox MaKhoa;
        private System.Windows.Forms.Button Search;
    }
}

