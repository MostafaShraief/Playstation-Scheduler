namespace Playstation_Scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucStopwatch4 = new Playstation_Scheduler.ucStopwatch();
            this.ucStopwatch3 = new Playstation_Scheduler.ucStopwatch();
            this.ucStopwatch2 = new Playstation_Scheduler.ucStopwatch();
            this.ucStopwatch1 = new Playstation_Scheduler.ucStopwatch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucStopwatch4
            // 
            this.ucStopwatch4.BackColor = System.Drawing.Color.Transparent;
            this.ucStopwatch4.feePerHour = 10000D;
            this.ucStopwatch4.Location = new System.Drawing.Point(2, 277);
            this.ucStopwatch4.Name = "ucStopwatch4";
            this.ucStopwatch4.Size = new System.Drawing.Size(155, 171);
            this.ucStopwatch4.StopwatchName = "Number 1";
            this.ucStopwatch4.TabIndex = 3;
            // 
            // ucStopwatch3
            // 
            this.ucStopwatch3.BackColor = System.Drawing.Color.Transparent;
            this.ucStopwatch3.feePerHour = 10000D;
            this.ucStopwatch3.Location = new System.Drawing.Point(159, 277);
            this.ucStopwatch3.Name = "ucStopwatch3";
            this.ucStopwatch3.Size = new System.Drawing.Size(155, 171);
            this.ucStopwatch3.StopwatchName = "Number 2";
            this.ucStopwatch3.TabIndex = 2;
            // 
            // ucStopwatch2
            // 
            this.ucStopwatch2.BackColor = System.Drawing.Color.Transparent;
            this.ucStopwatch2.feePerHour = 10000D;
            this.ucStopwatch2.Location = new System.Drawing.Point(474, 277);
            this.ucStopwatch2.Name = "ucStopwatch2";
            this.ucStopwatch2.Size = new System.Drawing.Size(155, 171);
            this.ucStopwatch2.StopwatchName = "Number 4";
            this.ucStopwatch2.TabIndex = 1;
            // 
            // ucStopwatch1
            // 
            this.ucStopwatch1.BackColor = System.Drawing.Color.Transparent;
            this.ucStopwatch1.feePerHour = 10000D;
            this.ucStopwatch1.Location = new System.Drawing.Point(316, 277);
            this.ucStopwatch1.Name = "ucStopwatch1";
            this.ucStopwatch1.Size = new System.Drawing.Size(155, 171);
            this.ucStopwatch1.StopwatchName = "Number 3";
            this.ucStopwatch1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Playstation_Scheduler.Properties.Resources.images;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price per hour:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(631, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucStopwatch4);
            this.Controls.Add(this.ucStopwatch3);
            this.Controls.Add(this.ucStopwatch2);
            this.Controls.Add(this.ucStopwatch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Playstation Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucStopwatch ucStopwatch1;
        private ucStopwatch ucStopwatch2;
        private ucStopwatch ucStopwatch3;
        private ucStopwatch ucStopwatch4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

