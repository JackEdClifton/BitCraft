
namespace RandomTeamPicker {
    partial class Window {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label Title;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            System.Windows.Forms.PictureBox pictureBox2;
            this.nameInput = new System.Windows.Forms.TextBox();
            this.randomize = new System.Windows.Forms.Button();
            this.teamBlue = new System.Windows.Forms.TextBox();
            this.teamOrange = new System.Windows.Forms.TextBox();
            this.screenshot = new System.Windows.Forms.Button();
            Title = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = System.Drawing.Color.Transparent;
            Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            Title.Location = new System.Drawing.Point(137, 9);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(396, 42);
            Title.TabIndex = 0;
            Title.Text = "Random Team Picker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label2.Location = new System.Drawing.Point(16, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 18);
            label2.TabIndex = 3;
            label2.Text = "Input";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Aqua;
            label1.Location = new System.Drawing.Point(190, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 18);
            label1.TabIndex = 5;
            label1.Text = "Blue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            label3.Location = new System.Drawing.Point(437, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 18);
            label3.TabIndex = 7;
            label3.Text = "Orange";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(31, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(539, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 62);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // nameInput
            // 
            this.nameInput.AcceptsReturn = true;
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameInput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(19, 77);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(141, 181);
            this.nameInput.TabIndex = 1;
            // 
            // randomize
            // 
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(19, 281);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(141, 29);
            this.randomize.TabIndex = 2;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // teamBlue
            // 
            this.teamBlue.AcceptsReturn = true;
            this.teamBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teamBlue.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBlue.Location = new System.Drawing.Point(193, 77);
            this.teamBlue.Multiline = true;
            this.teamBlue.Name = "teamBlue";
            this.teamBlue.ReadOnly = true;
            this.teamBlue.Size = new System.Drawing.Size(209, 181);
            this.teamBlue.TabIndex = 4;
            // 
            // teamOrange
            // 
            this.teamOrange.AcceptsReturn = true;
            this.teamOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.teamOrange.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOrange.Location = new System.Drawing.Point(440, 77);
            this.teamOrange.Multiline = true;
            this.teamOrange.Name = "teamOrange";
            this.teamOrange.ReadOnly = true;
            this.teamOrange.Size = new System.Drawing.Size(209, 181);
            this.teamOrange.TabIndex = 6;
            // 
            // screenshot
            // 
            this.screenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshot.Location = new System.Drawing.Point(193, 281);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(141, 29);
            this.screenshot.TabIndex = 11;
            this.screenshot.Text = "Screenshot";
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.Click += new System.EventHandler(this.screenshot_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(674, 321);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(label3);
            this.Controls.Add(this.teamOrange);
            this.Controls.Add(label1);
            this.Controls.Add(this.teamBlue);
            this.Controls.Add(label2);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(Title);
            this.Controls.Add(pictureBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Random Team Picker";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox teamBlue;
        private System.Windows.Forms.TextBox teamOrange;
        private System.Windows.Forms.Button screenshot;
    }
}

