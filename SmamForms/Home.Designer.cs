namespace SmamForms
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Grocery = new System.Windows.Forms.Button();
            this.poi = new System.Windows.Forms.Button();
            this.buttonStudie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Grocery);
            this.panel1.Controls.Add(this.poi);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 599);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SmamForms.Properties.Resources.Finance;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 120);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SmamForms.Properties.Resources.Koken;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 120);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SmamForms.Properties.Resources.studeren;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(0, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 120);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Grocery
            // 
            this.Grocery.BackgroundImage = global::SmamForms.Properties.Resources.Boodschappen;
            this.Grocery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Grocery.Location = new System.Drawing.Point(0, 130);
            this.Grocery.Name = "Grocery";
            this.Grocery.Size = new System.Drawing.Size(311, 120);
            this.Grocery.TabIndex = 1;
            this.Grocery.UseVisualStyleBackColor = true;
            // 
            // poi
            // 
            this.poi.BackgroundImage = global::SmamForms.Properties.Resources.poi;
            this.poi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poi.Location = new System.Drawing.Point(0, 16);
            this.poi.Name = "poi";
            this.poi.Size = new System.Drawing.Size(311, 120);
            this.poi.TabIndex = 0;
            this.poi.UseVisualStyleBackColor = true;
            // 
            // buttonStudie
            // 
            this.buttonStudie.BackgroundImage = global::SmamForms.Properties.Resources.Huishouden;
            this.buttonStudie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStudie.Location = new System.Drawing.Point(447, 182);
            this.buttonStudie.Name = "buttonStudie";
            this.buttonStudie.Size = new System.Drawing.Size(311, 120);
            this.buttonStudie.TabIndex = 3;
            this.buttonStudie.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.buttonStudie);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button poi;
        private System.Windows.Forms.Button Grocery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStudie;
    }
}