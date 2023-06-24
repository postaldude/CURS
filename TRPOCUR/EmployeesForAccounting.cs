using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPOCUR
{
    class EmployeesForAccounting
    {
        public object IdEmployee { get; set; }
        public object LastName { get; set; }
        public object FirstName { get; set; }
        public object MiddleName { get; set; }
        public object Gender { get; set; }
        public object DateofBirth { get; set; }
        public object Education { get; set; }
        public object PassportNumber { get; set; }
        public object PassportSeries { get; set; }
        public object PhoneNumber { get; set; }
        public object Email { get; set; }
        public object SpecialistGrade { get; set; }
        public object JobTitle { get; set; }
        public object Address { get; set; }
        public object EmploymentDate { get; set; }
        public object Wage { get; set; }
        public object Login { get; set; }
        public object Pass { get; set; }
        public object Silent { get; set; }

        public EmployeesForAccounting() { }
        public EmployeesForAccounting(object _id, object _lastname, object _firstname, object _middlename, object _gender,
            object _dateofbirth, object _education, object _passportnumber, object _passportseries, object _phonenumber,
            object _email, object _specialistgrade, object _jobtitle, object _address, object _employmentdate, object _wage,
            object _login, object _pass, object _silent)
        {
            IdEmployee = _id;
            LastName = _lastname;
            FirstName = _firstname;
            MiddleName = _middlename;
            Gender = _gender;
            DateofBirth = _dateofbirth;
            Education = _education;
            PassportNumber = _passportnumber;
            PassportSeries = _passportseries;
            PhoneNumber = _phonenumber;
            Email = _email;
            SpecialistGrade = _specialistgrade;
            JobTitle = _jobtitle;
            Address = _address;
            EmploymentDate = _employmentdate;
            Wage = _wage;
            Login = _login;
            Pass = _pass;
            Silent = _silent; 
        }

        public void DataChange(object _id, object _lastname, object _firstname, object _middlename, object _gender,
           object _dateofbirth, object _education, object _passportnumber, object _passportseries, object _phonenumber,
           object _email, object _specialistgrade, object _jobtitle, object _address, object _employmentdate, object _wage,
           object _login, object _pass, object _silent)
        {
            IdEmployee = _id;
            LastName = _lastname;
            FirstName = _firstname;
            MiddleName = _middlename;
            Gender = _gender;
            DateofBirth = _dateofbirth;
            Education = _education;
            PassportNumber = _passportnumber;
            PassportSeries = _passportseries;
            PhoneNumber = _phonenumber;
            Email = _email;
            SpecialistGrade = _specialistgrade;
            JobTitle = _jobtitle;
            Address = _address;
            EmploymentDate = _employmentdate;
            Wage = _wage;
            Login = _login;
            Pass = _pass;
            Silent = _silent;
        }







    }
}
