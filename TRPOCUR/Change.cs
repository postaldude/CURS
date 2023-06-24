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
    public partial class Change : Form
    {
        private List<EmployeesForAccounting> _data = new List<EmployeesForAccounting>(); // список данных;
        private User user;
        public Change()
        {
            InitializeComponent();
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
            dataGridView1.ReadOnly = false; // разрешаем изменять данные


        }

        private void Change_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable(); //создаем шапку
            dataGridView1.Columns[0].ReadOnly = true; // Запрещаем менять id
            user = new User(); // объект класса пользователь, так как в нем переменная статичная, она будет одинакова для всех 
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            // Удаляем текущие строки
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            dataGridView1.RowCount = Convert.ToInt32(numericUpDown_for_data.Value); //считываем с счетчика кол-во строк
            dataGridView1.ReadOnly = false; //разрешаем менять данные

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells[0].ReadOnly = true; // запрещаем менять id
            
        }


        private void AddDataGrid(EmployeesForAccounting row)
        {
            dataGridView1.Rows.Add(row.IdEmployee, row.LastName, row.FirstName, row.MiddleName, row.Gender, row.DateofBirth, row.Education,
                         row.PassportNumber, row.PassportSeries, row.PhoneNumber, row.Email, row.SpecialistGrade, row.JobTitle, row.Address, row.EmploymentDate,
                         row.Wage, row.Login, row.Pass, row.Silent); //добавляем строку в таблицу
                                                                           
        }
            private void button_Choose_Click(object sender, EventArgs e)
        {
            // удаление текущих строк
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            _data.Clear();

            // открываем БД
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

                int i = Convert.ToInt32(numericUpDown_for_Select.Value) - 1; // запоминаем номер элемента который хотим вывести

                if (i >= 0 && i < _data.Count)
                {
                    AddDataGrid(_data[i]);

                }

                else
                {
                    MessageBox.Show("выбран неправильный элемент!", "Ошибка!");
                }
            }

            catch
            {
                MessageBox.Show("Ошибка работы с БД!", "Ошибка!");

            }
            finally 
            {
                _manager.CloseConnection();
            }

        }


        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data.Clear();

            // открываем бд, считываем данные
            DataBase _manager = new DataBase();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Employees` ", _manager.GetConnection);
            MySqlDataReader _reader;

            //Удаляем все строки
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

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
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true; //запрещаем менять id
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы с БД!", "Ошибка!");
            }

            finally           
            {
                _manager.CloseConnection();
            }

        }

        private void выгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase _manager = new DataBase();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();

                    //Проходим по всем строкам
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGridView1.Rows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[4].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[5].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[6].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[7].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[8].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[9].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[10].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[11].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[12].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[13].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[14].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[15].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[16].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[17].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[i].Cells[18].Value) == "" 
                            )
                        {
                            string _commandString = "INSERT INTO `Employees` (`Login`, `Pass`, `LastName`, " +
                        " `FirstName`, `MiddleName`, `Gender`, `DateOfBirth`, `Education`, `PassportNumber`, `PassportSeries`, " +
                        " `PhoneNumber`, `Email`, `SpecialistGrade`, `JobTitle`, `Address`, `EmploymentDate`, `Wage`)" +
                        " VALUES(@Login, @Pass, @LastName, @FirstName, @MiddleName, @Gender, @DateOfBirth, @Education, @PassportNumber, @PassportSeries, " +
                        " @PhoneNumber,@Email,@SpecialistGrade,@JobTitle,@Address,@EmploymentDate,@Wage);";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection); // формируем запрос
                            
                            // меняем заглужки на значения
                            _command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[4].Value;
                            _command.Parameters.Add("@DateOfBirth", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGridView1.Rows[i].Cells[5].Value);
                            _command.Parameters.Add("@Education", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[6].Value;
                            _command.Parameters.Add("@PassportNumber", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGridView1.Rows[i].Cells[7].Value);
                            _command.Parameters.Add("@PassportSeries", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGridView1.Rows[i].Cells[8].Value);
                            _command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[9].Value;
                            _command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[10].Value;
                            _command.Parameters.Add("@SpecialistGrade", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[11].Value;
                            _command.Parameters.Add("@JobTitle", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[12].Value;
                            _command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[13].Value;
                            _command.Parameters.Add("@EmploymentDate", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGridView1.Rows[i].Cells[14].Value);
                            _command.Parameters.Add("@Wage", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGridView1.Rows[i].Cells[15].Value);
                            _command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[16].Value;
                            _command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = this.dataGridView1.Rows[i].Cells[17].Value;

                            // Здесь запрос будет выполнен с сохранением в бд
                            if (_command.ExecuteNonQuery() != 1) // если хотябы один не добавился, cообщим об этом
                            {
                                add = false;
                            }

                        }

                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");

                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с БД!", "Ошибка!");
                }

                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                // меняем данные
                if (Convert.ToString(this.dataGridView1.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[4].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[5].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[6].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[7].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[8].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[9].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[10].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[11].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[12].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[13].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[14].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[15].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[16].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[17].Value) != "" &&
                            Convert.ToString(this.dataGridView1.Rows[0].Cells[18].Value) == "" )

                {
                    string id = Convert.ToString(this.dataGridView1.Rows[0].Cells[0].Value);
                    string lastname = Convert.ToString(this.dataGridView1.Rows[0].Cells[1].Value);
                    string firstname = Convert.ToString(this.dataGridView1.Rows[0].Cells[2].Value);
                    string middlename = Convert.ToString(this.dataGridView1.Rows[0].Cells[3].Value);
                    string gender = Convert.ToString(this.dataGridView1.Rows[0].Cells[4].Value);
                    string dateofbirth = Convert.ToString(this.dataGridView1.Rows[0].Cells[5].Value);
                    string education = Convert.ToString(this.dataGridView1.Rows[0].Cells[6].Value);
                    string passportnumber = Convert.ToString(this.dataGridView1.Rows[0].Cells[7].Value);
                    string passportseries = Convert.ToString(this.dataGridView1.Rows[0].Cells[8].Value);
                    string phonenumber = Convert.ToString(this.dataGridView1.Rows[0].Cells[9].Value);
                    string email = Convert.ToString(this.dataGridView1.Rows[0].Cells[10].Value);
                    string specialistgrade = Convert.ToString(this.dataGridView1.Rows[0].Cells[11].Value);
                    string jobtitle = Convert.ToString(this.dataGridView1.Rows[0].Cells[12].Value);
                    string address = Convert.ToString(this.dataGridView1.Rows[0].Cells[13].Value);
                    string employmentdate = Convert.ToString(this.dataGridView1.Rows[0].Cells[14].Value);
                    string wage = Convert.ToString(this.dataGridView1.Rows[0].Cells[15].Value);
                    string login = Convert.ToString(this.dataGridView1.Rows[0].Cells[16].Value);
                    string pass = Convert.ToString(this.dataGridView1.Rows[0].Cells[17].Value);


                    // открываем бд
                    DataBase _manager = new DataBase();
                    string _commandString = "UPDATE `Employees` SET `IdEmployee` = '" + id + "', " +
                        "`LastName` = '" + lastname + "', " +
                        "`FirstName` = '" + firstname + "', " +
                        "`MiddleName` = '" + middlename + "', " +
                        "`Gender` = '" + gender + "', " +
                        "`DateOfBirth` = '" + dateofbirth + "', " +
                        "`Education` = '" + education + "', " +
                        "`PassportNumber` = '" + passportnumber + "', " +
                        "`PassportSeries` = '" + passportseries + "', " +
                        "`PhoneNumber` = '" + phonenumber + "', " +
                        "`Email` = '" + email + "', " +
                        "`SpecialistGrade` = '" + specialistgrade + "', " +
                        "`JobTitle` = '" + jobtitle + "', " +
                        "`Address` = '" + address + "', " +
                        "`EmploymentDate` = '" + employmentdate + "', " +
                        "`Wage` = '" + wage + "', " +
                        "`Login` = '" + login + "', " +
                        "`Pass` = '" + pass + "' " +
                        " WHERE `Employees`.`IdEmployee` = " + id +";";
                    MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены!", "Внимание!");
                    }

                    catch
                    {
                        MessageBox.Show("Ошибка работы с БД!", "Ошибка!");
                    }

                    finally
                    {
                        _manager.CloseConnection();
                    }

                }
                else
                    MessageBox.Show("Не все поля заполнены!", "Внимание!");
            }
            else
            {
                // открываем бд
                DataBase _manager = new DataBase();
                _manager.OpenConnection();
                bool changed = true;

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    if (Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[4].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[5].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[6].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[7].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[8].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[9].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[10].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[11].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[12].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[13].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[14].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[15].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[16].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[17].Value) != "" &&
                            Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[18].Value) == "" )

                    {
                        string id = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[0].Value);
                        string lastname = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[1].Value);
                        string firstname = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[2].Value);
                        string middlename = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[3].Value);
                        string gender = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[4].Value);
                        string dateofbirth = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[5].Value);
                        string education = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[6].Value);
                        string passportnumber = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[7].Value);
                        string passportseries = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[8].Value);
                        string phonenumber = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[9].Value);
                        string email = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[10].Value);
                        string specialistgrade = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[11].Value);
                        string jobtitle = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[12].Value);
                        string address = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[13].Value);
                        string employmentdate = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[14].Value);
                        string wage = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[15].Value);
                        string login = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[16].Value);
                        string pass = Convert.ToString(this.dataGridView1.SelectedRows[i].Cells[17].Value);


                        string _comanndString = "UPDATE `Employees` SET `IdEmployee` = '" + id + "', " +
                        "`LastName` = '" + lastname + "', " +
                        "`FirstName` = '" + firstname + "', " +
                        "`MiddleName` = '" + middlename + "', " +
                        "`Gender` = '" + gender + "', " +
                        "`DateOfBirth` = '" + dateofbirth + "', " +
                        "`Education` = '" + education + "', " +
                        "`PassportNumber` = '" + passportnumber + "', " +
                        "`PassportSeries` = '" + passportseries + "', " +
                        "`PhoneNumber` = '" + phonenumber + "', " +
                        "`Email` = '" + email + "', " +
                        "`SpecialistGrade` = '" + specialistgrade + "', " +
                        "`JobTitle` = '" + jobtitle + "', " +
                        "`Address` = '" + address + "', " +
                        "`EmploymentDate` = '" + employmentdate + "', " +
                        "`Wage` = '" + wage + "', " +
                        "`Login` = '" + login + "', " +
                        "`Pass` = '" + pass + "' " +
                        " WHERE `Employees`.`IdEmployee` = " + id + ";";
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            if (_command.ExecuteNonQuery() != 1)
                                changed = false;
                        }
                        catch 
                        {
                            MessageBox.Show("Ошибка работы  с БД!", "Ошибка!");
                        }
                    }
                    else
                        MessageBox.Show("не все поля заполнены!", "Внимание!");
                }

                if (changed)
                    MessageBox.Show("Данные изменены!", "Внимание!");
                else
                    MessageBox.Show("Не все данные изменены!", "Внимание!");

                _manager.CloseConnection();
            }
        }

        private void выбранныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранные данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_for_Select.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        // Открываем БД
                        DataBase _manager = new DataBase();
                        string id = Convert.ToString(this.dataGridView1.Rows[0].Cells[0].Value);
                        string _commandString = "DELETE FROM `Employees` WHERE `Employees`.`IdEmployee` = " + id;
                        MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с БД!", "Ошибка!");
                        }
                        finally
                        {
                            _manager.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбран не верный элемент!", "Ошибка!");
                    }

                }
                else
                {
                    // открываем БД
                    DataBase _manager = new DataBase();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string id = Convert.ToString(row.Cells[0].Value);
                        string _commandString = "DELETE FROM `Employees` WHERE `Employees`.`IdEmployee` = " + id;
                        MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                        try
                        {
                            dataGridView1.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с БД!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase _manager = new DataBase();
            MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `Employee`", _manager.GetConnection);

            try
            {
                _manager.OpenConnection();

                //выполняем запрос
                _command.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Внимание!");
            }

            catch
            {
                MessageBox.Show("Ошибка удаления данных!", "Ошибка!");
            }

            finally
            {
                _manager.CloseConnection();
            }
        }

        private void просмотрДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти в окно просмотра данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Accounting form = new Accounting();
                this.Hide();
                form.Show();
            }
        }

        private void регистрацияСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmployee form = new RegEmployee();
            this.Hide();
            form.Show();
        }

        private void регистрацияАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAdmin form = new RegAdmin();
            this.Hide();
            form.Show();
        }
    }
    

}
