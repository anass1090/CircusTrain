namespace CircusTrainWinForms
{
    partial class CircusTrain
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
            this.addAnimals = new System.Windows.Forms.Button();
            this.listWagons = new System.Windows.Forms.ListBox();
            this.listAnimalsinWagon = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.lblLC = new System.Windows.Forms.Label();
            this.lblSH = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.lblLH = new System.Windows.Forms.Label();
            this.lblWagonCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // addAnimals
            // 
            this.addAnimals.Location = new System.Drawing.Point(315, 360);
            this.addAnimals.Name = "addAnimals";
            this.addAnimals.Size = new System.Drawing.Size(155, 78);
            this.addAnimals.TabIndex = 0;
            this.addAnimals.Text = "Add Animals";
            this.addAnimals.UseVisualStyleBackColor = true;
            this.addAnimals.Click += new System.EventHandler(this.AddAnimals_Click);
            // 
            // listWagons
            // 
            this.listWagons.FormattingEnabled = true;
            this.listWagons.Location = new System.Drawing.Point(315, 32);
            this.listWagons.Name = "listWagons";
            this.listWagons.Size = new System.Drawing.Size(204, 264);
            this.listWagons.TabIndex = 1;
            this.listWagons.SelectedIndexChanged += new System.EventHandler(this.ListWagons_SelectedIndexChanged);
            // 
            // listAnimalsinWagon
            // 
            this.listAnimalsinWagon.FormattingEnabled = true;
            this.listAnimalsinWagon.Location = new System.Drawing.Point(584, 32);
            this.listAnimalsinWagon.Name = "listAnimalsinWagon";
            this.listAnimalsinWagon.Size = new System.Drawing.Size(204, 264);
            this.listAnimalsinWagon.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(165, 78);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(165, 276);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(165, 177);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 6;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(165, 126);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 7;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(165, 225);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown6.TabIndex = 8;
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Location = new System.Drawing.Point(22, 179);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(80, 13);
            this.lblSC.TabIndex = 9;
            this.lblSC.Text = "Small Carnivore";
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Location = new System.Drawing.Point(22, 227);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(92, 13);
            this.lblMC.TabIndex = 10;
            this.lblMC.Text = "Medium Carnivore";
            // 
            // lblLC
            // 
            this.lblLC.AutoSize = true;
            this.lblLC.Location = new System.Drawing.Point(22, 278);
            this.lblLC.Name = "lblLC";
            this.lblLC.Size = new System.Drawing.Size(82, 13);
            this.lblLC.TabIndex = 11;
            this.lblLC.Text = "Large Carnivore";
            // 
            // lblSH
            // 
            this.lblSH.AutoSize = true;
            this.lblSH.Location = new System.Drawing.Point(22, 34);
            this.lblSH.Name = "lblSH";
            this.lblSH.Size = new System.Drawing.Size(81, 13);
            this.lblSH.TabIndex = 12;
            this.lblSH.Text = "Small Herbivore";
            // 
            // lblMH
            // 
            this.lblMH.AutoSize = true;
            this.lblMH.Location = new System.Drawing.Point(22, 80);
            this.lblMH.Name = "lblMH";
            this.lblMH.Size = new System.Drawing.Size(93, 13);
            this.lblMH.TabIndex = 13;
            this.lblMH.Text = "Medium Herbivore";
            // 
            // lblLH
            // 
            this.lblLH.AutoSize = true;
            this.lblLH.Location = new System.Drawing.Point(22, 128);
            this.lblLH.Name = "lblLH";
            this.lblLH.Size = new System.Drawing.Size(83, 13);
            this.lblLH.TabIndex = 14;
            this.lblLH.Text = "Large Herbivore";
            // 
            // lblWagonCount
            // 
            this.lblWagonCount.AutoSize = true;
            this.lblWagonCount.Location = new System.Drawing.Point(514, 310);
            this.lblWagonCount.Name = "lblWagonCount";
            this.lblWagonCount.Size = new System.Drawing.Size(72, 13);
            this.lblWagonCount.TabIndex = 15;
            this.lblWagonCount.Text = "Wagon count";
            // 
            // CircusTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWagonCount);
            this.Controls.Add(this.lblLH);
            this.Controls.Add(this.lblMH);
            this.Controls.Add(this.lblSH);
            this.Controls.Add(this.lblLC);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listAnimalsinWagon);
            this.Controls.Add(this.listWagons);
            this.Controls.Add(this.addAnimals);
            this.Name = "CircusTrain";
            this.Text = "Circus Train";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAnimals;
        private System.Windows.Forms.ListBox listWagons;
        private System.Windows.Forms.ListBox listAnimalsinWagon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lblLC;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.Label lblLH;
        private System.Windows.Forms.Label lblWagonCount;
    }
}

