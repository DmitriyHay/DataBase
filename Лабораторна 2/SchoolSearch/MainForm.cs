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

            //Перевірка наявності файла.
            try
            {
                StreamReader file = new StreamReader("students.txt");
                file.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }

            //Перевірка наявності файла.
            try
            {
                StreamReader file = new StreamReader("teachers.txt");
                file.Close();
            }
            catch (Exception e)
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

            //Функція, що повертає всю інформацію про студента у форматі (string).
            public string PrintAllIformationOfStudent()
            {
                string FullInformationOfStudent = "Прізвище студента: " + StLastName + '\r' + '\n' + "Ім'я студента: " + StFirstName + '\r' + '\n' + "Клас студента: " +
                    Grade + '\r' + '\n' + "Номер класу: " + Classroom + '\r' + '\n' + "Номер маршруту: " + Bus + '\r' + '\n' + "Прізвище викладача: " +
                    TLastName + '\r' + '\n' + "Ім'я викладача: " + TFirstName;
                return FullInformationOfStudent;
            }

        }

        private void bt_AllInformationAboutAllStudents_Click(object sender, EventArgs e)
        {
            tb_Result.Clear(); //Очищення.

            tb_Time.Clear(); //Очищення таймеру.

            Stopwatch clock = new Stopwatch();

            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"

            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.                                        
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення.
                        tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                        numbers++; //Лічильник +1
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_FirstName_Click(object sender, EventArgs e)
        {
            string NameNeed = ' ' + tb_FirstName.Text;
            tb_FirstName.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним. 
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення.

                        if (NewStFirstName == NameNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_SecondName_Click(object sender, EventArgs e)
        {
            string NameNeed = tb_SecondName.Text;
            tb_SecondName.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (NewStLastName == NameNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Grade_Click(object sender, EventArgs e)
        {
            int GradeNeed = Convert.ToInt32(tb_Grade.Text);
            tb_Grade.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (NewGrade == GradeNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
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
            int ClassroomNeed = Convert.ToInt32(tb_Classroom.Text);
            tb_Classroom.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //стетчик для кол-ва результатов
            clock.Start(); //начало работа таймера
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (NewClassroom == ClassroomNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
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
            int BusNeed = Convert.ToInt32(tb_Bus.Text);
            tb_Bus.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (BusNeed == NewBus)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TFirstName_Click(object sender, EventArgs e)
        {
            string TFirstNameNeed = ' ' + tb_TFirstName.Text;
            tb_TFirstName.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (NewTFirstName == TFirstNameNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TSecondName_Click(object sender, EventArgs e)
        {
            string TSecondNameNeed = tb_TSecondName.Text;
            tb_TSecondName.Clear();
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string lineStudents; //Змінна для зчитування файлу "students.txt"
            string lineTeachers; //Змінна для зчитування файлу "teachers.txt"
            StreamReader fileStudents = new StreamReader("students.txt");
            int numbers = 0; //Лічильник результатів.
            clock.Start();
            while (((lineStudents = fileStudents.ReadLine()) != null)) //Зчитування файлу до кінця.
            {
                StreamReader fileTeachers = new StreamReader("teachers.txt");
                string[] parts = lineStudents.Split(',');
                //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = "";
                string NewTFirstName = "";
                bool find = false;
                while (((lineTeachers = fileTeachers.ReadLine()) != null) && !find)
                {
                    string[] partsT = lineTeachers.Split(',');
                    //Розбиваємо рядок на необхідні частини по комах і присвоюємо відповідним змінним.
                    NewTLastName = partsT[0];
                    NewTFirstName = partsT[1];
                    int ClassroomT = Int32.Parse(partsT[2]);
                    if (NewClassroom == ClassroomT)
                    {
                        find = true;
                        Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                            NewTLastName, NewTFirstName);
                        //Виводимо дані про Студента на екран, зберігаючи перед цим попередні виведення

                        if (NewTLastName == TSecondNameNeed)
                        {
                            tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                            numbers++; //Лічильник +1
                        }
                    }
                }
                fileTeachers.Close();
            }
            clock.Stop();
            fileStudents.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Add_Forms Window_Add = new Add_Forms();
            Window_Add.ShowDialog();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Delete_Forms Window_Delete = new Delete_Forms();
            Window_Delete.ShowDialog();
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

        private void tb_Time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}