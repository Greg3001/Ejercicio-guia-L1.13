namespace Cliente2
{
    partial class Form2
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
            this.numForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enviar1 = new System.Windows.Forms.Button();
            this.temp1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enviar2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numForm
            // 
            this.numForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numForm.Location = new System.Drawing.Point(72, 346);
            this.numForm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numForm.Name = "numForm";
            this.numForm.Size = new System.Drawing.Size(194, 175);
            this.numForm.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.enviar2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.temp2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enviar1);
            this.groupBox1.Controls.Add(this.temp1);
            this.groupBox1.Location = new System.Drawing.Point(417, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(874, 567);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura";
            // 
            // enviar1
            // 
            this.enviar1.Location = new System.Drawing.Point(406, 127);
            this.enviar1.Margin = new System.Windows.Forms.Padding(6);
            this.enviar1.Name = "enviar1";
            this.enviar1.Size = new System.Drawing.Size(150, 44);
            this.enviar1.TabIndex = 5;
            this.enviar1.Text = "Enviar";
            this.enviar1.UseVisualStyleBackColor = true;
            this.enviar1.Click += new System.EventHandler(this.enviar1_Click);
            // 
            // temp1
            // 
            this.temp1.Location = new System.Drawing.Point(317, 64);
            this.temp1.Margin = new System.Windows.Forms.Padding(6);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(324, 31);
            this.temp1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "ºC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura";
            // 
            // temp2
            // 
            this.temp2.Location = new System.Drawing.Point(317, 251);
            this.temp2.Margin = new System.Windows.Forms.Padding(6);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(324, 31);
            this.temp2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "ºF";
            // 
            // enviar2
            // 
            this.enviar2.Location = new System.Drawing.Point(406, 308);
            this.enviar2.Margin = new System.Windows.Forms.Padding(6);
            this.enviar2.Name = "enviar2";
            this.enviar2.Size = new System.Drawing.Size(150, 44);
            this.enviar2.TabIndex = 10;
            this.enviar2.Text = "Enviar";
            this.enviar2.UseVisualStyleBackColor = true;
            this.enviar2.Click += new System.EventHandler(this.enviar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 952);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enviar1;
        private System.Windows.Forms.TextBox temp1;
        private System.Windows.Forms.Button enviar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}