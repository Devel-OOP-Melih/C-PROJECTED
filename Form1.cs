namespace Composition
{
    public partial class FormHeli : Form
    {
        private Helikopter Atak23;
        public FormHeli()
        {
            InitializeComponent();

            InitMyHeli();
        }

        private void InitMyHeli()
        {
            HeliDepo myDepo = new HeliDepo(250);
            HeliPervane myPervane = new HeliPervane(15, 3500);
            HeliMotor myMotor = new HeliMotor(190, 73 , richTextBox1 , pictureBox1);
            
            Atak23 = new Helikopter("T-123" , myMotor , myDepo , myPervane); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atak23.heliCalistir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atak23.heliDursun();
        }
    }
}
