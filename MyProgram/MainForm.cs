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

        private void spriteControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMove)
            {
                spriteControl.ChangePosition(e.X - dx, e.Y - dy);
            }
        }
    }
}
