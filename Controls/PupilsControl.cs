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
    public partial class PupilsControl : UserControl
    {
        private string _userID;
        public PupilsControl(string UserID)
        {
            InitializeComponent();
            _userID = UserID;
            loadDataInTable();
        }

        private void loadDataInTable()
        {
            DataSet ds = DBUtils.ConnectToDB($@"select id_pupil as 'ID',
pupil.surname as 'Фамилия',
pupil.first_name as 'Имя',
pupil.secondname as 'Отчество',
CONCAT(class.number, class.letter) as 'Класс',
pupil.date_birth as 'Дата рождения'
from pupil, class_teacher, class
where id_teacher = fk_class_teacher and id_class=fk_class
and id_teacher ={_userID}");
            tablePupils.DataSource = ds.Tables[0];

            
        }
    }
}
