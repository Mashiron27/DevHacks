using System;
using System.Windows.Forms;

namespace Devhacks
{
    public partial class AddAttendance : Form
    {
        public string NbOfColumns;
        public string NbOfRows;

        public AddAttendance(string strTextbox, string seatCols, string seatRows)
        {
            InitializeComponent();
            label1.Text = strTextbox;
            NbOfColumns = seatCols;
            NbOfRows = seatRows;
        }

        //public PictureBox[] pics = new PictureBox[20];

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            /*
            PictureBox[,] pics = new PictureBox[4,5];
            foreach (var row in NbOfRows)
            {
                foreach(var col in NbOfColumns)
                {
                    pics[row, col] = new PictureBox();
                    pics[row, col].Location = new System.Drawing.Point();
                    pics[row, col].Name = "pic" + col + row;
                    pics[row, col].Size = new System.Drawing.Size();
                    pics[row, col].Image = Properties.Resources.noSelection;
                    pics[row, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(pics[row, col]);
                }
            }*/
            
            pictureBox1.Image = Properties.Resources.noSelection;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.noSelection;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Properties.Resources.noSelection;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Properties.Resources.noSelection;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Properties.Resources.noSelection;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Properties.Resources.noSelection;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Properties.Resources.noSelection;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Properties.Resources.noSelection;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Properties.Resources.noSelection;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Properties.Resources.noSelection;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.Image = Properties.Resources.noSelection;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.Image = Properties.Resources.noSelection;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.Image = Properties.Resources.noSelection;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.Image = Properties.Resources.noSelection;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.Image = Properties.Resources.noSelection;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.Image = Properties.Resources.noSelection;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.Image = Properties.Resources.noSelection;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.Image = Properties.Resources.noSelection;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.Image = Properties.Resources.noSelection;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.Image = Properties.Resources.noSelection;
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Hide();
            var seeAtRisk = new SeeAtRisk(label1.Text);
            seeAtRisk.Closed += (s, args) => this.Close();
            seeAtRisk.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources.leftSelection;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox2.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox3.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox4.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox5.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox6.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox7.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox8.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox9.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox10.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox11.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox12.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox13.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox14.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox15.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox16.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox17.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox18.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox19.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox20_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox20.Image = Properties.Resources.rightSelection;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.noSelection;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.noSelection;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.noSelection;
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.noSelection;
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.noSelection;
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.noSelection;
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.noSelection;
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.noSelection;
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.noSelection;
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.noSelection;
        }

        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.noSelection;
        }

        private void pictureBox12_DoubleClick(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.noSelection;
        }

        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.noSelection;
        }

        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.noSelection;
        }

        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.noSelection;
        }

        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.noSelection;
        }

        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.noSelection;
        }

        private void pictureBox18_DoubleClick(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources.noSelection;
        }

        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources.noSelection;
        }

        private void pictureBox20_DoubleClick(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources.noSelection;
        }
    }
}
