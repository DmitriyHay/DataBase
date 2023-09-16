using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SchoolSearch
{

    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            //Під час запуску програма перевіряється наявність необхідного файлу "students.txt"
            try
            {
                StreamReader file = new StreamReader("students.txt");
                file.Close();
            }
            catch (Exception e) //За відсутності файлу програма виведе вікно із повідомленням та закриється
            {
                MessageBox.Show(e.Message);
                Close();
            }
        }

        class Student 
        {
            string StLastName; //Прізвище студента
            string StFirstName; //Ім'я студента
            int Grade; //Клас студента
            int Classroom; //Номер класу
            int Bus; //Номер маршруту студента
            string TLastName; //Прізвище викладача
            string TFirstName; //Ім'я викладача

            //Конструктор
            public Student(string SetStLastName, string SetStFirstName, int SetGrade, int SetClassroom,
                int SetBus, string SetTLastName, string SetTFirstName)
            {
                StLastName = SetStLastName;
                StFirstName = SetStFirstName;
                Grade = SetGrade;
                Classroom = SetClassroom;
                Bus = SetBus;
                TLastName = SetTLastName;
                TFirstName = SetTFirstName;
            }

            //Функція, що повертає всю інформацію про студента у форматі string
            public string PrintAllIformationOfStudent()
            {
                string FullInformationOfStudent = "Прізвище студента: " + StLastName + '\r' + '\n' + "Ім'я студента: " + StFirstName + '\r' + '\n' + "Клас: " +
                    Grade + '\r' + '\n' + "Номер класу: " + Classroom + '\r' + '\n' + "Номер маршруту студента: " + Bus + '\r' + '\n' + "Прізвище викладача: " +
                    TLastName + '\r' + '\n' + "Ім'я викладача: " + TFirstName;
                return FullInformationOfStudent;
            }

        }

        private void bt_AllInformationAboutAllStudents_Click(object sender, EventArgs e)
        {
            tb_Result.Clear(); //очищення поля виведення
            tb_Time.Clear(); //очищаємо поля виведення таймера
            Stopwatch clock = new Stopwatch(); //таймер
            string line; //змінна для зчитування файлу рядково
            StreamReader file = new StreamReader("students.txt"); //відкриття файлу
            int numbers = 0; //стільник для кіл-ті результатів
            clock.Start(); //початок робота таймера
            while ((line = file.ReadLine()) != null) //читаємо файл построчно до кінця
            {
                string[] parts = line.Split(','); //дані у файлі розділені комами
                //розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                //створюємо Студента
                Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                    NewTLastName, NewTFirstName);
                //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення.
                tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                numbers++; //додаємо в лічильник +1 результат
            }
            clock.Stop(); //зупинка таймера
            file.Close(); //закриття файлу
            tb_Time.Text = Convert.ToString(clock.Elapsed); //виводимо час роботи
            tb_Numbers.Text = Convert.ToString(numbers); //виводимо кількість результатів пошуку

        }

        private void bt_FirstName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string NameNeed = tb_FirstName.Text;
            tb_FirstName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewStFirstName == NameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade,
                        NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text +
                        NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_SecondName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string NameNeed = tb_SecondName.Text;
            tb_SecondName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewStLastName == NameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Grade_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int GradeNeed = Convert.ToInt32(tb_Grade.Text);
            tb_Grade.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewGrade == GradeNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
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

        private void bt_Classroom_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int ClassroomNeed = Convert.ToInt32(tb_Classroom.Text);
            tb_Classroom.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewClassroom == ClassroomNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void tb_Bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void bt_Bus_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int BusNeed = Convert.ToInt32(tb_Bus.Text);
            tb_Bus.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewBus == BusNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TFirstName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string TFirstNameNeed = tb_TFirstName.Text;
            tb_TFirstName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewTFirstName == TFirstNameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TSecondName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string TSecondNameNeed = tb_TSecondName.Text;
            tb_TSecondName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewTLastName == TSecondNameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Adds_Forms Window_Add = new Adds_Forms(); //створюємо екземпляр форми
            Window_Add.ShowDialog(); //виводимо поверх головного меню
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Delete_Forms Window_Delete = new Delete_Forms();//створюємо екземпляр форми
            Window_Delete.ShowDialog(); //виводимо поверх головного меню
        }

        private void bt_ResetAll_Click(object sender, EventArgs e)
        {
            tb_FirstName.Text = "";
            tb_SecondName.Text = "";
            tb_Grade.Text = "";
            tb_Classroom.Text = "";
            tb_Bus.Text = "";
            tb_TFirstName.Text = "";
            tb_TSecondName.Text = "";
            tb_Numbers.Text = "";
            tb_Time.Text = "";
            tb_Result.Text = "";
        }
    }
}