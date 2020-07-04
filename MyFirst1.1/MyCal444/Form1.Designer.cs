namespace MyCal444
{
    partial class Form1
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
            this.panelINPUTAREA = new System.Windows.Forms.Panel();
            this.textBoxOP2 = new System.Windows.Forms.TextBox();
            this.textBoxOP1 = new System.Windows.Forms.TextBox();
            this.panelCALAREA = new System.Windows.Forms.Panel();
            this.buttonpre = new System.Windows.Forms.Button();
            this.buttonEQU = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.buttonMUL = new System.Windows.Forms.Button();
            this.buttonSUB = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.panelSHOEAREA = new System.Windows.Forms.Panel();
            this.labelRESULT = new System.Windows.Forms.Label();
            this.buttonMOD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelINPUTAREA.SuspendLayout();
            this.panelCALAREA.SuspendLayout();
            this.panelSHOEAREA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelINPUTAREA);
            this.panel1.Controls.Add(this.panelCALAREA);
            this.panel1.Controls.Add(this.panelSHOEAREA);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 426);
            this.panel1.TabIndex = 0;
            // 
            // panelINPUTAREA
            // 
            this.panelINPUTAREA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelINPUTAREA.Controls.Add(this.textBoxOP2);
            this.panelINPUTAREA.Controls.Add(this.buttonpre);
            this.panelINPUTAREA.Controls.Add(this.textBoxOP1);
            this.panelINPUTAREA.Location = new System.Drawing.Point(3, 106);
            this.panelINPUTAREA.Name = "panelINPUTAREA";
            this.panelINPUTAREA.Size = new System.Drawing.Size(403, 306);
            this.panelINPUTAREA.TabIndex = 2;
            // 
            // textBoxOP2
            // 
            this.textBoxOP2.Font = new System.Drawing.Font("SimSun", 15F);
            this.textBoxOP2.Location = new System.Drawing.Point(74, 164);
            this.textBoxOP2.Name = "textBoxOP2";
            this.textBoxOP2.Size = new System.Drawing.Size(257, 30);
            this.textBoxOP2.TabIndex = 1;
            this.textBoxOP2.TextChanged += new System.EventHandler(this.textBoxOP2_TextChanged);
            // 
            // textBoxOP1
            // 
            this.textBoxOP1.Font = new System.Drawing.Font("SimSun", 15F);
            this.textBoxOP1.Location = new System.Drawing.Point(74, 62);
            this.textBoxOP1.Name = "textBoxOP1";
            this.textBoxOP1.Size = new System.Drawing.Size(257, 30);
            this.textBoxOP1.TabIndex = 0;
            this.textBoxOP1.TextChanged += new System.EventHandler(this.textBoxOP1_TextChanged);
            // 
            // panelCALAREA
            // 
            this.panelCALAREA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCALAREA.Controls.Add(this.buttonMOD);
            this.panelCALAREA.Controls.Add(this.buttonEQU);
            this.panelCALAREA.Controls.Add(this.buttonDIV);
            this.panelCALAREA.Controls.Add(this.buttonMUL);
            this.panelCALAREA.Controls.Add(this.buttonSUB);
            this.panelCALAREA.Controls.Add(this.buttonADD);
            this.panelCALAREA.Location = new System.Drawing.Point(458, 106);
            this.panelCALAREA.Name = "panelCALAREA";
            this.panelCALAREA.Size = new System.Drawing.Size(275, 306);
            this.panelCALAREA.TabIndex = 1;
            // 
            // buttonpre
            // 
            this.buttonpre.BackColor = System.Drawing.Color.Green;
            this.buttonpre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonpre.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonpre.ForeColor = System.Drawing.Color.White;
            this.buttonpre.Location = new System.Drawing.Point(160, 118);
            this.buttonpre.Name = "buttonpre";
            this.buttonpre.Size = new System.Drawing.Size(75, 23);
            this.buttonpre.TabIndex = 5;
            this.buttonpre.UseVisualStyleBackColor = false;
            // 
            // buttonEQU
            // 
            this.buttonEQU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEQU.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonEQU.Location = new System.Drawing.Point(168, 236);
            this.buttonEQU.Name = "buttonEQU";
            this.buttonEQU.Size = new System.Drawing.Size(75, 23);
            this.buttonEQU.TabIndex = 4;
            this.buttonEQU.Text = "=";
            this.buttonEQU.UseVisualStyleBackColor = false;
            this.buttonEQU.Click += new System.EventHandler(this.buttonEQU_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDIV.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonDIV.Location = new System.Drawing.Point(168, 171);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(75, 23);
            this.buttonDIV.TabIndex = 3;
            this.buttonDIV.Text = "÷";
            this.buttonDIV.UseVisualStyleBackColor = false;
            this.buttonDIV.Click += new System.EventHandler(this.buttonDIV_Click);
            // 
            // buttonMUL
            // 
            this.buttonMUL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonMUL.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonMUL.Location = new System.Drawing.Point(44, 171);
            this.buttonMUL.Name = "buttonMUL";
            this.buttonMUL.Size = new System.Drawing.Size(75, 23);
            this.buttonMUL.TabIndex = 2;
            this.buttonMUL.Text = "×";
            this.buttonMUL.UseVisualStyleBackColor = false;
            this.buttonMUL.Click += new System.EventHandler(this.buttonMUL_Click);
            // 
            // buttonSUB
            // 
            this.buttonSUB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSUB.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonSUB.Location = new System.Drawing.Point(168, 105);
            this.buttonSUB.Name = "buttonSUB";
            this.buttonSUB.Size = new System.Drawing.Size(75, 23);
            this.buttonSUB.TabIndex = 1;
            this.buttonSUB.Text = "－";
            this.buttonSUB.UseVisualStyleBackColor = false;
            this.buttonSUB.Click += new System.EventHandler(this.buttonSUB_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonADD.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonADD.Location = new System.Drawing.Point(44, 105);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "＋";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // panelSHOEAREA
            // 
            this.panelSHOEAREA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSHOEAREA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSHOEAREA.Controls.Add(this.labelRESULT);
            this.panelSHOEAREA.Location = new System.Drawing.Point(3, 0);
            this.panelSHOEAREA.Name = "panelSHOEAREA";
            this.panelSHOEAREA.Size = new System.Drawing.Size(730, 100);
            this.panelSHOEAREA.TabIndex = 0;
            // 
            // labelRESULT
            // 
            this.labelRESULT.AutoSize = true;
            this.labelRESULT.BackColor = System.Drawing.Color.Green;
            this.labelRESULT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRESULT.Font = new System.Drawing.Font("SimSun", 25F);
            this.labelRESULT.ForeColor = System.Drawing.Color.White;
            this.labelRESULT.Location = new System.Drawing.Point(320, 31);
            this.labelRESULT.Name = "labelRESULT";
            this.labelRESULT.Size = new System.Drawing.Size(119, 36);
            this.labelRESULT.TabIndex = 0;
            this.labelRESULT.Text = "Result";
            this.labelRESULT.Click += new System.EventHandler(this.labelRESULT_Click);
            // 
            // buttonMOD
            // 
            this.buttonMOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonMOD.Font = new System.Drawing.Font("SimSun", 13F);
            this.buttonMOD.Location = new System.Drawing.Point(44, 236);
            this.buttonMOD.Name = "buttonMOD";
            this.buttonMOD.Size = new System.Drawing.Size(75, 23);
            this.buttonMOD.TabIndex = 6;
            this.buttonMOD.Text = "%";
            this.buttonMOD.UseVisualStyleBackColor = false;
            this.buttonMOD.Click += new System.EventHandler(this.buttonMOD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelINPUTAREA.ResumeLayout(false);
            this.panelINPUTAREA.PerformLayout();
            this.panelCALAREA.ResumeLayout(false);
            this.panelSHOEAREA.ResumeLayout(false);
            this.panelSHOEAREA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelINPUTAREA;
        private System.Windows.Forms.TextBox textBoxOP2;
        private System.Windows.Forms.TextBox textBoxOP1;
        private System.Windows.Forms.Panel panelCALAREA;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Button buttonMUL;
        private System.Windows.Forms.Button buttonSUB;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Panel panelSHOEAREA;
        private System.Windows.Forms.Label labelRESULT;
        private System.Windows.Forms.Button buttonEQU;
        private System.Windows.Forms.Button buttonpre;
        private System.Windows.Forms.Button buttonMOD;
    }
}

