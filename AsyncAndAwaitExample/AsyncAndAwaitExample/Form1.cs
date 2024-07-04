using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AsyncAndAwaitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Data\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            //Task<int> task = new Task<int>(CountCharacters);
            //task.Start();
            lblCount.Text = "Processing File. Please wait...";

            Thread thread = new Thread(()=> {
                count = CountCharacters();
                Action action = () => lblCount.Text = count.ToString() + "characters in the file";
                this.BeginInvoke(action);
                
            });
            thread.Start();

            
            //int count = await task;
            thread.Join();
            lblCount.Text = count.ToString() + "characters in file";

        }
    }
}
