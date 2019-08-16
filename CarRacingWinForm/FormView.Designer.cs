namespace CarRacingWinForm
{
    partial class FormView
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
            this.TimerRacing = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerRacing
            // 
            this.TimerRacing.Enabled = true;
            this.TimerRacing.Interval = 50;
            this.TimerRacing.Tick += new System.EventHandler(this.TimerRacing_Tick);
            // 
            // FormView
            // 
            this.ClientSize = new System.Drawing.Size(670, 521);
            this.DoubleBuffered = true;
            this.Name = "FormView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormView_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormView_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerRacing;
    }
}

