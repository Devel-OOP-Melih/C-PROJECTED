using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class HeliMotor
    {
        private int beygirGucu;
        private int tork;
        private RichTextBox richTextBox;
        private PictureBox pictureBox;

        public HeliMotor(int beygirGucu, int tork, RichTextBox richTextBox, PictureBox pictureBox)
        {
            this.beygirGucu = beygirGucu;
            this.tork = tork;
            this.richTextBox = richTextBox;
            this.pictureBox = pictureBox;
        }

        public int BeygirGucu { get => beygirGucu; set => beygirGucu = value; }
        public int Tork { get => tork; set => tork = value; }

        public void motorCalissin()
        {
            this.richTextBox.Text = " MOTOR AKTİFLEŞTİRİLDİ...";
            this.pictureBox.Load(@"C:\Users\LENOVO\OneDrive\Belgeler\Heli22.png");
        }

        public void motorDurdurulsun()
        {
            this.richTextBox.Text = " MOTOR DURDURULDU...";
            this.pictureBox.Load(@"C:\Users\LENOVO\OneDrive\Belgeler\Helii.png");
        }
    }
}
