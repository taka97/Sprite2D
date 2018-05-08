using System.Drawing;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class MainForm : Form
    {
        private bool isMove;
        private int dx, dy;

        public MainForm()
        {
            InitializeComponent();
            isMove = false;
        }

        private void spriteControl_KeyDown(object sender, KeyEventArgs e)
        {
            spriteControl.SpriteControl_KeyDown(e.KeyCode);
        }

        private void spriteControl_KeyUp(object sender, KeyEventArgs e)
        {
            spriteControl.SpriteControl_KeyUp(e.KeyCode);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            spriteControl.SpriteControl_KeyDown(e.KeyCode);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            spriteControl.SpriteControl_KeyUp(e.KeyCode);
        }

        private void spriteControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            spriteControl.SpriteControl_KeyDown(e.KeyCode);
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            spriteControl.SpriteControl_KeyDown(e.KeyCode);
        }

        private void spriteControl_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            dx = e.X - spriteControl.GetX();
            dy = e.Y - spriteControl.GetY();
        }

        private void spriteControl_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void cmnuRightClickPause_Click(object sender, System.EventArgs e) => spriteControl.Pause();

        private void cmnuRightClickResume_Click(object sender, System.EventArgs e) => spriteControl.Resume();

        private void cmnuRightClickIncSpeed_Click(object sender, System.EventArgs e) => spriteControl.IncSpeed();

        private void cmnuRightClickDecSpeed_Click(object sender, System.EventArgs e) => spriteControl.DecSpeed();

        private void cmnuRightClickZoomIn_Click(object sender, System.EventArgs e)
        {
            spriteControl.isChange = false;
            spriteControl.ZoomIn();
            spriteControl.isChange = false;
        }

        private void cmnuRightClickZoomOut_Click(object sender, System.EventArgs e)
        {
            spriteControl.isChange = false;
            spriteControl.ZoomOut();
            spriteControl.isChange = false;
        }

        private void cmnuRightClickChangePlayerBomb_Click(object sender, System.EventArgs e)
        {
            spriteControl.setPlayer(Player.Bombman);
        }

        private void cmnuRightClickChangePlayerPirate_Click(object sender, System.EventArgs e)
        {
            spriteControl.setPlayer(Player.Pirate);
        }

        private void cmnuRightClickChangePlayerGirl_Click(object sender, System.EventArgs e)
        {
            spriteControl.setPlayer(Player.Girl);
        }

        private void cmnuRightClickChangePlayerMan_Click(object sender, System.EventArgs e)
        {
            spriteControl.setPlayer(Player.Man);
        }

        private void cmnuRightClickChangePlayerRockman_Click(object sender, System.EventArgs e)
        {
            spriteControl.setPlayer(Player.Rockman);
        }

        private void cmnuRightClickExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void spriteControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                spriteControl.ChangePosition(e.X - dx, e.Y - dy);
            }
        }
    }
}
