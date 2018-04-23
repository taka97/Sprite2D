using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public enum StateAction
    {
        Down, Left, Right, Up,
        Standing, Walking
    }

    public enum Player
    {
        Bombman, Pirate, Girl, Man, Rockman
    }

    public class Sprite2D
    {
        static public int maxScale = 3;
        // Vị trí ban đàu của nhân vật
        private int x;
        private int y;

        // Độ thay đổi của nhân vật so với vị trí ban đầu
        private int dx;
        private int dy;

        // width x height của frame góc
        private int width;
        private int height;

        // index của frame trong ảnh gốc
        private int indexColumn;
        private int indexRow;

        // scale của nhân vật
        private int defaultScale;
        private int curScale;

        private StateAction direction;
        private StateAction action;

        // nguồn của ảnh
        private Bitmap bm;
        private int maxFramePerRow;
        Player typePlayer;

        public StateAction Direction { get => direction; set => direction = value; }
        public StateAction Action { get => action; set => action = value; }
        public int CurScale { get => curScale; set => curScale = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Player TypePlayer { get => typePlayer;}

        public Sprite2D()
        {
            x = 10;
            y = 5;
            dx = dy = 0;
            indexColumn = indexRow = 0;
            direction = StateAction.Down;
            action = StateAction.Standing;
            setPlayer(typePlayer);
        }

        public Sprite2D(Player playerType)
        {
            x = 10;
            y = 5;
            dx = dy = 0;
            indexColumn = indexRow = 0;
            direction = StateAction.Down;
            action = StateAction.Standing;
            setPlayer(playerType);
        }

        public void setPlayer(Player player)
        {
            switch (player)
            {
                case Player.Bombman:
                    {
                        width = 66;
                        height = 76;
                        defaultScale = 1;
                        curScale = 1;
                        bm = new Bitmap(Properties.Resources.bombman);
                        maxFramePerRow = 5;
                        typePlayer = Player.Bombman;
                        break;
                    }
                case Player.Pirate:
                    {
                        width = 56;
                        height = 67;
                        defaultScale = 1;
                        curScale = 1;
                        bm = new Bitmap(Properties.Resources.pirate);
                        maxFramePerRow = 5;
                        typePlayer = Player.Pirate;
                        break;
                    }
                case Player.Girl:
                    {
                        width = 32;
                        height = 48;
                        defaultScale = 2;
                        curScale = 1;
                        bm = new Bitmap(Properties.Resources.girl);
                        maxFramePerRow = 4;
                        typePlayer = Player.Girl;
                        break;
                    }
                case Player.Man:
                    width = 128;
                    height = 128;
                    defaultScale = 1;
                    curScale = 1;
                    bm = new Bitmap(Properties.Resources.man);
                    maxFramePerRow = 4;
                    typePlayer = Player.Man;
                    break;
                case Player.Rockman:
                    width = 50;
                    height = 100;
                    defaultScale = 1;
                    curScale = 1;
                    bm = new Bitmap(Properties.Resources.rockman);
                    maxFramePerRow = 5;
                    typePlayer = Player.Rockman;
                    break;
                default:
                    break;
            }
        }

        public void drawPlayer(BufferedGraphics buffer)
        {
            int scale = defaultScale * curScale;
            Rectangle player = new Rectangle(indexColumn * width, indexRow * height, width, height);
            Rectangle size_player = new Rectangle(x, y, width * scale, height * scale);
            buffer.Graphics.DrawImage(bm, size_player, player, GraphicsUnit.Pixel);
            x += dx;
            y += dy;
        }

        public void movePlayer(BufferedGraphics buffer)
        {
            switch (action)
            {
                case StateAction.Standing:
                    {
                        dx = 0;
                        dy = 0;
                        indexColumn = 0;
                        indexRow = (int)direction;
                        break;
                    }
                case StateAction.Walking:
                    {
                        indexRow = (int)direction;
                        switch (direction)
                        {
                            case StateAction.Down:
                                {
                                    dx = 0;
                                    dy = 10;
                                    if (indexColumn >= 0 && indexColumn < maxFramePerRow - 1)
                                        indexColumn++;
                                    else
                                    {
                                        indexColumn = 0;
                                        direction = StateAction.Down;
                                    }
                                    break;
                                }
                            case StateAction.Left:
                                {
                                    dx = -10;
                                    dy = 0;
                                    if (indexColumn >= 0 && indexColumn < maxFramePerRow - 1)
                                        indexColumn++;
                                    else
                                    {
                                        indexColumn = 0;
                                        direction = StateAction.Left;
                                    }
                                    break;
                                }
                            case StateAction.Right:
                                {
                                    dx = 10;
                                    dy = 0;
                                    if (indexColumn >= 0 && indexColumn < maxFramePerRow - 1)
                                        indexColumn++;
                                    else
                                    {
                                        indexColumn = 0;
                                        direction = StateAction.Right;
                                    }
                                    break;
                                }
                            case StateAction.Up:
                                {
                                    dx = 0;
                                    dy = -10;
                                    if (indexColumn >= 0 && indexColumn < maxFramePerRow - 1)
                                        indexColumn++;
                                    else
                                    {
                                        indexColumn = 0;
                                        direction = StateAction.Up;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }
            drawPlayer(buffer);
        }
    }
}
