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
    public partial class Delete_Forms : Form
    {
        public Delete_Forms()
        {
            InitializeComponent();
        }

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
                string[] inventoryData = File.ReadAllLines("students.txt");
                List<string> inventoryDataList = inventoryData.ToList(); //Масив -> Список
                if (inventoryDataList.Remove(Student)) //Видалення строки, якщо було знайдено.
                {
                    File.WriteAllLines("students.txt", inventoryDataList.ToArray());
                    MessageBox.Show("Successfully deleted!");
                    Close();
                }
                else
                {
                    MessageBox.Show("No matches found!");
                    Close();
                }
            }
        }

        private void tb_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

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
