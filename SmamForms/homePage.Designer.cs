namespace SmamForms
{
    partial class homePage
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
            this.labelTipVDDag = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProf = new System.Windows.Forms.Button();
            this.buttonFinancien = new System.Windows.Forms.Button();
            this.buttonRecept = new System.Windows.Forms.Button();
            this.buttonStudie = new System.Windows.Forms.Button();
            this.buttonShoppingList = new System.Windows.Forms.Button();
            this.buttonPOI = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipVDDag
            // 
            this.labelTipVDDag.AutoSize = true;
            this.labelTipVDDag.Location = new System.Drawing.Point(123, 9);
            this.labelTipVDDag.Name = "labelTipVDDag";
            this.labelTipVDDag.Size = new System.Drawing.Size(79, 13);
            this.labelTipVDDag.TabIndex = 0;
            this.labelTipVDDag.Text = "Tip van de dag";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(115, 22);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(87, 13);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "Hier komt een tip";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonProf);
            this.panel1.Controls.Add(this.buttonFinancien);
            this.panel1.Controls.Add(this.buttonRecept);
            this.panel1.Controls.Add(this.buttonStudie);
            this.panel1.Controls.Add(this.buttonShoppingList);
            this.panel1.Controls.Add(this.buttonPOI);
            this.panel1.Location = new System.Drawing.Point(2, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 531);
            this.panel1.TabIndex = 10;
            // 
            // buttonProf
            // 
            this.buttonProf.BackgroundImage = global::SmamForms.Properties.Resources.Ontwikkeling;
            this.buttonProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProf.Location = new System.Drawing.Point(3, 580);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(311, 120);
            this.buttonProf.TabIndex = 5;
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonFinancien
            // 
            this.buttonFinancien.BackgroundImage = global::SmamForms.Properties.Resources.Finance;
            this.buttonFinancien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFinancien.Location = new System.Drawing.Point(3, 467);
            this.buttonFinancien.Name = "buttonFinancien";
            this.buttonFinancien.Size = new System.Drawing.Size(311, 120);
            this.buttonFinancien.TabIndex = 4;
            this.buttonFinancien.UseVisualStyleBackColor = true;
            this.buttonFinancien.Click += new System.EventHandler(this.buttonFinancien_Click);
            // 
            // buttonRecept
            // 
            this.buttonRecept.BackgroundImage = global::SmamForms.Properties.Resources.Koken;
            this.buttonRecept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecept.Location = new System.Drawing.Point(3, 355);
            this.buttonRecept.Name = "buttonRecept";
            this.buttonRecept.Size = new System.Drawing.Size(311, 120);
            this.buttonRecept.TabIndex = 3;
            this.buttonRecept.UseVisualStyleBackColor = true;
            this.buttonRecept.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonStudie
            // 
            this.buttonStudie.BackgroundImage = global::SmamForms.Properties.Resources.studeren;
            this.buttonStudie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStudie.Location = new System.Drawing.Point(3, 236);
            this.buttonStudie.Name = "buttonStudie";
            this.buttonStudie.Size = new System.Drawing.Size(311, 120);
            this.buttonStudie.TabIndex = 2;
            this.buttonStudie.UseVisualStyleBackColor = true;
            this.buttonStudie.Click += new System.EventHandler(this.buttonStudie_Click);
            // 
            // buttonShoppingList
            // 
            this.buttonShoppingList.BackgroundImage = global::SmamForms.Properties.Resources.Boodschappen;
            this.buttonShoppingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShoppingList.Location = new System.Drawing.Point(3, 117);
            this.buttonShoppingList.Name = "buttonShoppingList";
            this.buttonShoppingList.Size = new System.Drawing.Size(311, 120);
            this.buttonShoppingList.TabIndex = 1;
            this.buttonShoppingList.UseVisualStyleBackColor = true;
            this.buttonShoppingList.Click += new System.EventHandler(this.buttonShoppingList_Click);
            // 
            // buttonPOI
            // 
            this.buttonPOI.BackgroundImage = global::SmamForms.Properties.Resources.poi;
            this.buttonPOI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPOI.Location = new System.Drawing.Point(3, 3);
            this.buttonPOI.Name = "buttonPOI";
            this.buttonPOI.Size = new System.Drawing.Size(311, 120);
            this.buttonPOI.TabIndex = 0;
            this.buttonPOI.UseVisualStyleBackColor = true;
            this.buttonPOI.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.Transparent;
            this.buttonSetting.BackgroundImage = global::SmamForms.Properties.Resources.Settings_icon;
            this.buttonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSetting.Location = new System.Drawing.Point(281, 9);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(35, 35);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 579);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelTipVDDag);
            this.Name = "homePage";
            this.Text = "SMAM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipVDDag;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFinancien;
        private System.Windows.Forms.Button buttonRecept;
        private System.Windows.Forms.Button buttonStudie;
        private System.Windows.Forms.Button buttonShoppingList;
        private System.Windows.Forms.Button buttonPOI;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonSetting;
    }
}