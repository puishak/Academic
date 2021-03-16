namespace FP
{
    partial class Form1
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
            this.btnMultiPlayer = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiPlayer.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiPlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiPlayer.Location = new System.Drawing.Point(304, 176);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(335, 69);
            this.btnMultiPlayer.TabIndex = 2;
            this.btnMultiPlayer.Text = "MULTI PLAYER";
            this.btnMultiPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMultiPlayer.Click += new System.EventHandler(this.btnMultiPlayer_Click);
            this.btnMultiPlayer.MouseLeave += new System.EventHandler(this.Leave);
            this.btnMultiPlayer.MouseHover += new System.EventHandler(this.Hover);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnSinglePlayer.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSinglePlayer.Location = new System.Drawing.Point(304, 115);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(335, 69);
            this.btnSinglePlayer.TabIndex = 4;
            this.btnSinglePlayer.Text = "SINGLE PLAYER";
            this.btnSinglePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            this.btnSinglePlayer.MouseLeave += new System.EventHandler(this.Leave);
            this.btnSinglePlayer.MouseHover += new System.EventHandler(this.Hover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(304, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(335, 69);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Leave);
            this.btnExit.MouseHover += new System.EventHandler(this.Hover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 128);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Centre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::FP.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.btnMultiPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnMultiPlayer;
        private System.Windows.Forms.Label btnSinglePlayer;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label label1;
    }
}

