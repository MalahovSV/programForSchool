using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    static class DBUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
        /// <summary>
        /// Метод для работы с базой данных
        /// </summary>
        /// <param name="command">SQl-комманда для выполнения</param>
        /// <returns>Результат выполнения SQL-команды</returns>
        static public DataSet ConnectToDB(string command)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
                dataAdapter.Fill(ds);
                return ds;
            }
        }
        /// <summary>
        /// Для заполнения combobox
        /// </summary>
        /// <param name="command">Выборка SQL</param>
        /// <returns>Результат выборки</returns>
        static public DataTable LoadList(string command)
        {
            DataTable ds = new DataTable();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
                dataAdapter.Fill(ds);
                return ds;
            }
        }


        static public void ExecuteNonQuery(string command)
        {
            using(SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand commander = new SqlCommand();
                commander.CommandText = command;
                commander.Connection = connection;
                commander.ExecuteNonQuery();
            }
        }
    }
}




#region Script create data base

/*create database DataBaseSchool
GO
use DataBaseSchool
GO
create table role_user(
id_role int primary key identity(1,1),
name_role varchar(20))
GO

create table Users(
id_user int primary key identity(1,1),
login_user varchar(30) unique,
password_user varchar(30),
FK_role int,
foreign key (FK_role) references role_user(id_role)
on delete set null on update cascade
)
GO

create table class_teacher
(
id_teacher int primary key identity (1,1),
surname varchar(20),
first_name varchar(10),
secondname varchar(20),
email varchar (30) unique,
number_phone varchar (17) unique,
fk_user int,
foreign key (fk_user) references users(id_user)
on delete set null on update cascade
) 
GO

 create table class
 (
 id_class int primary key identity (1,1),
 letter char , 
number tinyint,
fk_class_teacher int,
foreign key (fk_class_teacher) references class_teacher(id_teacher)
 on delete set null on update cascade 
 )
 GO

 create table pupil
 (
 id_pupil int primary key identity(1,1),
 surname varchar(20),
 first_name varchar(10),
 secondname varchar(20),
 date_birth date,
 fk_class int,
 foreign key (fk_class) references class (id_class)
 on delete set null on update cascade)

 GO

 create table achievements
 (
 id_achievement int primary key identity (1,1),
 date_achievement date,
 place varchar(15),
 event1 varchar(40),
 level1 varchar(20),
 type_event varchar(20),
 fk_pupil int,
 foreign key(fk_pupil) references pupil(id_pupil)
 on delete set null on update cascade 
 )

 */


#endregion