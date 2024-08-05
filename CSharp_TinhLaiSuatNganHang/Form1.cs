namespace CSharp_TinhLaiSuatNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double soTien;
        private double laiSuat;
        private short namGui;

        private void GetLaiSuat()
        {
            for (double i = 1; i <= 10; i++)
            {                
                cboLaiSuat.Items.Add(i/100);
            }
        }
        private void GetInfo()
        {
            soTien = Convert.ToDouble(txtSoTien.Text);
            laiSuat = double.Parse(cboLaiSuat.SelectedItem.ToString());
            namGui = (short)nrdYear.Value;

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            GetInfo();
            for (short i = 1; i<=namGui; i++)
            {
                double tienLai = soTien + laiSuat;
                lbKetQua.Items.Add("-Tiền lãi" + tienLai + "- Năm gữi" + namGui + "- Gốc" + soTien);
                soTien += tienLai;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLaiSuat();
            cboLaiSuat.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSoTien.Text = "10000000";
        }
    }
}
