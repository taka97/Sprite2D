namespace MyProgram
{
    partial class SpriteControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.cmnuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuRightClickPause = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickResume = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuRightClickIncSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickDecSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuRightClickChangePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickChangePlayerBomb = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickChangePlayerPirate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickChangePlayerGirl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickChangePlayerMan = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClickChangePlayerRockman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuRightClickExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // cmnuRightClick
            // 
            this.cmnuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuRightClickPause,
            this.cmnuRightClickResume,
            this.toolStripSeparator1,
            this.cmnuRightClickIncSpeed,
            this.cmnuRightClickDecSpeed,
            this.cmnuRightClickZoomIn,
            this.cmnuRightClickZoomOut,
            this.toolStripSeparator2,
            this.cmnuRightClickChangePlayer,
            this.toolStripSeparator3,
            this.cmnuRightClickExit});
            this.cmnuRightClick.Name = "cmnuRightClick";
            this.cmnuRightClick.Size = new System.Drawing.Size(185, 220);
            // 
            // cmnuRightClickPause
            // 
            this.cmnuRightClickPause.Image = global::MyProgram.Properties.Resources.img_pause;
            this.cmnuRightClickPause.Name = "cmnuRightClickPause";
            this.cmnuRightClickPause.ShortcutKeyDisplayString = "P";
            this.cmnuRightClickPause.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickPause.Text = "&Pause";
            this.cmnuRightClickPause.Click += new System.EventHandler(this.cmnuRightClickPause_Click);
            // 
            // cmnuRightClickResume
            // 
            this.cmnuRightClickResume.Image = global::MyProgram.Properties.Resources.img_resume;
            this.cmnuRightClickResume.Name = "cmnuRightClickResume";
            this.cmnuRightClickResume.ShortcutKeyDisplayString = "S";
            this.cmnuRightClickResume.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickResume.Text = "Re&sume";
            this.cmnuRightClickResume.Click += new System.EventHandler(this.cmnuRightClickResume_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // cmnuRightClickIncSpeed
            // 
            this.cmnuRightClickIncSpeed.Image = global::MyProgram.Properties.Resources.img_forward;
            this.cmnuRightClickIncSpeed.Name = "cmnuRightClickIncSpeed";
            this.cmnuRightClickIncSpeed.ShortcutKeyDisplayString = "+";
            this.cmnuRightClickIncSpeed.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickIncSpeed.Text = "&Increase Speed";
            this.cmnuRightClickIncSpeed.Click += new System.EventHandler(this.cmnuRightClickIncSpeed_Click);
            // 
            // cmnuRightClickDecSpeed
            // 
            this.cmnuRightClickDecSpeed.Image = global::MyProgram.Properties.Resources.img_backward;
            this.cmnuRightClickDecSpeed.Name = "cmnuRightClickDecSpeed";
            this.cmnuRightClickDecSpeed.ShortcutKeyDisplayString = "-";
            this.cmnuRightClickDecSpeed.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickDecSpeed.Text = "&Decrease Speed";
            this.cmnuRightClickDecSpeed.Click += new System.EventHandler(this.cmnuRightClickDecSpeed_Click);
            // 
            // cmnuRightClickZoomIn
            // 
            this.cmnuRightClickZoomIn.Image = global::MyProgram.Properties.Resources.img_zoom_in;
            this.cmnuRightClickZoomIn.Name = "cmnuRightClickZoomIn";
            this.cmnuRightClickZoomIn.ShortcutKeyDisplayString = "[";
            this.cmnuRightClickZoomIn.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickZoomIn.Text = "Zoom I&n";
            this.cmnuRightClickZoomIn.Click += new System.EventHandler(this.cmnuRightClickZoomIn_Click);
            // 
            // cmnuRightClickZoomOut
            // 
            this.cmnuRightClickZoomOut.Image = global::MyProgram.Properties.Resources.img_zoom_out;
            this.cmnuRightClickZoomOut.Name = "cmnuRightClickZoomOut";
            this.cmnuRightClickZoomOut.ShortcutKeyDisplayString = "]";
            this.cmnuRightClickZoomOut.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickZoomOut.Text = "Zoom O&ut";
            this.cmnuRightClickZoomOut.Click += new System.EventHandler(this.cmnuRightClickZoomOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // cmnuRightClickChangePlayer
            // 
            this.cmnuRightClickChangePlayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuRightClickChangePlayerBomb,
            this.cmnuRightClickChangePlayerPirate,
            this.cmnuRightClickChangePlayerGirl,
            this.cmnuRightClickChangePlayerMan,
            this.cmnuRightClickChangePlayerRockman});
            this.cmnuRightClickChangePlayer.Image = global::MyProgram.Properties.Resources.img_paint;
            this.cmnuRightClickChangePlayer.Name = "cmnuRightClickChangePlayer";
            this.cmnuRightClickChangePlayer.ShortcutKeyDisplayString = "B";
            this.cmnuRightClickChangePlayer.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickChangePlayer.Text = "&Change Charactor";
            // 
            // cmnuRightClickChangePlayerBomb
            // 
            this.cmnuRightClickChangePlayerBomb.Image = global::MyProgram.Properties.Resources.img_bomb;
            this.cmnuRightClickChangePlayerBomb.Name = "cmnuRightClickChangePlayerBomb";
            this.cmnuRightClickChangePlayerBomb.Size = new System.Drawing.Size(180, 22);
            this.cmnuRightClickChangePlayerBomb.Text = "&Bomb Man";
            this.cmnuRightClickChangePlayerBomb.Click += new System.EventHandler(this.cmnuRightClickChangePlayerBomb_Click);
            // 
            // cmnuRightClickChangePlayerPirate
            // 
            this.cmnuRightClickChangePlayerPirate.Image = global::MyProgram.Properties.Resources.img_pirate;
            this.cmnuRightClickChangePlayerPirate.Name = "cmnuRightClickChangePlayerPirate";
            this.cmnuRightClickChangePlayerPirate.Size = new System.Drawing.Size(180, 22);
            this.cmnuRightClickChangePlayerPirate.Text = "&Pirate";
            this.cmnuRightClickChangePlayerPirate.Click += new System.EventHandler(this.cmnuRightClickChangePlayerPirate_Click);
            // 
            // cmnuRightClickChangePlayerGirl
            // 
            this.cmnuRightClickChangePlayerGirl.Image = global::MyProgram.Properties.Resources.img_girl;
            this.cmnuRightClickChangePlayerGirl.Name = "cmnuRightClickChangePlayerGirl";
            this.cmnuRightClickChangePlayerGirl.Size = new System.Drawing.Size(180, 22);
            this.cmnuRightClickChangePlayerGirl.Text = "&Girl";
            this.cmnuRightClickChangePlayerGirl.Click += new System.EventHandler(this.cmnuRightClickChangePlayerGirl_Click);
            // 
            // cmnuRightClickChangePlayerMan
            // 
            this.cmnuRightClickChangePlayerMan.Image = global::MyProgram.Properties.Resources.img_man;
            this.cmnuRightClickChangePlayerMan.Name = "cmnuRightClickChangePlayerMan";
            this.cmnuRightClickChangePlayerMan.Size = new System.Drawing.Size(180, 22);
            this.cmnuRightClickChangePlayerMan.Text = "&Man";
            this.cmnuRightClickChangePlayerMan.Click += new System.EventHandler(this.cmnuRightClickChangePlayerMan_Click);
            // 
            // cmnuRightClickChangePlayerRockman
            // 
            this.cmnuRightClickChangePlayerRockman.Image = global::MyProgram.Properties.Resources.img_rockman;
            this.cmnuRightClickChangePlayerRockman.Name = "cmnuRightClickChangePlayerRockman";
            this.cmnuRightClickChangePlayerRockman.Size = new System.Drawing.Size(180, 22);
            this.cmnuRightClickChangePlayerRockman.Text = "&Rockman";
            this.cmnuRightClickChangePlayerRockman.Click += new System.EventHandler(this.cmnuRightClickChangePlayerRockman_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // cmnuRightClickExit
            // 
            this.cmnuRightClickExit.Image = global::MyProgram.Properties.Resources.img_stop;
            this.cmnuRightClickExit.Name = "cmnuRightClickExit";
            this.cmnuRightClickExit.ShortcutKeyDisplayString = "ESC";
            this.cmnuRightClickExit.Size = new System.Drawing.Size(184, 22);
            this.cmnuRightClickExit.Text = "&Exit";
            this.cmnuRightClickExit.Click += new System.EventHandler(this.cmnuRightClickExit_Click);
            // 
            // SpriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmnuRightClick;
            this.Name = "SpriteControl";
            this.cmnuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ContextMenuStrip cmnuRightClick;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickPause;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickResume;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickIncSpeed;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickDecSpeed;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickZoomIn;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayer;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayerBomb;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayerPirate;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayerGirl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickExit;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayerMan;
        private System.Windows.Forms.ToolStripMenuItem cmnuRightClickChangePlayerRockman;
    }
}
