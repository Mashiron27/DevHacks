using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Devhacks
{
    public partial class SeeAtRisk : Form
    {
        public SeeAtRisk(string strTextbox)
        {
            InitializeComponent();
            label1.Text = strTextbox;
        }

        private void SeeAtRisk_Load(object sender, EventArgs e)
        {
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

            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox27.Visible = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homePage = new Homepage();
            homePage.Closed += (s, args) => this.Close();
            homePage.Show();
        }

        private void pictureBox23_MouseHover(object sender, EventArgs e)
        {
            pictureBox24.Visible = true;
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.Visible = false;
        }

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            pictureBox25.Visible = true;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox25.Visible = false;
        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox27.Visible = false;
        }
    }
}
