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
            InitializeComponent();

            this.Load += Form1_Load;
        }
        List<Plug> myList = null;
        private void Form1_Load(object sender, EventArgs e) 
        {
            myList = Kit.GetAllPlugins(Application.StartupPath + "//plugins");
            foreach (Plug p in myList)
            {
                Button b = new Button();
                b.Text = p.pName;
                b.Click += b_Click;
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            foreach (Plug p in myList)
            {
                if(p.pName==(sender as Button).Text)
                {
                    run(p);
                }
            }
        }
        private void run(Plug p)
        {
            IPlugin obj = (IPlugin)Kit.CreateObject(p);
            textBox1.Text = obj.action(textBox1.Text);
        }
    }
}
