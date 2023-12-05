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
            this.lblAnimals = new System.Windows.Forms.Label();
            this.lblWagons = new System.Windows.Forms.Label();
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
            // lblAnimals
            // 
            this.lblAnimals.AutoSize = true;
            this.lblAnimals.Location = new System.Drawing.Point(12, 89);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(66, 13);
            this.lblAnimals.TabIndex = 1;
            this.lblAnimals.Text = "AnimalCount";
            // 
            // lblWagons
            // 
            this.lblWagons.AutoSize = true;
            this.lblWagons.Location = new System.Drawing.Point(716, 89);
            this.lblWagons.Name = "lblWagons";
            this.lblWagons.Size = new System.Drawing.Size(72, 13);
            this.lblWagons.TabIndex = 2;
            this.lblWagons.Text = "Wagon count";
            // 
            // CircusTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWagons);
            this.Controls.Add(this.lblAnimals);
            this.Controls.Add(this.addAnimals);
            this.Name = "CircusTrain";
            this.Text = "Circus Train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAnimals;
        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.Label lblWagons;
    }
}

