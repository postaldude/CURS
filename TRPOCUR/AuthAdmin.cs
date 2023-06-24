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
    public partial class AuthAdmin : Form
    {

        public bool IsLogin
        {
            get
            {
                bool been = false;

                string AdmLogin = textBox9.Text;

                DataBase _newdatabase = new DataBase();
                DataTable _datatable = new DataTable();
                MySqlDataAdapter _mySqlDataAdaptaer = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Administrators` WHERE `Login` = @AdmLogin", _newdatabase.GetConnection); // Выбираем все записи из таблицы в которых логин = введеному логину

                // меняем на переменные
                _mySqlCommand.Parameters.Add("@AdmLogin", MySqlDbType.VarChar).Value = AdmLogin;

                _mySqlDataAdaptaer.SelectCommand = _mySqlCommand;
                _mySqlDataAdaptaer.Fill(_datatable); // заполняем данные в таблицу

                if (_datatable.Rows.Count > 0)
                {
                    been = true;
                }
                else
                {
                    been = false;
                }
                return been;
            }
        }
        public AuthAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegEmployee form = new RegEmployee();
            this.Hide();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegAdmin form = new RegAdmin();
            this.Hide();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Auth form = new Auth();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdminLogin = textBox9.Text;
            string AdminPass = textBox1.Text;


            DataBase _dataBase = new DataBase();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Administrators` WHERE `Login` = @AdmLogin AND" +
                " `Pass` = @AdmPass", _dataBase.GetConnection); // Выбираем все записи из таблиц где логин = введеному логину и пароль = введеному паролю                                     

            try
            {
                // меняем переменные с @ на переменные
                _mySqlCommand.Parameters.Add("@AdmLogin", MySqlDbType.VarChar).Value = AdminLogin;
                _mySqlCommand.Parameters.Add("@AdmPass", MySqlDbType.VarChar).Value = AdminPass;


                _dataBase.OpenConnection();

                _mySqlDataAdapter.SelectCommand = _mySqlCommand;
                _mySqlDataAdapter.Fill(_dataTable); // заполняем данные в таблицу

                if (_dataTable.Rows.Count > 0) // если зарегистрирован
                {
                    Accounting form = new Accounting();
                    this.Hide();
                    form.Show();

                    User user = new User(AdminLogin);
                }

                else
                {
                    if (IsLogin) // проверка логина
                    {
                        MessageBox.Show("Пароль введен неверно!", "Внимание!");
                    }
                    else
                    {
                        if (MessageBox.Show("Необходимо зарегистрироваться!\nХотите зарегестрироваться?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            RegAdmin form = new RegAdmin();
                            this.Hide();
                            form.Show();
                        }
                    }
                }

            }

            catch
            {
                MessageBox.Show("Ошибка в работе БД!", "Ошибка");

            }
            finally
            {
                _dataBase.CloseConnection();
            }
        }
    }
}
