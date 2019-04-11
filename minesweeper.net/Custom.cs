using System;
using System.Drawing;
using System.Windows.Forms;

namespace minesweeper.net
{
    public partial class Custom : Form
    {
        public Point localLocation;

        public Custom()
        {
            InitializeComponent();
        }
        
        private void Custom_Load(object sender, EventArgs e)
        {
            Location = localLocation;
            HeightBox.Text = Properties.Settings.Default.StartSize.Height.ToString();
            WidthBox.Text = Properties.Settings.Default.StartSize.Width.ToString();
            MinesBox.Text = Properties.Settings.Default.StartMines.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxMines;
            Size size = new Size(8, 8);
            try
            {
                Properties.Settings.Default.StartMines = Convert.ToInt32(MinesBox.Text);
            }
            catch
            {
                Properties.Settings.Default.StartMines = 10;
            }
            try
            {
                size = new Size(size.Width, Convert.ToInt32(HeightBox.Text));
            }
            catch
            {
                size = new Size(size.Width, 8);
            }
            try
            {
                size = new Size(Convert.ToInt32(WidthBox.Text), size.Height);
            }
            catch
            {
                size = new Size(8, size.Height);
            }
            if (Properties.Settings.Default.StartMines < 10)
            {
                Properties.Settings.Default.StartMines = 10;
            }
            if (size.Height < 8)
            {
                size = new Size(size.Width, 8);
            }
            if (size.Width < 8)
            {
                size = new Size(8, size.Height);
            }
            if (size.Height > 24)
            {
                size = new Size(size.Width, 24);
            }
            if (size.Width > 30)
            {
                size = new Size(30, size.Height);
            }
            maxMines = (size.Height - 1) * (size.Width - 1);
            if (Properties.Settings.Default.StartMines > maxMines)
            {
                Properties.Settings.Default.StartMines = maxMines;
            }
            Properties.Settings.Default.StartSize = size;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
