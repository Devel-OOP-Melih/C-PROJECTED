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

            arac1.renk = "S�YAH";
            arac2.renk = "GR�";
            arac3.renk = "MAV�";

            arac1.jant = "�EL�K";
            arac2.jant = "MONO KAPAKLI";
            arac3.jant = "ORJINAL";

            richTextBox1.Text = "ARA�1" + " " + arac1.renk + " " + arac1.jant + "\n" +
                              "ARA�2" + " " + arac2.renk + " " + arac2.jant + "\n" +
                              "ARA�3" + " " + arac3.renk + " " + arac3.jant;//arac3.getModel();

        }
    }
}
