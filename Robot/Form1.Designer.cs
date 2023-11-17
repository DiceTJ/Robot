namespace Robot
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
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(36, 11);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(59, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "{X=0, Y=0}";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Location = new System.Drawing.Point(31, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 1;
            // 
            // lblRobot
            // 
            this.lblRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRobot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRobot.Location = new System.Drawing.Point(100, 100);
            this.lblRobot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(20, 20);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Text = "a";
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(54, 278);
            this.btnGo1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(48, 20);
            this.btnGo1.TabIndex = 2;
            this.btnGo1.Text = "Go &1";
            this.btnGo1.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(127, 260);
            this.btnN.Margin = new System.Windows.Forms.Padding(2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(24, 20);
            this.btnN.TabIndex = 3;
            this.btnN.Text = "&N";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(106, 278);
            this.btnW.Margin = new System.Windows.Forms.Padding(2);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(24, 20);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "&W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 376);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPosition);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

