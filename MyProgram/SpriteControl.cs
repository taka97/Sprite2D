using System;
using System.Drawing;
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

        public Boolean isChange = false;

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
            {
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
            }
            switch (e)
            {
                case Keys.P:        // P: Pause
                    Pause();
                    break;
                case Keys.S:        // S: Resume
                    Resume();
                    break;
                case Keys.B:
                    if (!isChange)
                    {
                        AutoChangeCharacter();
                        isChange = true;
                    }
                    else
                        isChange = false;
                    break;
                case Keys.Oemplus:  // +: Increase Speed
                    IncSpeed();
                    break;
                case Keys.OemMinus: // -: Decrease Speed
                    DecSpeed();
                    break;
                case Keys.Oem4:     // [: Zoom out
                    ZoomOut();
                    break;
                case Keys.Oem6:     // ]: Zoom in
                    ZoomIn();
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

        private void cmnuRightClickChangePlayerMan_Click(object sender, EventArgs e)
        {
            player.setPlayer(Player.Man);
        }

        private void cmnuRightClickChangePlayerRockman_Click(object sender, EventArgs e)
        {
            player.setPlayer(Player.Rockman);
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
            isChange = false;
            ZoomIn();
            isChange = false;
        }

        private void cmnuRightClickZoomOut_Click(object sender, EventArgs e)
        {
            isChange = false;
            ZoomOut();
            isChange = false;
        }

        public void Pause()
        {
            stateGame = StateGame.Pause;
        }

        public void Resume()
        {
            stateGame = StateGame.Idle;
        }

        public void IncSpeed()
        {
            tmrTick.Interval -= 10;
        }

        public void DecSpeed()
        {
            tmrTick.Interval += 10;
        }

        public void ZoomIn()
        {
            if (!isChange)
            {
                if (player.CurScale > 0 && player.CurScale < Sprite2D.maxScale)
                    player.CurScale++;
                isChange = true;
            }
            else
                isChange = false;
        }

        public void ZoomOut()
        {
            if (!isChange)
            {
                if (player.CurScale > 1 && player.CurScale <= Sprite2D.maxScale)
                    player.CurScale--;
                isChange = true;
            }
            else
                isChange = false;
        }

        public void ChangeCharacter(int code)
        {
            player.setPlayer((Player)code);
        }

        public void AutoChangeCharacter()
        {
            int count = Enum.GetNames(typeof(Player)).Length;
            int newPlayer = ((int)player.TypePlayer + 1) % count;
            ChangeCharacter(newPlayer);
        }

        public int GetX()
        {
            return player.X;
        }

        public int GetY()
        {
            return player.Y;
        }

        public void ChangePosition(int x, int y)
        {
            player.X = x;
            player.Y = y;

            Graphics g = CreateGraphics();
            BufferedGraphicsContext doubleBuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = doubleBuffer.Allocate(g, ClientRectangle);
            buffer.Graphics.Clear(Color.White);
            player.drawPlayer(buffer);
            buffer.Render(g);
        }

        public Icon Icon
        {
            get
            {
                switch (player.TypePlayer)
                {
                    case Player.Bombman: return Properties.Resources.icon_bomb;
                    case Player.Pirate: return Properties.Resources.icon_pirate;
                    case Player.Girl: return Properties.Resources.icon_girl;
                    case Player.Man: return Properties.Resources.icon_man;
                    case Player.Rockman: return Properties.Resources.icon_rockman;
                    default: return null;
                }
            }
        }

        public void setPlayer(Player _player)
        {
            player.setPlayer(_player);
        }
    }
}
