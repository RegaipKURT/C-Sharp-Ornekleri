using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate_form
{
    public partial class Giris : Form
    {
        bool ayarla_flag = true;
        delegate int carp(int x);
        delegate void mesaj(string mes); 
        public Giris()
        {
            
            //yukarıda oluşturduğumuz delegate leri kullanalım
            //carp kare = x => x * x;
            //int y = kare(3);
            //MessageBox.Show(y.ToString());


            ////normalde aşağıdaki ifadeyi bir metotla yapmamız gerekirken delegate ile hallettik;
            //mesaj goster;
            //goster = mes => MessageBox.Show(mes);
            //goster("Hoşgeldiniz!");

            ////şimdi aşağıdaki ifadeyi lambda ile yazalım
            this.Click += FormClick;
            //this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString(), "Delegate"); };
            

            InitializeComponent();


            // delegate oluşturarak buton metotlarını gösterelim
            //this.giris_button.Click += delegate { MessageBox.Show("Tıklandı"); };

        }

        public void Pars_ico_buton_Click(object sender, EventArgs e)
        {
            if (this.ayarla_flag== true)
            {
                for (int i = 0; i <= panel1.Height + 1; i++)
                {
                    System.Threading.Thread.Sleep(10);
                    panel1.Height = panel1.Height - i;
                    //pars_ico_buton.Height -= 1;
                    label1.Height -= 1;
                    small.Height -= 1;
                    exit.Height -= 1;

                }
                this.ayarla_flag = false;
            }
            else
            {
                for (int k = 1; k <= 37; k++)
                {
                    System.Threading.Thread.Sleep(2);
                    panel1.Height = k;
                    //pars_ico_buton.Height = 32;
                    label1.Height = 31;
                    small.Height = 32;
                    exit.Height = 32;
                }
                this.ayarla_flag = true;
            }
        }

        private void FormClick(object sender, EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).Location.ToString(), "Normal Metod");
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Program Test Aşamasında\n" + e.ToString() +"\n"+ sender.ToString(), "Giriş Hatası!");
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void small_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ayarla_Click(object sender, EventArgs e)
        {
            
            if (ayarla_flag == true)
            {
                for (int i = 0; i <= panel1.Height+1; i++)
                {
                    System.Threading.Thread.Sleep(10);
                    panel1.Height = panel1.Height - i;
                    //pars_ico_buton.Height -= 1;
                    label1.Height -= 1;
                    small.Height -= 1;
                    exit.Height -= 1;

                }
                panel1.Visible = false;
                ayarla_flag = false;
            }
            else {
                panel1.Visible = true;
                for (int k = 1; k <= 37; k++)
                {
                    System.Threading.Thread.Sleep(2);
                    panel1.Height = k;
                    //pars_ico_buton.Height = 32;
                    label1.Height = 31;
                    small.Height = 32;
                    exit.Height = 32;
                }

                ayarla_flag = true;
            }
        }
    }
}



