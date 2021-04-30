namespace Voertuigen_Forms
{
    partial class frmVoertuigen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAantalWielen = new System.Windows.Forms.TextBox();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblNummerplaat = new System.Windows.Forms.Label();
            this.txtNummerplaat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFiets = new System.Windows.Forms.RadioButton();
            this.radAuto = new System.Windows.Forms.RadioButton();
            this.btnToon2 = new System.Windows.Forms.Button();
            this.chkMotor = new System.Windows.Forms.CheckBox();
            this.chkBagagedrager = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal wielen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Merk:";
            // 
            // txtAantalWielen
            // 
            this.txtAantalWielen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAantalWielen.Location = new System.Drawing.Point(347, 36);
            this.txtAantalWielen.Name = "txtAantalWielen";
            this.txtAantalWielen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalWielen.TabIndex = 6;
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(347, 93);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(100, 20);
            this.txtMerk.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details:";
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDetails.Location = new System.Drawing.Point(127, 185);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(467, 67);
            this.lblDetails.TabIndex = 12;
            // 
            // lblNummerplaat
            // 
            this.lblNummerplaat.AutoSize = true;
            this.lblNummerplaat.Location = new System.Drawing.Point(254, 150);
            this.lblNummerplaat.Name = "lblNummerplaat";
            this.lblNummerplaat.Size = new System.Drawing.Size(72, 13);
            this.lblNummerplaat.TabIndex = 16;
            this.lblNummerplaat.Text = "Nummerplaat:";
            // 
            // txtNummerplaat
            // 
            this.txtNummerplaat.Location = new System.Drawing.Point(347, 143);
            this.txtNummerplaat.Name = "txtNummerplaat";
            this.txtNummerplaat.Size = new System.Drawing.Size(100, 20);
            this.txtNummerplaat.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFiets);
            this.groupBox1.Controls.Add(this.radAuto);
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maak je keuze:";
            // 
            // radFiets
            // 
            this.radFiets.AutoSize = true;
            this.radFiets.Location = new System.Drawing.Point(15, 61);
            this.radFiets.Name = "radFiets";
            this.radFiets.Size = new System.Drawing.Size(47, 17);
            this.radFiets.TabIndex = 3;
            this.radFiets.TabStop = true;
            this.radFiets.Text = "Fiets";
            this.radFiets.UseVisualStyleBackColor = true;
            this.radFiets.CheckedChanged += new System.EventHandler(this.KeuzeVoertuig);
            // 
            // radAuto
            // 
            this.radAuto.AutoSize = true;
            this.radAuto.Location = new System.Drawing.Point(15, 29);
            this.radAuto.Name = "radAuto";
            this.radAuto.Size = new System.Drawing.Size(47, 17);
            this.radAuto.TabIndex = 2;
            this.radAuto.TabStop = true;
            this.radAuto.Text = "Auto";
            this.radAuto.UseVisualStyleBackColor = true;
            this.radAuto.CheckedChanged += new System.EventHandler(this.KeuzeVoertuig);
            // 
            // btnToon2
            // 
            this.btnToon2.Location = new System.Drawing.Point(21, 142);
            this.btnToon2.Name = "btnToon2";
            this.btnToon2.Size = new System.Drawing.Size(112, 45);
            this.btnToon2.TabIndex = 20;
            this.btnToon2.Text = "Toon";
            this.btnToon2.UseVisualStyleBackColor = true;
            this.btnToon2.Click += new System.EventHandler(this.btnToon2_Click);
            // 
            // chkMotor
            // 
            this.chkMotor.AutoSize = true;
            this.chkMotor.Location = new System.Drawing.Point(347, 66);
            this.chkMotor.Name = "chkMotor";
            this.chkMotor.Size = new System.Drawing.Size(53, 17);
            this.chkMotor.TabIndex = 21;
            this.chkMotor.Text = "Motor";
            this.chkMotor.UseVisualStyleBackColor = true;
            // 
            // chkBagagedrager
            // 
            this.chkBagagedrager.AutoSize = true;
            this.chkBagagedrager.Location = new System.Drawing.Point(347, 120);
            this.chkBagagedrager.Name = "chkBagagedrager";
            this.chkBagagedrager.Size = new System.Drawing.Size(93, 17);
            this.chkBagagedrager.TabIndex = 22;
            this.chkBagagedrager.Text = "Bagagedrager";
            this.chkBagagedrager.UseVisualStyleBackColor = true;
            // 
            // frmVoertuigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 282);
            this.Controls.Add(this.chkBagagedrager);
            this.Controls.Add(this.chkMotor);
            this.Controls.Add(this.btnToon2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNummerplaat);
            this.Controls.Add(this.lblNummerplaat);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtAantalWielen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmVoertuigen";
            this.Text = "Voertuigen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAantalWielen;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblNummerplaat;
        private System.Windows.Forms.TextBox txtNummerplaat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFiets;
        private System.Windows.Forms.RadioButton radAuto;
        private System.Windows.Forms.Button btnToon2;
        private System.Windows.Forms.CheckBox chkMotor;
        private System.Windows.Forms.CheckBox chkBagagedrager;
    }
}

