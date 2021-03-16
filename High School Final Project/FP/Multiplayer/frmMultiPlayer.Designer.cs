namespace FP
{
    partial class frmMultiPlayer
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
            this.btnExit = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.btnGame3 = new System.Windows.Forms.Label();
            this.btnGame1 = new System.Windows.Forms.Label();
            this.btnGame2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(888, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Leave);
            this.btnExit.MouseHover += new System.EventHandler(this.Hover);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Location = new System.Drawing.Point(12, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 55);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.Leave);
            this.btnBack.MouseHover += new System.EventHandler(this.Hover);
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.Silver;
            this.btnGame3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGame3.Location = new System.Drawing.Point(669, 136);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(300, 250);
            this.btnGame3.TabIndex = 42;
            this.btnGame3.Text = "Whatever Thomas is doing";
            this.btnGame3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.Silver;
            this.btnGame1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGame1.Location = new System.Drawing.Point(57, 136);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(300, 250);
            this.btnGame1.TabIndex = 41;
            this.btnGame1.Text = "Tetris";
            this.btnGame1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.Silver;
            this.btnGame2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGame2.Location = new System.Drawing.Point(363, 136);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(300, 250);
            this.btnGame2.TabIndex = 40;
            this.btnGame2.Text = "Advanced Tic-tac-toe";
            this.btnGame2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWelcome.Location = new System.Drawing.Point(56, 49);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(229, 46);
            this.lblWelcome.TabIndex = 43;
            this.lblWelcome.Text = "Multiplayer";
            // 
            // frmMultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1027, 522);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMultiPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMultiPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label btnGame3;
        private System.Windows.Forms.Label btnGame1;
        private System.Windows.Forms.Label btnGame2;
        private System.Windows.Forms.Label lblWelcome;
    }
}