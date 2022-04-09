namespace Chancletas.Vistas
{
    partial class ChancletasMarca
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
            this.components = new System.ComponentModel.Container();
            this.lbTitutlo = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBusColTallMar = new System.Windows.Forms.Button();
            this.btBuscarPorColor = new System.Windows.Forms.Button();
            this.btBuscarPorTalle = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitutlo
            // 
            this.lbTitutlo.AutoSize = true;
            this.lbTitutlo.Location = new System.Drawing.Point(352, 37);
            this.lbTitutlo.Name = "lbTitutlo";
            this.lbTitutlo.Size = new System.Drawing.Size(111, 13);
            this.lbTitutlo.TabIndex = 0;
            this.lbTitutlo.Text = "Chancletas por Marca";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(329, 79);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(158, 21);
            this.cbxMarca.TabIndex = 1;
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btbuscar.Location = new System.Drawing.Point(365, 106);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(85, 38);
            this.btbuscar.TabIndex = 2;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btBusColTallMar
            // 
            this.btBusColTallMar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btBusColTallMar.Location = new System.Drawing.Point(502, 311);
            this.btBusColTallMar.Name = "btBusColTallMar";
            this.btBusColTallMar.Size = new System.Drawing.Size(128, 33);
            this.btBusColTallMar.TabIndex = 4;
            this.btBusColTallMar.Text = "Buscar por Tal-Col-Mar";
            this.btBusColTallMar.UseVisualStyleBackColor = false;
            this.btBusColTallMar.Click += new System.EventHandler(this.btBusColTallMar_Click);
            // 
            // btBuscarPorColor
            // 
            this.btBuscarPorColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscarPorColor.Location = new System.Drawing.Point(366, 311);
            this.btBuscarPorColor.Name = "btBuscarPorColor";
            this.btBuscarPorColor.Size = new System.Drawing.Size(97, 33);
            this.btBuscarPorColor.TabIndex = 5;
            this.btBuscarPorColor.Text = "Buscar por Color";
            this.btBuscarPorColor.UseVisualStyleBackColor = false;
            this.btBuscarPorColor.Click += new System.EventHandler(this.btBuscarPorColor_Click);
            // 
            // btBuscarPorTalle
            // 
            this.btBuscarPorTalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBuscarPorTalle.Location = new System.Drawing.Point(210, 311);
            this.btBuscarPorTalle.Name = "btBuscarPorTalle";
            this.btBuscarPorTalle.Size = new System.Drawing.Size(119, 33);
            this.btBuscarPorTalle.TabIndex = 6;
            this.btBuscarPorTalle.Text = "Buscar por Talle";
            this.btBuscarPorTalle.UseVisualStyleBackColor = false;
            this.btBuscarPorTalle.Click += new System.EventHandler(this.btBuscarPorTalle_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lbfecha.Location = new System.Drawing.Point(12, 43);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(49, 20);
            this.lbfecha.TabIndex = 8;
            this.lbfecha.Text = "fecha";
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
            this.lbHora.TabIndex = 7;
            this.lbHora.Text = "Hora";
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // ChancletasMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btBuscarPorTalle);
            this.Controls.Add(this.btBuscarPorColor);
            this.Controls.Add(this.btBusColTallMar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lbTitutlo);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ChancletasMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChancletasMarca";
            this.Load += new System.EventHandler(this.ChancletasMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitutlo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBusColTallMar;
        private System.Windows.Forms.Button btBuscarPorColor;
        private System.Windows.Forms.Button btBuscarPorTalle;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}