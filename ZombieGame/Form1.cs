using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ZombieGame
{
    public partial class MainGame : Form
    {
        ImageSprite player;
        ImageSprite zombie;
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            PointF StartPosition = new PointF(100, 100);
            player = new ImageSprite((0, StartPosition, Properties.Resources.hero));
            StartPosition = new PointF(600, 300);
            zombie = new ImageSprite(0, StartPosition, Properties.Resources.zombie);

        }
    }
}
