using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.Load += Form1_Load;

            InitializeComponent();
        }
        List<Plug> myList = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            myList = Kit.GetAllPlugins(Application.StartupPath+ "\\plugins");
            foreach (Plug p in myList)
            {
                Button B = new Button();
                B.Name = p.pName.ToString();
                B.Click += B_Click;
                flowLayoutPanel1.Controls.Add(B);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            foreach (Plug p in myList)
            {
                if (p.pName == (sender as Button).Text)
                {
                    Run(p);
                }
            }
        }

        private void Run(Plug p)
        {
            IPlugin obj = (IPlugin)Kit.CreateP(p);
            textBox1.Text = obj.Action(textBox1.Text);
        }
    }
}
