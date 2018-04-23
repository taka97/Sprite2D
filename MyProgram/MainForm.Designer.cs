namespace MyProgram
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spriteControl = new MyProgram.SpriteControl();
            this.SuspendLayout();
            // 
            // spriteControl
            // 
            this.spriteControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spriteControl.Location = new System.Drawing.Point(0, 0);
            this.spriteControl.Name = "spriteControl";
            this.spriteControl.Size = new System.Drawing.Size(852, 478);
            this.spriteControl.TabIndex = 0;
            this.spriteControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spriteControl_KeyDown);
            this.spriteControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spriteControl_KeyUp);
            this.spriteControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spriteControl_MouseDown);
            this.spriteControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spriteControl_MouseMove);
            this.spriteControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spriteControl_MouseUp);
            this.spriteControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.spriteControl_PreviewKeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 478);
            this.Controls.Add(this.spriteControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MainForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private SpriteControl spriteControl;
    }
}