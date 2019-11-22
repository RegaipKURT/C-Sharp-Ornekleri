using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd1;
        //Random rnd2;
        //Random rnd3;

        Thread thr1;
        Thread thr2;
        Thread thr3;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            btn_Blue.Click += Btn_Blue_Click;
            btn_Green.Click += Btn_Green_Click;
            btn_Red.Click += Btn_Red_Click;


            
        }

        private void Btn_Red_Click(object sender, EventArgs e)
        {
            thr1 = new Thread(Metot1);
            thr1.Start();
        }
        private void Btn_Green_Click(object sender, EventArgs e)
        {
            thr2 = new Thread(Metot2);
            thr2.Start();
        }
        private void Btn_Blue_Click(object sender, EventArgs e)
        {
            thr3 = new Thread(Metot3);
            thr3.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd1 = new Random();
            //rnd2 = new Random();
            //rnd3 = new Random();
        }
        public void Metot1() {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4),
                new Rectangle(rnd1.Next(0, this.Width), rnd1.Next(0, this.Height), 30, 30));
                System.Threading.Thread.Sleep(20);
            }
        }
        public void Metot2()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 4),
                new Rectangle(rnd1.Next(0, this.Width), rnd1.Next(0, this.Height), 30, 30));
                System.Threading.Thread.Sleep(20);
            }
        }
        public void Metot3()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4),
                new Rectangle(rnd1.Next(0, this.Width), rnd1.Next(0, this.Height), 30, 30));
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
