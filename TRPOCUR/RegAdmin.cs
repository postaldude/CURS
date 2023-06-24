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
    public partial class RegAdmin : Form
    {
        private int idKey;

        public RegAdmin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Auth form = new Auth();
            this.Hide();
            form.Show();
        }
        private void label22_Click(object sender, EventArgs e)
        {
            RegEmployee form = new RegEmployee();
            this.Hide();
            form.Show();
        }

        private void RegAdmin_Shown(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            Random rand = new Random();
            int random = rand.Next(1, 6);
            string way;
            switch (random)
            {
                case 1:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\first.png";
                    idKey = random;
                    break;

                case 2:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\second.png";
                    idKey = random;
                    break;

                case 3:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\third.png";
                    idKey = random;
                    break;

                case 4:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\four.png";
                    idKey = random;
                    break;

                case 5:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\five.png";
                    idKey = random;
                    break;

                case 6:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\six.png";
                    idKey = random;
                    break;

                default:
                    way = "C:\\Users\\Papa\\Desktop\\TRPOCUR\\TRPOCUR\\Resources\\first.png";
                    idKey = 1;
                    break;
            }
            pictureBox2.Image = Image.FromFile(way);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Generate();

        }

        private bool IsLoginPass // проверка логина и пароля
        {
            get
            {
                bool been = false;
                string loginadmin = Login.Text;
                string passwordadmin = Password.Text;

                DataBase _dataBase = new DataBase();
                DataTable _dataTable = new DataTable();
                MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Administrators` WHERE `Login` = @AdminLogin AND `Pass` = @AdminPass",
                    _dataBase.GetConnection); // выбираем все запси из таблицы где логин = введеному логину и так же пароль

                // меняем на переменные
                _mySqlCommand.Parameters.Add("@AdminLogin", MySqlDbType.VarChar).Value = loginadmin;
                _mySqlCommand.Parameters.Add("@AdminPass", MySqlDbType.VarChar).Value = passwordadmin;

                _mySqlDataAdapter.SelectCommand = _mySqlCommand; // выбираем комманду
                _mySqlDataAdapter.Fill(_dataTable); // заполняем данные в таблицу

                if (_dataTable.Rows.Count > 0)
                {
                    been = true;
                    MessageBox.Show("Введеные логин и пароль уже есть!", "Внимание!");
                }
                else
                    been = false;
                return been;
            }
        }
        private bool IsAdmin // проверка Администратора 
        {
            get
            {
                /*
                 * Проверяем данные которые вводит пользователь на совпадение, кроме пароля.
                 */

                bool been = false;

                string login = Login.Text;
                string FName = FirstName.Text;
                string LName = LastName.Text;
                string MName = MidName.Text;
                string RegistrDay = RegDay.Text;
                string JobPowers = Credentials.Text;
                string Iddepartment = IdDepart.Text;
              

                DataBase _newdatabase = new DataBase();
                DataTable _datatable = new DataTable();
                MySqlDataAdapter _mySqlDataAdaptaer = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Administrators` WHERE `Login` = @AdmLogin AND " +
                    " `FirstName` = @AdmFname AND `LastName` = @AdmLname AND `MiddleName` = @AdmMidName AND " +
                    " `RegistrationdDate` = @AdmRegDay AND `JobPowers` = @AdmJobPow AND `IdDepartment` = @AdmIdDepart", _newdatabase.GetConnection); // Выбираем все записи из таблицы

                // Заносим в выборку переменные
                _mySqlCommand.Parameters.Add("@AdmLogin", MySqlDbType.VarChar).Value = login;
                _mySqlCommand.Parameters.Add("@AdmFname", MySqlDbType.VarChar).Value = FName;
                _mySqlCommand.Parameters.Add("@AdmLname", MySqlDbType.VarChar).Value = LName;
                _mySqlCommand.Parameters.Add("@AdmMidName", MySqlDbType.VarChar).Value = MName;
                _mySqlCommand.Parameters.Add("@AdmRegDay", MySqlDbType.Date).Value = RegistrDay;
                _mySqlCommand.Parameters.Add("@AdmJobPow", MySqlDbType.VarChar).Value = JobPowers;
                _mySqlCommand.Parameters.Add("@AdmIdDepart", MySqlDbType.Int32).Value = Iddepartment;      


                _mySqlDataAdaptaer.SelectCommand = _mySqlCommand;
                _mySqlDataAdaptaer.Fill(_datatable); // заполняем данные в таблицу

                // проверка на совпадение
                if (_datatable.Rows.Count > 0)
                {
                    been = true;

                    if (MessageBox.Show("Такой Администратор уже есть в базе!\nПерейти на вкладку входа?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Auth form = new Auth();
                        this.Hide();
                        form.Show();
                    }
                }
                else been = false;
                return been;

            }

        }


        private void button1_Click(object sender, EventArgs e) // кнопка регистрации
        {
            // Проверки на ввод полей 
            if ((textBox_Key.Text == "") || checkBox1.Checked == false)
            {
                MessageBox.Show("Вы не прошли дополнительную проверку!", "Внимание!");
                return;
            }

            if (FirstName.Text == "" || LastName.Text == "" || MidName.Text == "" ||
                RegDay.Text == "" || Login.Text == "" || Credentials.Text == "" || Password.Text == "" ||
                IdDepart.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                return;
            }

            //Проверка ввода кода с картинки
            switch (idKey)
            {
                case 1:
                    if (textBox_Key.Text != "ACD256")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                case 2:
                    if (textBox_Key.Text != "027WZ")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                case 3:
                    if (textBox_Key.Text != "DD849")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                case 4:
                    if (textBox_Key.Text != "GNOS33")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                case 5:
                    if (textBox_Key.Text != "55CTK")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                case 6:
                    if (textBox_Key.Text != "LFI88")
                    {
                        MessageBox.Show("Неверный код c картинки!", "Внимание!");
                        return;
                    }
                    break;

                default:
                    return;
            }

            if (!IsAdmin) // проверка на уникальность всех данных 
            {
                if (!IsLoginPass) // проверка на уникальность логина и пароля 
                {
                    DataBase _database = new DataBase();
                    MySqlCommand _mySqlCommand = new MySqlCommand("INSERT INTO `Administrators` (`Login`, `Pass`, `LastName`, " +
                        " `FirstName`, `MiddleName`, `RegistrationDate`, `JobPowers`, `IdDepartment`) " +
                        " VALUES (@Login,@Pass,@LastName,@FirstName,@MiddleName,@RegistrationDate,@JobPowers,@IdDepartment)", _database.GetConnection); // запрос

                    try
                    {
                        // в атрибуты из запроса выше вставляем значения из текстбоксов
                        _mySqlCommand.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login.Text;
                        _mySqlCommand.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = Password.Text;
                        _mySqlCommand.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = LastName.Text;
                        _mySqlCommand.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = FirstName.Text;
                        _mySqlCommand.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = MidName.Text;
                        _mySqlCommand.Parameters.Add("@RegistrationDate", MySqlDbType.Date).Value = RegDay.Text;
                        _mySqlCommand.Parameters.Add("@JobPowers", MySqlDbType.VarChar).Value = Credentials.Text;
                        _mySqlCommand.Parameters.Add("@IdDepartment", MySqlDbType.Int32).Value = IdDepart.Text;

                                            
                        // открытие соединения
                        _database.OpenConnection();

                        if (_mySqlCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт создан!", "Внимание!");

                            Accounting form = new Accounting();
                            this.Hide();
                            form.Show();


                            User user = new User(Login.Text);        // Запомним вошедшего
                        }

                        else
                            MessageBox.Show("Не удалось создать аккаунт!", "Ошибка!");
                    }

                    catch
                    {
                        MessageBox.Show("Непредвиденная ошибка в БД!", "Ошибка!");
                    }

                    finally

                    {
                        _database.CloseConnection(); // закрытие соединения с бд

                    }
                }
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
