using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Controls
{
    public partial class AddNewAchivement : Form
    {
        private string _userID;
        public AddNewAchivement(string UserID)
        {
            InitializeComponent();
            _userID = UserID;
            loadData();
        }

        private void loadData()
        {
            dateAchivement.Value = DateTime.Now;
            DataTable tablePupils = DBUtils.LoadList($@"select DISTINCT(CONCAT(pupil.surname, ' ', pupil.first_name, ' ', pupil.secondname)) as 'FIO',
id_pupil
from pupil, class_teacher, class
where id_teacher = fk_class_teacher and id_class=fk_class
and id_teacher = {_userID}");

            PupilsList.DataSource = tablePupils;
            PupilsList.DisplayMember = "FIO";
            PupilsList.ValueMember = "id_pupil";
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if(PupilsList.SelectedValue != null && eventText.Text != "" && levelText.Text != "")
                insertExecute();
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insertExecute()
        {
            MessageBox.Show($@"
insert into achievements values (null,
'{dateAchivement.Value.Date.ToShortDateString()}',
'{placeText.Text}',
'{eventText.Text}',
'{levelText.Text}',
'{typeEventText.Text}',
{PupilsList.SelectedValue},
'{AddressText.Text}' )");
           try
            {
                DBUtils.ExecuteNonQuery($@"
insert into achievements 
values (null,
'{dateAchivement.Value.Date.ToShortDateString()}',
'{placeText.Text}',
'{eventText.Text}',
'{levelText.Text}',
'{typeEventText.Text}',
{PupilsList.SelectedValue},
'{AddressText.Text}' )");

                MessageBox.Show("Запись добавлена", "Успешно", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
