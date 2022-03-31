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
        public class Freq
        {
            char n;
            int f;
            
            public Freq(char nn)
            {
                this.n = nn;
               // this.f = nf;
            }
        }


      
        
        public Form1()
        {
            string str = richTextBox1.Text;
            List<Freq> frq = new List<Freq>();
            foreach (char i in str)
            {
                frq.Add(i);
            }
            InitializeComponent();
        }
    }
}
