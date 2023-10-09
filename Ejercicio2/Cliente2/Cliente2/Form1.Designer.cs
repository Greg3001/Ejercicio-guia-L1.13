namespace Cliente2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Conectar = new System.Windows.Forms.Button();
            this.NuevoForm = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.LabelCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(270, 123);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(581, 149);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // NuevoForm
            // 
            this.NuevoForm.Location = new System.Drawing.Point(270, 406);
            this.NuevoForm.Name = "NuevoForm";
            this.NuevoForm.Size = new System.Drawing.Size(581, 149);
            this.NuevoForm.TabIndex = 1;
            this.NuevoForm.Text = "Nuevo Formulario";
            this.NuevoForm.UseVisualStyleBackColor = true;
            this.NuevoForm.Click += new System.EventHandler(this.NuevoForm_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(261, 703);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(581, 149);
            this.Desconectar.TabIndex = 2;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // contLbl
            // 
            this.contLbl.AutoSize = true;
            this.contLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.contLbl.Location = new System.Drawing.Point(1169, 468);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(0, 25);
            this.contLbl.TabIndex = 3;
            // 
            // LabelCont
            // 
            this.LabelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCont.Location = new System.Drawing.Point(1038, 406);
            this.LabelCont.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCont.Name = "LabelCont";
            this.LabelCont.Size = new System.Drawing.Size(294, 175);
            this.LabelCont.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 1078);
            this.Controls.Add(this.LabelCont);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.NuevoForm);
            this.Controls.Add(this.Conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button NuevoForm;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Label contLbl;
        private System.Windows.Forms.Label LabelCont;
    }
}

