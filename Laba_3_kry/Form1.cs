using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3_kry
{
    public partial class Form1 : Form
    {
       


      
        
        public Form1()
        {
           
            InitializeComponent();
        }

        public class Freq
        {
            public string I;
            public int N;

            public Freq(string nn, int num)
            {
                I = nn;
                N = num;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            List<Freq> frq = new List<Freq>();

            bool search = false;
            foreach (char i in str)
            {
                
                foreach (Freq f in frq)
                {
                    if (i.ToString() == f.I && search == false)
                    {
                        f.N++;
                        search = true;
                    }
                }
                if (search == false)
                {
                    frq.Add(new Freq(i.ToString(), 0));
                }
                search = false;
            }
            foreach (Freq f in frq)
            {
               
                Console.WriteLine(f.I + " = " + f.N);
            }

        }
    }
}
