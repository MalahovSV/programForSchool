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
        private AuthorizationWindow _authorizationWindow;
        public MainWindow(string ID_user, AuthorizationWindow aw)
        {
            InitializeComponent();
            _userID = ID_user;
            _authorizationWindow = aw;
            aw.Hide();
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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вернуться к авторизации?\n", "Завершение работы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                _authorizationWindow.Close();
            }
            else if (result == DialogResult.Yes)
            {
                _authorizationWindow.Show();
            }
            else
                e.Cancel = true;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
