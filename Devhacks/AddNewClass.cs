using System;
using System.Windows.Forms;

namespace Devhacks
{
    public partial class AddNewClass : Form
    {
        public string NbOfColumns;
        public string NbOfRows; 

        public AddNewClass(string seatCols, string seatRows)
        {
            InitializeComponent();
            NbOfColumns = seatCols;
            NbOfRows = seatRows;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addAttendance = new AddAttendance(textBox1.Text, NbOfColumns, NbOfRows);
            addAttendance.Closed += (s, args) => this.Close();
            addAttendance.Show();
        }
    }
}
