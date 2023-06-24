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
    public partial class RegEmployee : Form
    {
        private int idKey;

        public RegEmployee()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }


        // Смена картинок
        private void RegEmployee_Shown(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            Auth form = new Auth();
            this.Hide();
            form.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            RegAdmin form = new RegAdmin();
            this.Hide();
            form.Show();
        }
        private bool IsLoginPass // проверка логина и пароля
        {
            get
            {
                bool been = false;
                string loginemployee = LoginBox.Text;
                string passwordemployee = PasswordBox.Text;

                DataBase _dataBase = new DataBase();
                DataTable _dataTable = new DataTable();
                MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Employees` WHERE `Login` = @EmployLogin AND `Pass` = @EmployPass",
                    _dataBase.GetConnection); // выбираем все запси из таблицы где логин = введеному логину и так же пароль

                // меняем на переменные
                _mySqlCommand.Parameters.Add("@EmployLogin", MySqlDbType.VarChar).Value = loginemployee;
                _mySqlCommand.Parameters.Add("@EmployPass", MySqlDbType.VarChar).Value = passwordemployee;

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
       private bool IsEmployee // проверка сотрудника 
        {
            get {
                /*
                 * Проверяем данные которые вводит пользователь на совпадение, кроме пароля.
                 */

                bool been = false;

                string login = LoginBox.Text;
                string FirstName = FirstNameBox.Text;
                string LastName = LastNameBox.Text;
                string MiddleName = MiddleNameBox.Text;
                string Gender = GenderBox.Text;
                string DateBirth = BirthDateBox.Text;
                string Education = EducationBox.Text;
                string NumPass = NumPassBox.Text;
                string PassSeries = PassSeriesBox.Text;
                string PhoneNum = PhoneNumBox.Text;
                string Email = EmailBox.Text;                
                string Charge = ChargeBox.Text;
                string Position = PositionBox.Text;
                string HomeAddress= HomeAddressBox.Text;
                string WorkDate = WorkDateBox.Text;
                string Wage = WageBox.Text;

                DataBase _newdatabase= new DataBase();
                DataTable _datatable = new DataTable();
                MySqlDataAdapter _mySqlDataAdaptaer = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM `Employees` WHERE `Login` = @EmpLogin AND " +
                    " `FirstName` = @EmpFirstName AND `LastName` = @EmpLastName AND `MiddleName` = @EmpMidName AND " +
                    " `Gender` = @EmpGender AND `DateOfBirth` = @EmpDateOfBirth AND `Education` = @EmpEducation AND " +
                    " `PassportNumber` = @EmpNumPass AND `PassportSeries` = @EmpPassSeries AND `PhoneNumber` = @EmpPhoneNumber AND " +
                    " `Email` = @EmpEmail AND `SpecialistGrade` = @EmpSpecialGrade AND `JobTitle` = @EmpJobTitle AND " +
                    " `Address` = @EmpHomeAddress AND `EmploymentDate` = @EmpEmploymentDate AND `Wage` = @EmpWage;" 
                    , _newdatabase.GetConnection); // Выбираем все записи из таблицы

                // Заносим в выборку переменные
                _mySqlCommand.Parameters.Add("@EmpLogin", MySqlDbType.VarChar).Value = login;
                _mySqlCommand.Parameters.Add("@EmpFirstName", MySqlDbType.VarChar).Value = FirstName;
                _mySqlCommand.Parameters.Add("@EmpLastName", MySqlDbType.VarChar).Value = LastName;
                _mySqlCommand.Parameters.Add("@EmpMidName", MySqlDbType.VarChar).Value = MiddleName;
                _mySqlCommand.Parameters.Add("@EmpGender", MySqlDbType.VarChar).Value = Gender;
                _mySqlCommand.Parameters.Add("@EmpDateOfBirth", MySqlDbType.VarChar).Value = Convert.ToString(DateBirth);
                _mySqlCommand.Parameters.Add("@EmpEducation", MySqlDbType.VarChar).Value = Education;
                _mySqlCommand.Parameters.Add("@EmpNumPass", MySqlDbType.VarChar).Value = Convert.ToString(NumPass);
                _mySqlCommand.Parameters.Add("@EmpPassSeries", MySqlDbType.VarChar).Value = Convert.ToString(PassSeries);
                _mySqlCommand.Parameters.Add("@EmpPhoneNumber", MySqlDbType.VarChar).Value = PhoneNum;
                _mySqlCommand.Parameters.Add("@EmpEmail", MySqlDbType.VarChar).Value = Email;
                _mySqlCommand.Parameters.Add("@EmpSpecialGrade", MySqlDbType.VarChar).Value = Charge;
                _mySqlCommand.Parameters.Add("@EmpJobTitle", MySqlDbType.VarChar).Value = Position;
                _mySqlCommand.Parameters.Add("@EmpHomeAddress", MySqlDbType.VarChar).Value = HomeAddress;
                _mySqlCommand.Parameters.Add("@EmpEmploymentDate", MySqlDbType.VarChar).Value = Convert.ToString (WorkDate);
                _mySqlCommand.Parameters.Add("@EmpWage", MySqlDbType.VarChar).Value = Convert.ToString(Wage);

                _mySqlDataAdaptaer.SelectCommand = _mySqlCommand;
                _mySqlDataAdaptaer.Fill(_datatable); // заполняем данные в таблицу

                // проверка на совпадение
                if (_datatable.Rows.Count > 0)
                {
                    been = true;

                    if (MessageBox.Show("Такой сотрудник уже есть в базе!\nПерейти на вкладку входа?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MessageBox.Show("Вы не прошли дополнительную проверку!","Внимание!");
                return;
            }

            if (FirstNameBox.Text == "" || LastNameBox.Text == "" || MiddleNameBox.Text == "" ||
                GenderBox.Text == "" || LoginBox.Text == "" || PasswordBox.Text == "" || BirthDateBox.Text == "" ||
                EducationBox.Text == "" || NumPassBox.Text == "" || PassSeriesBox.Text == "" || PhoneNumBox.Text == "" ||
                EmailBox.Text == "" || ChargeBox.Text == "" || PositionBox.Text == "" || HomeAddressBox.Text == "" ||
                WorkDateBox.Text == "" || WageBox.Text == "")
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

            if (!IsEmployee) // проверка на уникальность всех данных 
            {
                if (!IsLoginPass) // проверка на уникальность логина и пароля
                {
                    DataBase _database = new DataBase();
                    MySqlCommand _mySqlCommand = new MySqlCommand("INSERT INTO `Employees` (`Login`, `Pass`, `LastName`, " +
                        " `FirstName`, `MiddleName`, `Gender`, `DateOfBirth`, `Education`, `PassportNumber`, `PassportSeries`, " +
                        " `PhoneNumber`, `Email`, `SpecialistGrade`, `JobTitle`, `Address`, `EmploymentDate`, `Wage`) " +
                        " VALUES (@Login,@Pass,@LastName,@FirstName,@MiddleName,@Gender,@DateOfBirth,@Education,@PassportNumber,@PassportSeries," +
                        " @PhoneNumber,@Email,@SpecialistGrade,@JobTitle,@Address,@EmploymentDate,@Wage)", _database.GetConnection); // запрос

                    try
                    {
                        // в атрибуты из запроса выше вставляем значения из текстбоксов
                        _mySqlCommand.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginBox.Text;
                        _mySqlCommand.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PasswordBox.Text;
                        _mySqlCommand.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = LastNameBox.Text;
                        _mySqlCommand.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = FirstNameBox.Text;
                        _mySqlCommand.Parameters.Add("@MiddleName", MySqlDbType.VarChar).Value = MiddleNameBox.Text;
                        _mySqlCommand.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = GenderBox.Text;
                        _mySqlCommand.Parameters.Add("@DateOfBirth", MySqlDbType.VarChar).Value = Convert.ToString(BirthDateBox.Text);
                        _mySqlCommand.Parameters.Add("@Education", MySqlDbType.VarChar).Value = EducationBox.Text;
                        _mySqlCommand.Parameters.Add("@PassportNumber", MySqlDbType.VarChar).Value = Convert.ToString( NumPassBox.Text);
                        _mySqlCommand.Parameters.Add("@PassportSeries", MySqlDbType.VarChar).Value = Convert.ToString(PassSeriesBox.Text);
                        _mySqlCommand.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = PhoneNumBox.Text;
                        _mySqlCommand.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailBox.Text;
                        _mySqlCommand.Parameters.Add("@SpecialistGrade", MySqlDbType.VarChar).Value = ChargeBox.Text;
                        _mySqlCommand.Parameters.Add("@JobTitle", MySqlDbType.VarChar).Value = PositionBox.Text;
                        _mySqlCommand.Parameters.Add("@Address", MySqlDbType.VarChar).Value = HomeAddressBox.Text;
                        _mySqlCommand.Parameters.Add("@EmploymentDate", MySqlDbType.VarChar).Value = Convert.ToString(WorkDateBox.Text);
                        _mySqlCommand.Parameters.Add("@Wage", MySqlDbType.VarChar).Value = Convert.ToString(WageBox.Text);

                        // открытие соединения
                        _database.OpenConnection();

                        if (_mySqlCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт создан!", "Внимание!");

                            Accounting form = new Accounting();
                            this.Hide();
                            form.Show();


                            User user = new User(LoginBox.Text);        // Запомним вошедшего
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IdDepartBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
