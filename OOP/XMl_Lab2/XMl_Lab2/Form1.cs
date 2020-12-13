using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMl_Lab2
{
    public partial class XmlSearch : Form
    {
        private List<Movie> movies = new List<Movie>();
        public static string path = "C:\\Users\\Admin\\Documents\\program67\\XMl_Lab2\\XMl_Lab2\\XMLFile1.xml";
        public XmlSearch()
        {
            InitializeComponent();
        }


        private void XmlSearch_Load(object sender, EventArgs e)
        {
            FormAdmin.LoadInfo(comboGenre, "genre", "GENRE");
            FormAdmin.LoadInfo(comboStudio, "studio", "STUDIO");
            FormAdmin.LoadInfo(comboName, "movie", "NAME");
            FormAdmin.LoadInfo(comboYear, "movie", "YEAR");
            FormAdmin.LoadInfo(comboTime, "movie", "TIME");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cleaner();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (!SearchCheck())
            {
                movies.Clear();
                MessageBox.Show("You don't check the method of search");

            }
        }
        private void buttonHtml_Click(object sender, EventArgs e)
        {
            FormAdmin.Transform();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені,що хочете закрити програму", "Увага!",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private Movie ReadParametrs()
        {
            string[] parametrs = new string[5];
            if(checkBoxGenre.Checked)
            {
                if (comboGenre.Text!=string.Empty)
                {
                    
                    parametrs[0] = comboGenre.Text;
                }
                else
                {
                    MessageBox.Show("You don't choose genre");
                }
            }
            if (checkBoxStudio.Checked)
            {
                if (comboStudio.Text != string.Empty)
                {
                    parametrs[1] = comboStudio.Text;
                }
                else
                {
                    MessageBox.Show("You don't choose studio");
                    
                }
            }
            if (checkBoxName.Checked)
            {
                if (comboName.Text != string.Empty)
                {
                    parametrs[2] = comboName.Text;
                }
                else
                {
                    MessageBox.Show("You don't choose name");
                }
            }
            if (checkBoxYear.Checked)
            {
                if (comboYear.Text != string.Empty)
                {
                    parametrs[3] = comboYear.Text;
                }
                else
                {
                    MessageBox.Show("You don't choose year");
                }
            }
            if (checkBoxTime.Checked)
            {
                if (comboTime.Text != string.Empty)
                {
                    parametrs[4] = comboTime.Text;
                }
                else
                {
                    MessageBox.Show("You don't choose time");
                }

            }
            return new Movie(parametrs);
        }

        private void Cleaner()
        {
            TextOut.Clear();
            checkBoxGenre.Checked = false;
            checkBoxStudio.Checked = false;
            checkBoxName.Checked = false;
            checkBoxYear.Checked = false;
            checkBoxTime.Checked = false;
            comboGenre.Text = null;
            comboStudio.Text = null;
            comboYear.Text = null;
            comboName.Text = null;
            comboTime.Text = null;
            radioDOM.Checked = false;
            radioLINQ.Checked = false;
            radioSAX.Checked = false;
        }

        private void OutPut(List<Movie> final)
        {
            int i = 1;
            foreach(Movie m in final)
            {
                TextOut.AppendText(i++ + ".\n");
                TextOut.AppendText("Genre: " + m.Genre + "\n");
                TextOut.AppendText("Studio: " + m.Studio + "\n");
                TextOut.AppendText("Name: " + m.Name + "\n");
                TextOut.AppendText("Year: " + m.Year + "\n");
                TextOut.AppendText("Time: " + m.Time + "\n");
                TextOut.AppendText("---------------------------------------------------\n");
            }
        }
        private bool SearchCheck()
        {
            TextOut.Clear();
            Movie movie = ReadParametrs();
            ISearch algo;
            if (radioLINQ.Checked)
            {
                algo = new Linq(path);
                movies = algo.Method(movie);
                OutPut(movies);
                return true;
            }
            if (radioSAX.Checked)
            {
                algo = new SAX(path);
                movies = algo.Method(movie);
                OutPut(movies);
                return true;
            }
            if (radioDOM.Checked)
            {
                algo = new DOM(path);
                movies = algo.Method(movie);
                OutPut(movies);
                return true;
            }
            return false;
        }
    }
}
