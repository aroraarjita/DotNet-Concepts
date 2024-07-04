using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethodsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button Button1 = new Button();
            Button1.Text = "Click Me!";
            Button1.Click += (object send, EventArgs eventArgs) => {
                MessageBox.Show("Hello! You just clicked me!");
            };
            this.Controls.Add(Button1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! You just click me");
        }
    }
}
