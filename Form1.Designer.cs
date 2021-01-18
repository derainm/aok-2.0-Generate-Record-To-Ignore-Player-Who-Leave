
namespace Generate_Record_To_Ignore_Player_Who_Leave
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.buttonGenerateFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlayerSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.Location = new System.Drawing.Point(306, 172);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(179, 61);
            this.buttonBrowser.TabIndex = 0;
            this.buttonBrowser.Text = "Browser Restore Game";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // buttonGenerateFile
            // 
            this.buttonGenerateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenerateFile.Location = new System.Drawing.Point(15, 172);
            this.buttonGenerateFile.Name = "buttonGenerateFile";
            this.buttonGenerateFile.Size = new System.Drawing.Size(179, 61);
            this.buttonGenerateFile.TabIndex = 1;
            this.buttonGenerateFile.Text = "Generate The new Restore file";
            this.buttonGenerateFile.UseVisualStyleBackColor = true;
            this.buttonGenerateFile.Click += new System.EventHandler(this.buttonGenerateFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "set Player restore:";
            // 
            // comboBoxPlayerSelection
            // 
            this.comboBoxPlayerSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayerSelection.FormattingEnabled = true;
            this.comboBoxPlayerSelection.Location = new System.Drawing.Point(12, 39);
            this.comboBoxPlayerSelection.Name = "comboBoxPlayerSelection";
            this.comboBoxPlayerSelection.Size = new System.Drawing.Size(209, 21);
            this.comboBoxPlayerSelection.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age of Empires II\\SaveGame\\Multi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Example file :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Localisation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Original File:      Out of Sync Save -  13-ene.-2021 19`39`12.mgs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Generated File: Out of Sync Save -  13-ene.-2021 19`39`12.mgs__";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "remove __ and send file to player that you want restore ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 250);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlayerSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGenerateFile);
            this.Controls.Add(this.buttonBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(583, 289);
            this.Name = "Form1";
            this.Text = "Aok 2.0 Generate Record To Ignore Player Who Never come back Made by katsuie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.Button buttonGenerateFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPlayerSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

