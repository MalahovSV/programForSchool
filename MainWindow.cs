using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class MainWindow : Form
    {
        private string _userID;
        public MainWindow(string ID_user)
        {
            InitializeComponent();
            _userID = ID_user;
            loadControls();

            
        }

        private List<UserControl> _controls = new List<UserControl>();

        private void loadControls()
        {
            _controls.Add(new Controls.AchivementsControl(_userID));
            _controls.Add(new Controls.PupilsControl(_userID));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(_controls[0]);
            _controls[0].Dock = DockStyle.Fill;
        }

        private void Pupils_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(_controls[1]);
            _controls[1].Dock = DockStyle.Fill;
        }
    }
}
