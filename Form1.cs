namespace OOP_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtomobilUretim arac1 = new OtomobilUretim("S�YAH" , "�EL�K" , 5);
            OtomobilUretim arac2 = new OtomobilUretim("GR�" , "MONO KAPAKLI");

            richTextBox1.Text ="ARA�1" + " " + arac1.RENK + " " + arac1.JANT + " " + arac1.getBoy() + "\n" +
                               "ARA�2" + " " + arac2.RENK + " " + arac2.JANT + " " +arac2.getModel();
        }
    }
}
