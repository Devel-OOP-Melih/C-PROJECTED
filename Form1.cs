namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtomobilUretim arac1 = new OtomobilUretim();
            OtomobilUretim arac2 = new OtomobilUretim();
            OtomobilUretim arac3 = new OtomobilUretim();

            arac1.renk = "SÝYAH";
            arac2.renk = "GRÝ";
            arac3.renk = "MAVÝ";

            arac1.jant = "ÇELÝK";
            arac2.jant = "MONO KAPAKLI";
            arac3.jant = "ORJINAL";

            richTextBox1.Text = "ARAÇ1" + " " + arac1.renk + " " + arac1.jant + "\n" +
                              "ARAÇ2" + " " + arac2.renk + " " + arac2.jant + "\n" +
                              "ARAÇ3" + " " + arac3.renk + " " + arac3.jant;//arac3.getModel();

        }
    }
}
