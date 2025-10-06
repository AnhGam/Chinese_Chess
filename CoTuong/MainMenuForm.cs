using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            ModeSelectForm modeForm = new ModeSelectForm();
            modeForm.Show();
            this.Hide();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này sẽ load ván trước (chưa làm).");
        }

        private void setting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở form cài đặt (âm thanh, nước đi, giao diện...)");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
