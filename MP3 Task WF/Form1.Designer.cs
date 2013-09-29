namespace MP3_Task_WF
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
            this.browse_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.read_button = new System.Windows.Forms.Button();
            this.bitrate_label = new System.Windows.Forms.Label();
            this.frequency_label = new System.Windows.Forms.Label();
            this.frames_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(272, 58);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(71, 23);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "Browse...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 1;
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(124, 95);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(100, 36);
            this.read_button.TabIndex = 2;
            this.read_button.Text = "Read";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // bitrate_label
            // 
            this.bitrate_label.AutoSize = true;
            this.bitrate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitrate_label.Location = new System.Drawing.Point(106, 150);
            this.bitrate_label.Name = "bitrate_label";
            this.bitrate_label.Size = new System.Drawing.Size(69, 20);
            this.bitrate_label.TabIndex = 3;
            this.bitrate_label.Text = "Bitrate: ";
            // 
            // frequency_label
            // 
            this.frequency_label.AutoSize = true;
            this.frequency_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequency_label.Location = new System.Drawing.Point(106, 174);
            this.frequency_label.Name = "frequency_label";
            this.frequency_label.Size = new System.Drawing.Size(97, 20);
            this.frequency_label.TabIndex = 4;
            this.frequency_label.Text = "Frequency: ";
            // 
            // frames_label
            // 
            this.frames_label.AutoSize = true;
            this.frames_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frames_label.Location = new System.Drawing.Point(106, 196);
            this.frames_label.Name = "frames_label";
            this.frames_label.Size = new System.Drawing.Size(76, 20);
            this.frames_label.TabIndex = 5;
            this.frames_label.Text = "Frames: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 241);
            this.Controls.Add(this.frames_label);
            this.Controls.Add(this.frequency_label);
            this.Controls.Add(this.bitrate_label);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browse_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MP3 Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Label bitrate_label;
        private System.Windows.Forms.Label frequency_label;
        private System.Windows.Forms.Label frames_label;
    }
}

