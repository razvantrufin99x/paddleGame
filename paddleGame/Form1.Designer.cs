namespace paddleGame
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
            this.components = new System.ComponentModel.Container();
            this.GraphicsWindow = new graphicswithpermanentcontrol.UserControl1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GraphicsWindow
            // 
            this.GraphicsWindow.BackColor = System.Drawing.Color.White;
            this.GraphicsWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphicsWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.GraphicsWindow.Location = new System.Drawing.Point(12, 34);
            this.GraphicsWindow.Name = "GraphicsWindow";
            this.GraphicsWindow.Size = new System.Drawing.Size(400, 226);
            this.GraphicsWindow.TabIndex = 0;
            this.GraphicsWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicsWindow_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "double click in the image below and then press this button to start the game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GraphicsWindow);
            this.Name = "Form1";
            this.Text = "Paddle SmallBasic translated into c net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private graphicswithpermanentcontrol.UserControl1 GraphicsWindow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;

    }
}

