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
            public string Code;
            public Freq L = null;
            public Freq R = null;

            public Freq(string nn, int num)
            {
                I = nn;
                N = num;
            }

        }
        List<Freq> frq = new List<Freq>();
        List<Freq> frq_fin = new List<Freq>();
        public Freq n = new Freq("", 0);
        public void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            

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
                    frq.Add(new Freq(i.ToString(), 1));
                }
                search = false;
            }
            foreach (Freq f in frq)
            {
               
                Console.WriteLine(f.I + " = " + f.N);
            }

            
            int count = frq[0].N;
            int number = 0;


            while(frq.Count != 1) { 
            n = new Freq("", 0);
            number = 0;
            count = frq[0].N;
            foreach (Freq f in frq)
            {
                
               if (f.N <= count)
                {
                    count = f.N;
                    n.L = f;
                    number = frq.IndexOf(f);
                }
            }
            Console.WriteLine("Remuve = " + frq[number].I);
            frq.Remove(frq[number]);
            n.I = n.I + n.L.I;
            n.N = n.N + n.L.N;

            Console.WriteLine( "L = " + n.L.I);

            

            count = frq[0].N;
            number = 0;
            foreach (Freq f in frq)
            {

                if (f.N <= count)
                {
                    count = f.N;
                    n.R = f;
                    number = frq.IndexOf(f);
                }
            }
            Console.WriteLine("Remuve = " + frq[number].I);

            frq.Remove(frq[number]);
            n.I = n.I + n.R.I;
            n.N = n.N + n.R.N;
            Console.WriteLine("R = " + n.R.I);
            frq.Add(n);
            foreach (Freq f in frq)
            {

                Console.WriteLine(f.I + " = " + f.N);
            }
            }
            Console.WriteLine("####################################");
           
            foreach(char f in str)
            {
                Freq p = n;
                string p_count = "";
                while (p.I != f.ToString())
                {
                    bool b = true;
                    foreach(char f_frq in p.L.I)
                    {
                        if (f == f_frq)
                        {
                            p_count = p_count + "1";
                            p = p.L;
                            b = false;
                        }
                    }
                    if (b)
                    {
                        p_count = p_count + "0";
                        p = p.R;
                    }
                }
                p.Code = p_count;
                Console.WriteLine("I = "+p.I + " count = "+ p.Code);
                richTextBox2.Text = richTextBox2.Text + p.Code;
                
                
            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
           
            foreach (char i in str)
            {
                i.ToString();
                Console.WriteLine((byte)i);
                string BinaryCode = Convert.ToString(i, 2);

                richTextBox3.Text = richTextBox3.Text + BinaryCode;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string str = richTextBox2.Text;
            Freq p = n;
            foreach (char i in str)
            {

                if (p.I.Length == 1)
                {
                    richTextBox1.Text = richTextBox1.Text + p.I;
                    p = n;
                }
                    if (i == '1')
                    {
                        p = p.L;
                    
                    }
                    if (i == '0')
                    {
                        p = p.R;
                    
                }
                Console.WriteLine(" i = " + p.I);
            }
            richTextBox1.Text = richTextBox1.Text + p.I;
            p = n;




        }


        }
    }

