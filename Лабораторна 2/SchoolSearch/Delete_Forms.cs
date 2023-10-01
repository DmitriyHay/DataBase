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
                MessageBox.Show("Поле не заповнене!");
            }
            else
            {
                string Student = tb_SecondName.Text + ", " + tb_FirstName.Text + ", " + tb_Grade.Text + ", " + tb_Classroom.Text
                + ", " + tb_Bus.Text;
                string Techer = tb_TLastName.Text + ", " + tb_TFirstName.Text + ", " + tb_Classroom.Text;
                string[] inventoryDataS = File.ReadAllLines("students.txt"); //зчитуємо кожен рядок файлу в масив рядків
                List<string> inventoryDataListS = inventoryDataS.ToList(); //перетворюємо масив у список
                string[] inventoryDataT = File.ReadAllLines("teachers.txt"); //зчитуємо кожен рядок файлу в масив рядків
                List<string> inventoryDataListT = inventoryDataT.ToList(); //перетворюємо масив у список
                if (inventoryDataListS.Remove(Student) && inventoryDataListT.Remove(Techer)) //видаляти рядок, якщо знайдено такий
                {
                    File.WriteAllLines("students.txt", inventoryDataListS.ToArray()); //перезаписуємо файл із рядками зі списку
                    File.WriteAllLines("teachers.txt", inventoryDataListT.ToArray());
                    MessageBox.Show("Успішно видалено!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Збігів не знайдено!");
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