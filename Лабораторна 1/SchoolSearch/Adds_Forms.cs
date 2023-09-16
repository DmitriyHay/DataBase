using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SchoolSearch
{
    public partial class Adds_Forms : Form
    {
        public Adds_Forms()
        {
            InitializeComponent();
        }
        
        private void tb_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        //Введеня номеру класу.
        private void tb_Classroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tb_Bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        //Клавіша додати.
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_SecondName.Text == "" || tb_FirstName.Text == "" || tb_Grade.Text == "" || tb_Classroom.Text
    == "" || tb_Bus.Text == "" || tb_TLastName.Text == "" || tb_TFirstName.Text == "")
            {
                MessageBox.Show("The field is not filled!");
            }
            else
            {
                string Student = tb_SecondName.Text + "," + tb_FirstName.Text + "," + tb_Grade.Text + "," + tb_Classroom.Text
                + "," + tb_Bus.Text + "," + tb_TLastName.Text + "," + tb_TFirstName.Text;
                StreamWriter Writer = new StreamWriter("students.txt", true);
                Writer.WriteLine(Student);
                Writer.Close();
                MessageBox.Show("Successfully added!");
                Close();
            }
        }
        //Клавіша очистити всі поля вводу.
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_SecondName.Text = "";
            tb_FirstName.Text = "";
            tb_Grade.Text = "";
            tb_Classroom.Text = "";
            tb_Bus.Text = "";
            tb_TLastName.Text = "";
            tb_TFirstName.Text = "";
        }
    }


}
