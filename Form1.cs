namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Tính_Click(object sender, EventArgs e)
        {
            double A, B, C, nghiemkep, x1, x2, delta;
            A = Convert.ToDouble(SoA.Text);
            B = Convert.ToDouble(SoB.Text);
            C = Convert.ToDouble(SoC.Text);
            delta = B * B - 4 * A * C;

            if (A == 0)
                Giaiptbac1(B,C);
            else
            {
                if (delta < 0)
                {
                    LabelKetQua.Text = "Phương trình vô nghiệm !!!";
                }
                else if (delta == 0)
                {
                    nghiemkep = -B / 2 * A;
                    LabelKetQua.Text = "Phương trình có nghiệm kép " + nghiemkep.ToString();


                }
                else
                {
                    x1 = (-B + Math.Sqrt(delta) / 2 * A);
                    x2 = (-B - Math.Sqrt(delta) / 2 * A);
                    LabelKetQua.Text = ("Phương trình có 2 nghiệm phân biệt x1 = " + x1 + "  và x2 = " + x2).ToString();
                }
            }
        }
        private void Giaiptbac1(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                LabelKetQua.Text = "Phương trình có vô số nghiệm ";
            }
            else if (a == 0 && b != 0)
            {
                LabelKetQua.Text = "Phương trình vô nghiệm !!!";
            }
            else
            {
                LabelKetQua.Text = ("Phương trình có nghiệm x = " + (-b / a)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
