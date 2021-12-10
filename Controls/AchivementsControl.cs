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
    public partial class AchivementsControl : UserControl
    {
        private string _UserId;
        public AchivementsControl(string UserId)
        {
            InitializeComponent();
            _UserId = UserId;
            loadDataTable();
        }

        private void loadDataTable()
        {
            
            DataSet ds = DBUtils.ConnectToDB($@"
select id_achievement as 'ID',
    date_achievement as 'Дата достижения',
    place as 'Результат',
    event1 as 'Мероприятие',
    level1 as 'Уровень',
    type_event as 'Тип мероприятия',
    CONCAT(pupil.surname, ' ', pupil.first_name, ' ', pupil.secondname) as 'Участник (учащийся)'
from achievements, pupil, class_teacher, class
where pupil.id_pupil = achievements.fk_pupil 
    and id_teacher=fk_class_teacher and
    id_class = fk_class and 
    id_teacher = {_UserId}");
            tableAchivements.DataSource = ds.Tables[0];

            DataTable tablePupils = DBUtils.LoadList($@"select DISTINCT(CONCAT(pupil.surname, ' ', pupil.first_name, ' ', pupil.secondname)) as 'FIO',
id_pupil
from pupil, class_teacher, class
where id_teacher = fk_class_teacher and id_class=fk_class
and id_teacher = {_UserId}");

            PupilsList.DataSource = tablePupils;
            PupilsList.DisplayMember = "FIO";
            PupilsList.ValueMember = "id_pupil";


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PupilsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pupilFilter.Checked)
            {
                DataSet ds = DBUtils.ConnectToDB($@"
select id_achievement as 'ID',
    date_achievement as 'Дата достижения',
    place as 'Результат',
    event1 as 'Мероприятие',
    level1 as 'Уровень',
    type_event as 'Тип мероприятия',
    CONCAT(pupil.surname, ' ', pupil.first_name, ' ', pupil.secondname) as 'Участник (учащийся)'
from achievements, pupil, class_teacher, class
where pupil.id_pupil = achievements.fk_pupil 
    and id_teacher=fk_class_teacher and
    id_class = fk_class and 
    id_teacher = {_UserId} and
    id_pupil = {PupilsList.SelectedValue}");
                tableAchivements.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAchivement newAchivement = new AddNewAchivement(_UserId);
            newAchivement.ShowDialog();
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDataTable();
        }
    }
}
