using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestProject.Controls
{
    public partial class AchivementsControl : UserControl
    {
        private string _UserId;
        /*
         0 - Участник
         1 - date filter
         2 - 
         */
        private List<string> _restrictions = new List<string>() { "", "", ""};
        private DataSet ds;
        private string select;
        public AchivementsControl(string UserId)
        {
            InitializeComponent();
            _UserId = UserId;
            beginDateFilter.Value = DateTime.Now;
            endDateFilter.Value =  DateTime.Now.AddDays(1);
            loadDataTable();
        }
        private void loadDataTable()
        {
            select = $@"
select id_achievement as 'ID',
    CONCAT(pupil.surname, ' ', pupil.first_name, ' ', pupil.secondname) as 'Участник (учащийся)',
    date_achievement as 'Дата достижения',
    place as 'Результат',
    event1 as 'Мероприятие',
    level1 as 'Уровень',
    type_event as 'Тип мероприятия',    
    address_event as 'Место проведения'
from achievements, pupil, class_teacher, class
where pupil.id_pupil = achievements.fk_pupil 
    and id_teacher=fk_class_teacher and
    id_class = fk_class and 
    id_teacher = {_UserId}";

            ds = DBUtils.ConnectToDB(select);
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
            if (PupilsList.Enabled == true)
            {
                _restrictions[0] = $@"and id_pupil = {PupilsList.SelectedValue.ToString()}";
                filterTable();
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

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($@"Удалить запись под ID = {tableAchivements.SelectedRows[0].Cells[0].Value.ToString()}", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                DBUtils.ExecuteNonQuery($@"delete from achievements where id_achievement = {tableAchivements.SelectedRows[0].Cells[0].Value.ToString()}");
            }
            loadDataTable();
        }

        private void AchivementsControl_VisibleChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (dataSelect.Checked)
            {
                beginDateFilter.Enabled = true;
                endDateFilter.Enabled = true;
                _restrictions[1] = $@"and date_achievement between '{convertToSqlData(beginDateFilter.Value)}' and '{convertToSqlData(endDateFilter.Value)}'";
                filterTable();
            }
            else
            {
                beginDateFilter.Enabled = false;
                endDateFilter.Enabled = false;
                _restrictions[1] = "";
                filterTable();
            }
        }

        private void pupilFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (pupilFilter.Checked)
            {
                PupilsList.Enabled = true;
                if (PupilsList.SelectedValue != null)
                {
                    _restrictions[0] = $" and id_pupil = {PupilsList.SelectedValue.ToString()}";
                    filterTable();
                }
            }
            else
            {
                PupilsList.Enabled = false;
                _restrictions[0] = "";
                filterTable();
            }
        }

        private void filterTable()
        {
            ds = DBUtils.ConnectToDB($@"{select} {_restrictions[0]} {_restrictions[1]};");
            tableAchivements.DataSource = ds.Tables[0];
        }

        private void beginDateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (beginDateFilter.Enabled == true)
            {
                if (beginDateFilter.Value > endDateFilter.Value)
                {
                    MessageBox.Show("Начальная дата больше, чем конечная.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    beginDateFilter.Value = endDateFilter.Value;
                }

                _restrictions[1] = $@"and date_achievement between '{convertToSqlData(beginDateFilter.Value)}' and '{convertToSqlData(endDateFilter.Value)}'";
                filterTable();
            }
        }

        private void endDateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (endDateFilter.Enabled == true)
            {
                if (beginDateFilter.Value > endDateFilter.Value)
                {
                    MessageBox.Show("Начальная дата больше, чем конечная.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    endDateFilter.Value = endDateFilter.Value;
                }
                _restrictions[1] = $@"and date_achievement between '{convertToSqlData(beginDateFilter.Value)}' and '{convertToSqlData(endDateFilter.Value)}'";
                filterTable();
            }
        }





        private string convertToSqlData(DateTime date)
        {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
           
            Classes.ExportToExcel.WriteDataTable(ds.Tables[0], _UserId);
        }
    }
}
