namespace ExamenOlga2
{
    partial class Game
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
            this.goku = new System.Windows.Forms.PictureBox();
            this.cronometre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            this.SuspendLayout();
            // 
            // goku
            // 
            this.goku.Image = global::ExamenOlga2.Properties.Resources.GokuFull;
            this.goku.Location = new System.Drawing.Point(32, 396);
            this.goku.Name = "goku";
            this.goku.Size = new System.Drawing.Size(61, 71);
            this.goku.TabIndex = 0;
            this.goku.TabStop = false;
            // 
            // cronometre
            // 
            this.cronometre.AutoSize = true;
            this.cronometre.Location = new System.Drawing.Point(237, 69);
            this.cronometre.Name = "cronometre";
            this.cronometre.Size = new System.Drawing.Size(0, 13);
            this.cronometre.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenOlga2.Properties.Resources.Tower;
            this.ClientSize = new System.Drawing.Size(512, 492);
            this.Controls.Add(this.cronometre);
            this.Controls.Add(this.goku);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox goku;
        private System.Windows.Forms.Label cronometre;
        private System.Windows.Forms.Timer timer1;
    }
}