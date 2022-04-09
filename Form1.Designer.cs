namespace Chancletas
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
            this.components = new System.ComponentModel.Container();
            this.btConsultas = new System.Windows.Forms.Button();
            this.btCreacion = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btConsultas
            // 
            this.btConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(184, 102);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(180, 177);
            this.btConsultas.TabIndex = 0;
            this.btConsultas.Text = "Cosultas / Busar";
            this.btConsultas.UseVisualStyleBackColor = false;
            this.btConsultas.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCreacion
            // 
            this.btCreacion.Enabled = false;
            this.btCreacion.Location = new System.Drawing.Point(412, 102);
            this.btCreacion.Name = "btCreacion";
            this.btCreacion.Size = new System.Drawing.Size(180, 177);
            this.btCreacion.TabIndex = 1;
            this.btCreacion.Text = "Creacion";
            this.btCreacion.UseVisualStyleBackColor = true;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbHora.Location = new System.Drawing.Point(12, 9);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(54, 25);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lbfecha.Location = new System.Drawing.Point(12, 43);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(49, 20);
            this.lbfecha.TabIndex = 3;
            this.lbfecha.Text = "fecha";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btCreacion);
            this.Controls.Add(this.btConsultas);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsultas;
        internal System.Windows.Forms.Button btCreacion;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Timer horaFecha;
    }
}

