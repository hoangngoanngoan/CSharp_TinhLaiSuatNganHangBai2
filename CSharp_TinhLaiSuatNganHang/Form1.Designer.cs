namespace CSharp_TinhLaiSuatNganHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoTien = new TextBox();
            cboLaiSuat = new ComboBox();
            nrdYear = new NumericUpDown();
            label5 = new Label();
            lbKetQua = new ListBox();
            btnTinh = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)nrdYear).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 23);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính lãi suất ngân hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 1;
            label2.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 104);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Lãi suất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 150);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 3;
            label4.Text = "Số năm gửi:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(206, 55);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(322, 30);
            txtSoTien.TabIndex = 4;
            // 
            // cboLaiSuat
            // 
            cboLaiSuat.FormattingEnabled = true;
            cboLaiSuat.Location = new Point(206, 101);
            cboLaiSuat.Name = "cboLaiSuat";
            cboLaiSuat.Size = new Size(322, 31);
            cboLaiSuat.TabIndex = 5;
            // 
            // nrdYear
            // 
            nrdYear.Location = new Point(206, 148);
            nrdYear.Name = "nrdYear";
            nrdYear.Size = new Size(120, 30);
            nrdYear.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 195);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 7;
            label5.Text = "Kết quả:";
            // 
            // lbKetQua
            // 
            lbKetQua.FormattingEnabled = true;
            lbKetQua.ItemHeight = 23;
            lbKetQua.Location = new Point(50, 230);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(478, 188);
            lbKetQua.TabIndex = 8;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(351, 438);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 34);
            btnTinh.TabIndex = 9;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(442, 438);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 34);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 498);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(lbKetQua);
            Controls.Add(label5);
            Controls.Add(nrdYear);
            Controls.Add(cboLaiSuat);
            Controls.Add(txtSoTien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nrdYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoTien;
        private ComboBox cboLaiSuat;
        private NumericUpDown nrdYear;
        private Label label5;
        private ListBox lbKetQua;
        private Button btnTinh;
        private Button btnThoat;
    }
}
