using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
