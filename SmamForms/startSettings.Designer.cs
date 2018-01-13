namespace SmamForms
{
    partial class startSettings
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxSchool = new System.Windows.Forms.TextBox();
            this.textBoxOpleiding = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.textBoxHuur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(12, 252);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(315, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Hoe heet je?";
            this.textBoxName.Click += new System.EventHandler(this.emptyTextBox);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(12, 307);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(315, 26);
            this.textBoxCity.TabIndex = 2;
            this.textBoxCity.Text = "In welke plaats woon je?";
            this.textBoxCity.Click += new System.EventHandler(this.emptyTextBox);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreet.Location = new System.Drawing.Point(12, 364);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(315, 26);
            this.textBoxStreet.TabIndex = 3;
            this.textBoxStreet.Text = "In welke straat woon je?";
            this.textBoxStreet.Click += new System.EventHandler(this.emptyTextBox);
            // 
            // textBoxSchool
            // 
            this.textBoxSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSchool.Location = new System.Drawing.Point(12, 424);
            this.textBoxSchool.Name = "textBoxSchool";
            this.textBoxSchool.Size = new System.Drawing.Size(315, 26);
            this.textBoxSchool.TabIndex = 4;
            this.textBoxSchool.Text = "Op welke school studeer je momenteel?";
            this.textBoxSchool.Click += new System.EventHandler(this.emptyTextBox);
            // 
            // textBoxOpleiding
            // 
            this.textBoxOpleiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpleiding.Location = new System.Drawing.Point(12, 482);
            this.textBoxOpleiding.Name = "textBoxOpleiding";
            this.textBoxOpleiding.Size = new System.Drawing.Size(315, 26);
            this.textBoxOpleiding.TabIndex = 5;
            this.textBoxOpleiding.Text = "Welke opleiding volg je?";
            this.textBoxOpleiding.Click += new System.EventHandler(this.emptyTextBox);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(220, 537);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 23);
            this.numericUpDown1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SmamForms.Properties.Resources.victoria_palacios_355597;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlogo.Image = global::SmamForms.Properties.Resources.appLogo;
            this.pictureBoxlogo.Location = new System.Drawing.Point(89, 38);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogo.TabIndex = 22;
            this.pictureBoxlogo.TabStop = false;
            // 
            // textBoxHuur
            // 
            this.textBoxHuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuur.Location = new System.Drawing.Point(12, 536);
            this.textBoxHuur.Name = "textBoxHuur";
            this.textBoxHuur.ReadOnly = true;
            this.textBoxHuur.Size = new System.Drawing.Size(202, 26);
            this.textBoxHuur.TabIndex = 23;
            this.textBoxHuur.Text = "Op welke dag betaal je je huur?";
            this.textBoxHuur.Click += new System.EventHandler(this.textBoxHuur_Click);
            // 
            // startSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.textBoxHuur);
            this.Controls.Add(this.pictureBoxlogo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOpleiding);
            this.Controls.Add(this.textBoxSchool);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "startSettings";
            this.Text = "SMAM";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxSchool;
        private System.Windows.Forms.TextBox textBoxOpleiding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.TextBox textBoxHuur;
    }
}