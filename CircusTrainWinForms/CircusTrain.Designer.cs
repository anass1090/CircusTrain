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
            this.numSH = new System.Windows.Forms.NumericUpDown();
            this.numMH = new System.Windows.Forms.NumericUpDown();
            this.numLC = new System.Windows.Forms.NumericUpDown();
            this.numSC = new System.Windows.Forms.NumericUpDown();
            this.numLH = new System.Windows.Forms.NumericUpDown();
            this.numMC = new System.Windows.Forms.NumericUpDown();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.lblLC = new System.Windows.Forms.Label();
            this.lblSH = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.lblLH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMC)).BeginInit();
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
            // numSH
            // 
            this.numSH.Location = new System.Drawing.Point(165, 32);
            this.numSH.Name = "numSH";
            this.numSH.Size = new System.Drawing.Size(120, 20);
            this.numSH.TabIndex = 3;
            // 
            // numMH
            // 
            this.numMH.Location = new System.Drawing.Point(165, 78);
            this.numMH.Name = "numMH";
            this.numMH.Size = new System.Drawing.Size(120, 20);
            this.numMH.TabIndex = 4;
            // 
            // numLC
            // 
            this.numLC.Location = new System.Drawing.Point(165, 276);
            this.numLC.Name = "numLC";
            this.numLC.Size = new System.Drawing.Size(120, 20);
            this.numLC.TabIndex = 5;
            // 
            // numSC
            // 
            this.numSC.Location = new System.Drawing.Point(165, 177);
            this.numSC.Name = "numSC";
            this.numSC.Size = new System.Drawing.Size(120, 20);
            this.numSC.TabIndex = 6;
            // 
            // numLH
            // 
            this.numLH.Location = new System.Drawing.Point(165, 126);
            this.numLH.Name = "numLH";
            this.numLH.Size = new System.Drawing.Size(120, 20);
            this.numLH.TabIndex = 7;
            // 
            // numMC
            // 
            this.numMC.Location = new System.Drawing.Point(165, 225);
            this.numMC.Name = "numMC";
            this.numMC.Size = new System.Drawing.Size(120, 20);
            this.numMC.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wagons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Animals in wagon";
            // 
            // CircusTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLH);
            this.Controls.Add(this.lblMH);
            this.Controls.Add(this.lblSH);
            this.Controls.Add(this.lblLC);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.numMC);
            this.Controls.Add(this.numLH);
            this.Controls.Add(this.numSC);
            this.Controls.Add(this.numLC);
            this.Controls.Add(this.numMH);
            this.Controls.Add(this.numSH);
            this.Controls.Add(this.listAnimalsinWagon);
            this.Controls.Add(this.listWagons);
            this.Controls.Add(this.addAnimals);
            this.Name = "CircusTrain";
            this.Text = "Circus Train";
            ((System.ComponentModel.ISupportInitialize)(this.numSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAnimals;
        private System.Windows.Forms.ListBox listWagons;
        private System.Windows.Forms.ListBox listAnimalsinWagon;
        private System.Windows.Forms.NumericUpDown numSH;
        private System.Windows.Forms.NumericUpDown numMH;
        private System.Windows.Forms.NumericUpDown numLC;
        private System.Windows.Forms.NumericUpDown numSC;
        private System.Windows.Forms.NumericUpDown numLH;
        private System.Windows.Forms.NumericUpDown numMC;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lblLC;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.Label lblLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

