using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class SpriteControl : UserControl
    {
        private enum StateGame
        {
            Idle, Pause
        }

        private StateGame stateGame;

        private Sprite2D player;

        public SpriteControl()
        {
            InitializeComponent();
            player = new Sprite2D();
            stateGame = StateGame.Idle;
            tmrTick.Enabled = true;
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            BufferedGraphicsContext doubleBuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = doubleBuffer.Allocate(g, ClientRectangle);
            buffer.Graphics.Clear(Color.White);
            player.movePlayer(buffer);
            buffer.Render(g);
        }

        public void SpriteControl_KeyUp(Keys e)
        {
            if (stateGame == StateGame.Idle)
                player.Action = StateAction.Standing;
        }

        public void SpriteControl_KeyDown(Keys e)
        {
            if (stateGame == StateGame.Idle)
                switch (e)
                {
                    case Keys.Up:       // Up Arrow
                        player.Action = StateAction.Walking;
                        player.Direction = StateAction.Up;
                        break;
                    case Keys.Down:     // Down Arrow
                        player.Action = StateAction.Walking;
                        player.Direction = StateAction.Down;
                        break;
                    case Keys.Left:     // Left Arrow
                        player.Action = StateAction.Walking;
                        player.Direction = StateAction.Left;
                        break;
                    case Keys.Right:    // Right Arrow
                        player.Action = StateAction.Walking;
                        player.Direction = StateAction.Right;
                        break;
                    default:
                        break;
                }
            else  //state game = Pause
                switch(e)
                {
                    case Keys.P:        // P: Pause
                        Pause();
                        break;
                    case Keys.S:        // S: Resume
                        Resume();
                        break;
                    case Keys.Oemplus:  // +: Increase Speed
                        IncSpeed();
                        break;
                    case Keys.OemMinus: // -: Decrease Speed
                        DecSpeed();
                        break;

                    case Keys.Escape:   // Esc
                        Application.Exit();
                        break;
                    default:
                        break;
                }
        }

        private void cmnuRightClickChangePlayerBomb_Click(object sender, EventArgs e)
        {
            player.setPlayer(Player.Bombman);
        }

        private void cmnuRightClickChangePlayerPirate_Click(object sender, EventArgs e)
        {
            player.setPlayer(Player.Pirate);
        }

        private void cmnuRightClickChangePlayerGirl_Click(object sender, EventArgs e)
        {
            player.setPlayer(Player.Girl);
        }

        private void cmnuRightClickExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmnuRightClickPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void cmnuRightClickResume_Click(object sender, EventArgs e)
        {
            Resume();
        }

        private void cmnuRightClickIncSpeed_Click(object sender, EventArgs e)
        {
            IncSpeed();
        }

        private void cmnuRightClickDecSpeed_Click(object sender, EventArgs e)
        {
            DecSpeed();
        }

        private void cmnuRightClickZoomIn_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void cmnuRightClickZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void Pause()
        {
            stateGame = StateGame.Pause;
        }

        private void Resume()
        {
            stateGame = StateGame.Idle;
        }

        private void IncSpeed()
        {
            tmrTick.Interval -= 10;
        }

        private void DecSpeed()
        {
            tmrTick.Interval += 10;
        }

        private void ZoomIn()
        {
            if (player.CurScale > 0 && player.CurScale < Sprite2D.maxScale)
                player.CurScale++;
        }

        private void ZoomOut()
        {
            if (player.CurScale > 1 && player.CurScale < Sprite2D.maxScale)
                player.CurScale--;
        }
    }
}
