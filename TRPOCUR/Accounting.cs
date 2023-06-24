using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOCUR
{
    public partial class Accounting : Form
    {
        private User user;
        public Accounting()
        {
            InitializeComponent();
        }

        private void обновитДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<EmployeesForAccounting> _data = new List<EmployeesForAccounting>(); // список данных

            // Открываем бд и считываем с нее данные 
            DataBase _manager = new DataBase();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Employees` ", _manager.GetConnection);
            MySqlDataReader _reader;

            _manager.OpenConnection();
            _reader = _command.ExecuteReader();

            try
            {       
                while (_reader.Read())
                {
                    // заполняем данные
                    EmployeesForAccounting row = new EmployeesForAccounting(_reader["IdEmployee"], _reader["LastName"], _reader["FirstName"], _reader["MiddleName"],
                        _reader["Gender"], _reader["DateOfBirth"], _reader["Education"], _reader["PassportNumber"], _reader["PassportSeries"], _reader["PhoneNumber"],
                        _reader["Email"], _reader["SpecialistGrade"], _reader["JobTitle"], _reader["Address"], _reader["EmploymentDate"], _reader["Wage"],
                        _reader["Login"], _reader["Pass"], _reader["Silent"]);
                    _data.Add(row);
                }

                // добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
                }
                MessageBox.Show("Данные были обновлены!", "Внимание!");
            }
            catch
            {
                MessageBox.Show("Ошибка работы БД!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }
        private void HeaderOfTheTable()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "ID"; // текст в шапке
            column1.Width = 25;
            column1.Name = "IdEmployee";
            column1.Frozen = true; // чтоб колонка всегда отображаласть на месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); // тип колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Фамилия"; 
            column2.Width = 100;
            column2.Name = "LastName";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Имя";
            column3.Width = 100;
            column3.Name = "FirtsName";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Отчество";
            column4.Width = 100;
            column4.Name = "MiddleName";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Пол";
            column5.Width = 25;
            column5.Name = "Gender";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Дата рождения";
            column6.Width = 100;
            column6.Name = "DateOfBirth";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Образование";
            column7.Width = 60;
            column7.Name = "Education";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Номер пасспорта";
            column8.Width = 65;
            column8.Name = "PassportNumber";
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Серия пасспорта";
            column9.Width = 65;
            column9.Name = "PassportSeries";
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Номер телефона";
            column10.Width = 100;
            column10.Name = "PhoneNumber";
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Email";
            column11.Width = 100;
            column11.Name = "Email";
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Разряд";
            column12.Width = 80;
            column12.Name = "SpecialistGrade";
            column12.CellTemplate = new DataGridViewTextBoxCell();

            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Должность";
            column13.Width = 100;
            column13.Name = "JobTitle";
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Домашний адрес";
            column14.Width = 100;
            column14.Name = "Address";
            column14.CellTemplate = new DataGridViewTextBoxCell();

            var column15 = new DataGridViewColumn();
            column15.HeaderText = "Дата найма";
            column15.Width = 100;
            column15.Name = "EmploymentDate";
            column15.CellTemplate = new DataGridViewTextBoxCell();

            var column16 = new DataGridViewColumn();
            column16.HeaderText = "Зарплата";
            column16.Width = 100;
            column16.Name = "Wage";
            column16.CellTemplate = new DataGridViewTextBoxCell();

            var column17 = new DataGridViewColumn();
            column17.HeaderText = "Логин";
            column17.Width = 100;
            column17.Name = "Login";
            column17.CellTemplate = new DataGridViewTextBoxCell();


            var column18 = new DataGridViewColumn();
            column18.HeaderText = "Пароль";
            column18.Width = 100;
            column18.Name = "Pass";
            column18.CellTemplate = new DataGridViewTextBoxCell();

            var column19 = new DataGridViewColumn();
            column19.HeaderText = "Silent";
            column19.Width = 25;
            column19.Name = "Silent";
            column19.CellTemplate = new DataGridViewTextBoxCell();


            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);
            dataGridView1.Columns.Add(column8);
            dataGridView1.Columns.Add(column9);
            dataGridView1.Columns.Add(column10);
            dataGridView1.Columns.Add(column11);
            dataGridView1.Columns.Add(column12);
            dataGridView1.Columns.Add(column13);
            dataGridView1.Columns.Add(column14);
            dataGridView1.Columns.Add(column15);
            dataGridView1.Columns.Add(column16);
            dataGridView1.Columns.Add(column17);
            dataGridView1.Columns.Add(column18);
            dataGridView1.Columns.Add(column19);



            dataGridView1.AllowUserToAddRows = false; // запрещаем сотруднику добавлять строки
            dataGridView1.ReadOnly = true; // запрещаем изменять данные

        }

        // добавление данных в таблицу
        private void AddDataGrid(EmployeesForAccounting row)
        {
            dataGridView1.Rows.Add(row.IdEmployee, row.LastName, row.FirstName, row.MiddleName, row.Gender, row.DateofBirth, row.Education,
                row.PassportNumber, row.PassportSeries, row.PhoneNumber, row.Email, row.SpecialistGrade, row.JobTitle, row.Address,
                row.EmploymentDate, row.Wage, row.Login, row.Pass, row.Silent); //добавляем строку в таблицу
        }
        private void Accounting_Shown(object sender, EventArgs e)
        {
            user = new User();

            HeaderOfTheTable(); // шапка таблицы
            

            List<EmployeesForAccounting> _data = new List<EmployeesForAccounting>(); // список данных

            // Открываем бд и считываем с нее данные 
            DataBase _manager = new DataBase();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Employees` ", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    // заполняем данные
                    EmployeesForAccounting row = new EmployeesForAccounting(_reader["IdEmployee"], _reader["LastName"], _reader["FirstName"], _reader["MiddleName"],
                        _reader["Gender"], _reader["DateOfBirth"], _reader["Education"], _reader["PassportNumber"], _reader["PassportSeries"], _reader["PhoneNumber"],
                        _reader["Email"], _reader["SpecialistGrade"], _reader["JobTitle"], _reader["Address"], _reader["EmploymentDate"], _reader["Wage"],
                        _reader["Login"], _reader["Pass"], _reader["Silent"]);
                    _data.Add(row);
                }

                // добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы БД!", "Ошибка!");
            }
            finally 
            {
                _manager.CloseConnection();
            }
        }



        private void регистрацияСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmployee form = new RegEmployee();
            this.Hide();
            form.Show();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void регистрацияАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAdmin form = new RegAdmin();
            this.Hide();
            form.Show();
        }

        private void входСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth form = new Auth();
            this.Hide();
            form.Show();
        }

        private void входАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthAdmin form = new AuthAdmin();
            this.Hide();
            form.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Перейти к окну редактирования данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Change form = new Change();
                    this.Hide();
                    form.Show();
                }
           

         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
