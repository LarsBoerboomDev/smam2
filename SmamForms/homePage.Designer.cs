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
            this.buttonShoppingList = new System.Windows.Forms.Button();
            this.buttonHuishouden = new System.Windows.Forms.Button();
            this.buttonPOI = new System.Windows.Forms.Button();
            this.buttonRecept = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonFinancien = new System.Windows.Forms.Button();
            this.buttonStudie = new System.Windows.Forms.Button();
            this.buttonProf = new System.Windows.Forms.Button();
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
            // buttonShoppingList
            // 
            this.buttonShoppingList.Location = new System.Drawing.Point(60, 259);
            this.buttonShoppingList.Name = "buttonShoppingList";
            this.buttonShoppingList.Size = new System.Drawing.Size(100, 100);
            this.buttonShoppingList.TabIndex = 2;
            this.buttonShoppingList.Text = "Boodschappen- lijstjes";
            this.buttonShoppingList.UseVisualStyleBackColor = true;
            this.buttonShoppingList.Click += new System.EventHandler(this.buttonShoppingList_Click);
            // 
            // buttonHuishouden
            // 
            this.buttonHuishouden.Location = new System.Drawing.Point(166, 365);
            this.buttonHuishouden.Name = "buttonHuishouden";
            this.buttonHuishouden.Size = new System.Drawing.Size(100, 100);
            this.buttonHuishouden.TabIndex = 3;
            this.buttonHuishouden.Text = "Handleidingen";
            this.buttonHuishouden.UseVisualStyleBackColor = true;
            this.buttonHuishouden.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPOI
            // 
            this.buttonPOI.Location = new System.Drawing.Point(166, 259);
            this.buttonPOI.Name = "buttonPOI";
            this.buttonPOI.Size = new System.Drawing.Size(100, 100);
            this.buttonPOI.TabIndex = 4;
            this.buttonPOI.Text = "Hoe ziet mijn plaats eruit?";
            this.buttonPOI.UseVisualStyleBackColor = true;
            this.buttonPOI.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRecept
            // 
            this.buttonRecept.Location = new System.Drawing.Point(60, 365);
            this.buttonRecept.Name = "buttonRecept";
            this.buttonRecept.Size = new System.Drawing.Size(100, 100);
            this.buttonRecept.TabIndex = 5;
            this.buttonRecept.Text = "Hoe maak ik iets lekkers te eten?";
            this.buttonRecept.UseVisualStyleBackColor = true;
            this.buttonRecept.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(166, 471);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(100, 100);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Mijn gegevens aanpassen";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonFinancien
            // 
            this.buttonFinancien.Location = new System.Drawing.Point(60, 471);
            this.buttonFinancien.Name = "buttonFinancien";
            this.buttonFinancien.Size = new System.Drawing.Size(100, 100);
            this.buttonFinancien.TabIndex = 7;
            this.buttonFinancien.Text = "Hoe ga ik met mijn geld om?";
            this.buttonFinancien.UseVisualStyleBackColor = true;
            this.buttonFinancien.Click += new System.EventHandler(this.buttonFinancien_Click);
            // 
            // buttonStudie
            // 
            this.buttonStudie.Location = new System.Drawing.Point(60, 153);
            this.buttonStudie.Name = "buttonStudie";
            this.buttonStudie.Size = new System.Drawing.Size(100, 100);
            this.buttonStudie.TabIndex = 8;
            this.buttonStudie.Text = "Hoe haal ik alles uit mijn studie?";
            this.buttonStudie.UseVisualStyleBackColor = true;
            this.buttonStudie.Click += new System.EventHandler(this.buttonStudie_Click);
            // 
            // buttonProf
            // 
            this.buttonProf.Location = new System.Drawing.Point(166, 153);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(100, 100);
            this.buttonProf.TabIndex = 9;
            this.buttonProf.Text = "Professionele ontwikkeling";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonStudie);
            this.Controls.Add(this.buttonFinancien);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.buttonRecept);
            this.Controls.Add(this.buttonPOI);
            this.Controls.Add(this.buttonHuishouden);
            this.Controls.Add(this.buttonShoppingList);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelTipVDDag);
            this.Name = "homePage";
            this.Text = "SMAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipVDDag;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button buttonShoppingList;
        private System.Windows.Forms.Button buttonHuishouden;
        private System.Windows.Forms.Button buttonPOI;
        private System.Windows.Forms.Button buttonRecept;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonFinancien;
        private System.Windows.Forms.Button buttonStudie;
        private System.Windows.Forms.Button buttonProf;
    }
}