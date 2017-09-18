namespace startscreen
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
            this.startbutton = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Aqua;
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(262, 159);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(145, 59);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.counter.Location = new System.Drawing.Point(283, 251);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(100, 58);
            this.counter.TabIndex = 1;
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "PacMan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label counter;
    }
}

