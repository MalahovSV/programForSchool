using MySql.Data.MySqlClient;
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
            using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, connection);
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
            using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, connection);
                dataAdapter.Fill(ds);
                return ds;
            }
        }


        static public void ExecuteNonQuery(string command)
        {
            using(MySqlConnection connection = new MySqlConnection(GetConnectionString()))
            {
                connection.Open();
                MySqlCommand commander = new MySqlCommand();
                commander.CommandText = command;
                commander.Connection = connection;
                commander.ExecuteNonQuery();
            }
        }
    }
}




#region Script create data base MS SQL

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

#region create data base MySQL

/*
 * create database DataBaseSchool;
use DataBaseSchool;
create table role_user(
id_role int primary key auto_increment,
name_role varchar(20));

create table Users(
id_user int primary key auto_increment,
login_user varchar(30) unique,
password_user varchar(30),
FK_role int,
foreign key (FK_role) references role_user(id_role)
on delete set null on update cascade
);

create table class_teacher
(
id_teacher int primary key auto_increment,
surname varchar(20),
first_name varchar(10),
secondname varchar(20),
email varchar (30) unique,
number_phone varchar (17) unique,
fk_user int,
foreign key (fk_user) references users(id_user)
on delete set null on update cascade
);

 create table class
 (
 id_class int primary key auto_increment,
 letter char , 
number tinyint,
fk_class_teacher int,
foreign key (fk_class_teacher) references class_teacher(id_teacher)
 on delete set null on update cascade 
 );

 create table pupil
 (
 id_pupil int primary key auto_increment,
 surname varchar(20),
 first_name varchar(10),
 secondname varchar(20),
 date_birth date,
 fk_class int,
 foreign key (fk_class) references class (id_class)
 on delete set null on update cascade);

 create table achievements
 (
 id_achievement int primary key auto_increment,
 date_achievement date,
 place varchar(15),
 event1 varchar(40),
 level1 varchar(20),
 type_event varchar(20),
 fk_pupil int,
 foreign key(fk_pupil) references pupil(id_pupil)
 on delete set null on update cascade 
 );
 
 
 INSERT INTO `databaseschool`.`role_user` (`name_role`) VALUES ('Администратор');
INSERT INTO `databaseschool`.`role_user` (`name_role`) VALUES ('Учитель');

INSERT INTO `databaseschool`.`users` (`login_user`, `password_user`, `FK_role`) VALUES ('Admin', '1', '1');
INSERT INTO `databaseschool`.`users` (`login_user`, `password_user`, `FK_role`) VALUES ('Сулима', '1', '2');
INSERT INTO `databaseschool`.`users` (`login_user`, `password_user`, `FK_role`) VALUES ('Шахайда', '2', '2');
INSERT INTO `databaseschool`.`users` (`login_user`, `password_user`, `FK_role`) VALUES ('Киясев', '3', '2');

INSERT INTO `databaseschool`.`class_teacher` (`surname`, `first_name`, `secondname`, `email`, `number_phone`, `fk_user`) VALUES ('Сулима', 'Наталья', 'Александровна', 'masd@mail.ru', '+7 912 902-01-02', '2');
INSERT INTO `databaseschool`.`class_teacher` (`surname`, `first_name`, `secondname`, `email`, `number_phone`, `fk_user`) VALUES ('Шахайда', 'Марина', 'Михайловна', 'shah@gmail.com', '+7 982 982-01-02', '3');
INSERT INTO `databaseschool`.`class_teacher` (`surname`, `first_name`, `secondname`, `email`, `number_phone`, `fk_user`) VALUES ('Киясев', 'Сергей', 'Олегович', 'kiyasev@yandex.ru', '+7 938 981-23-53', '4');

INSERT INTO `databaseschool`.`class` (`letter`, `number`, `fk_class_teacher`) VALUES ('а', '9', '4');
INSERT INTO `databaseschool`.`class` (`letter`, `number`, `fk_class_teacher`) VALUES ('б', '8', '5');
INSERT INTO `databaseschool`.`class` (`letter`, `number`, `fk_class_teacher`) VALUES ('в', '7', '6');

INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('1', 'Ивашкин', 'Олег', 'Викторович', '2004-10-10', '7');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('2', 'Иванов', 'Антон', 'Егорович', '2004-11-12', '7');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('3', 'Смирнова', 'Мария', 'Антоновна', '2004-09-19', '7');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('4', 'Пушнова', 'Светлана', 'Ивановна', '2005-01-02', '8');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('5', 'Петрушкин', 'Александр', 'Валерьевич', '2005-06-20', '8');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('6', 'Куряев', 'Антон', 'Святославович', '2005-09-27', '8');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('7', 'Перебойко', 'Петр', 'Константинович', '2006-10-07', '9');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('8', 'Куняев', 'Роман', 'Викторочи', '2006-11-20', '9');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('9', 'Воляев', 'Семён', 'Николаевич', '2006-02-23', '9');
INSERT INTO `databaseschool`.`pupil` (`id_pupil`, `surname`, `first_name`, `secondname`, `date_birth`, `fk_class`) VALUES ('10', 'Артюшкина', 'Анна', 'Александровна', '2006-09-09', '9');


 * 
 * 
*/
#endregion