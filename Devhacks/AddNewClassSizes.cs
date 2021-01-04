using System;
using System.Windows.Forms;

namespace Devhacks
{
    public partial class AddNewClassSizes : Form
    {
        public AddNewClassSizes()
        {
            InitializeComponent();
        }

        private void AddNewClassSizes_Load(object sender, EventArgs e)
        {
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox42.Visible = false;

            label2.Text = "0";
            label3.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addNewClass = new AddNewClass(label2.Text, label2.Text);
            addNewClass.Closed += (s, args) => this.Close();
            addNewClass.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox21.Visible = true;
            label2.Text = "1";
            label3.Text = "1";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox22.Visible = true;
            label2.Text = "2";
            label3.Text = "1";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox23.Visible = true;
            label2.Text = "3";
            label3.Text = "1";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox24.Visible = true;
            label2.Text = "4";
            label3.Text = "1";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox25.Visible = true;
            label2.Text = "5";
            label3.Text = "1";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = true;
            label3.Text = "2";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
            label3.Text = "2";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = true;
            label3.Text = "2";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = true;
            label3.Text = "2";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = true;
            label3.Text = "2";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox31.Visible = true;
            label3.Text = "3";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = true;
            label3.Text = "3";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = true;
            label3.Text = "3";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox34.Visible = true;
            label3.Text = "3";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = true;
            label3.Text = "3";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox36.Visible = true;
            label3.Text = "4";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = true;
            label3.Text = "4";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = true;
            label3.Text = "4";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = true;
            label3.Text = "4";
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox42.Visible = true;
            label3.Text = "4";
        }
    }
}
