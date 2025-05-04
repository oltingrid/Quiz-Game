using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_project
{

    public partial class Form1 : Form
    {
        List<questions> a;
        private int score = 0, pr = -1, nr = 0, cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            a = new List<questions>();
            StreamReader inputFile;
            inputFile = File.OpenText(@"..\..\TextFile1.txt");
            label1.Size = new Size(120, 100);
            label1.Location = new Point(5, 30);
            while (!inputFile.EndOfStream)  //daca nu s-a terminat fisierul
            {
                string s = inputFile.ReadLine();
                if (s.Length != 0)

                {
                    questions u = new questions(s);
                    a.Add(u);
                    nr++;
                }
            }

            /// MessageBox.Show(a.Count.ToString());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Show();
            label1.Show();
            label2.Show();
            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
            button1.Show();
            scorelbl.Show();
            foreach (questions f in a)
                if (f.DOM == comboBox1.SelectedItem.ToString())
                {
                    if (pr == -1)
                    {
                        pr = a.IndexOf(f);
                        label1.Text = f.Q;
                        radioButton1.Text = f.A;
                        radioButton2.Text = f.B;
                        radioButton3.Text = f.C;
                        radioButton4.Text = f.D;
                        pictureBox1.ImageLocation = @"..\..\Poze\" + f.POZA;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        cont++;
                    }

                }
            pr = pr + 1;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Show();
            panel1.Enabled = true;
            pictureBox1.Hide();
            label1.Hide();
            label2.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            button1.Hide();
            scorelbl.Hide();
        }
        private void AddToScore(int points)
        {
            score += points;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int ok = 0;
            if (radioButton1.Checked)
            {
                foreach (questions f in a)
                    if (f.R == radioButton1.Text && ok == 0)
                    {
                        AddToScore(5); //Adauga 5 puncte la scor
                        scorelbl.Text = score.ToString();
                        MessageBox.Show("Raspuns corect!");
                        ok = 1;
                    }
                if (ok == 0)
                {
                    MessageBox.Show("Raspuns gresit!");
                }
            }


            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int ok = 0;
            if (radioButton3.Checked)
            {
                foreach (questions f in a)
                    if (f.R == radioButton3.Text && ok == 0)
                    {
                        AddToScore(5); //Adauga 5 puncte la scor
                        scorelbl.Text = score.ToString();
                        MessageBox.Show("Raspuns corect!");
                        ok = 1;
                    }
                if (ok == 0)
                {
                    MessageBox.Show("Raspuns gresit!");
                }

            }

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int ok = 0;
            if (radioButton2.Checked)
            {
                foreach (questions f in a)
                    if (f.R == radioButton2.Text && ok == 0)
                    {
                        AddToScore(5); //Adauga 5 puncte la scor
                        scorelbl.Text = score.ToString();
                        MessageBox.Show("Raspuns corect!");
                        ok = 1;
                    }
                if (ok == 0)
                {
                    MessageBox.Show("Raspuns gresit!");
                }

            }

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int ok = 0;
            if (radioButton4.Checked)
            {
                foreach (questions f in a)
                    if (f.R == radioButton4.Text && ok == 0)
                    {
                        AddToScore(5); //Adauga 5 puncte la scor
                        scorelbl.Text = score.ToString();
                        MessageBox.Show("Raspuns corect!");
                        ok = 1;
                    }
                if (ok == 0)
                {
                    MessageBox.Show("Raspuns gresit!");
                }
            }

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pr<nr)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                questions f = a.ElementAt(pr);
                while (pr < nr && pr > 0 && f.DOM != comboBox1.SelectedItem.ToString())
                {
                    pr++; 
                    if(pr<nr) f = a.ElementAt(pr); ///MessageBox.Show(cont.ToString());
                }
                if( f.DOM == comboBox1.SelectedItem.ToString())
                {
                    label1.Text = f.Q;                     
                    radioButton1.Text = f.A;
                    radioButton2.Text = f.B;
                    radioButton3.Text = f.C;
                    radioButton4.Text = f.D;
                    pictureBox1.ImageLocation = @"..\..\Poze\" + f.POZA;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pr++;
                    cont++;

                }
                    
            }
            else
            {

                MessageBox.Show
                    (
                    "Jocul s-a terminat!" + Environment.NewLine +
                    "Ai raspuns corect la " + score / 5 + " intrebari din " + cont
                    + Environment.NewLine + "Scorul tau e de " + score + " puncte."
                    );
                this.Close();
            }

        }

    }
}
