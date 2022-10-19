using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTPProje
{
    public partial class GirisBasarili : Form
    {
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void GirisBasarili_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void GirisBasarili_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void GirisBasarili_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
