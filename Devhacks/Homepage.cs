using System;
using System.Windows.Forms;

namespace Devhacks
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox4.Image = Properties.Resources.drop1;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == false)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addNewClassSizes = new AddNewClassSizes();
            addNewClassSizes.Closed += (s, args) => this.Close();
            addNewClassSizes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addAttendance = new AddAttendance("4b", "", "");
            addAttendance.Closed += (s, args) => this.Close();
            addAttendance.Show();
        }
    }
}
