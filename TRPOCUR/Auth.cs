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
    public partial class Auth : Form
    {

        public bool IsLogin
        {
            get
            {
                bool been = false;

                string Employlogin = textBox9.Text;
                             
                DataBase _newdatabase = new DataBase();
                DataTable _datatable = new DataTable();
                MySqlDataAdapter _mySqlDataAdaptaer = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Employees` WHERE `Login` = @EmpLogin", _newdatabase.GetConnection); // Выбираем все записи из таблицы в которых логин = введеному логину

                // меняем на переменные
                _mySqlCommand.Parameters.Add("@EmpLogin", MySqlDbType.VarChar).Value = Employlogin;
               
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
        public Auth()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string EmpLogin = textBox9.Text;
            string EmpPass = textBox1.Text;


            DataBase _dataBase = new DataBase();
            DataTable _dataTable = new DataTable();
            MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Employees` WHERE `Login` = @EmpLogin AND" +
                " `Pass` = @EmpPass ", _dataBase.GetConnection); // Выбираем все записи из таблиц где логин = введеному логину и пароль = введеному паролю                                     

            try
            {
                // меняем переменные с @ на переменные
                _mySqlCommand.Parameters.Add("@EmpLogin", MySqlDbType.VarChar).Value = EmpLogin;
                _mySqlCommand.Parameters.Add("@EmpPass", MySqlDbType.VarChar).Value = EmpPass;


                _dataBase.OpenConnection();

                _mySqlDataAdapter.SelectCommand = _mySqlCommand;
                _mySqlDataAdapter.Fill(_dataTable); // заполняем данные в таблицу

                if (_dataTable.Rows.Count > 0) // если зарегистрирован
                {
                    Accounting form = new Accounting();
                    this.Hide();
                    form.Show();

                    User user = new User(EmpLogin);
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
                            RegEmployee form = new RegEmployee();
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
