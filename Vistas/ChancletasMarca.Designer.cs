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
            this.lbTitutlo = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btBuscarPorColor = new System.Windows.Forms.Button();
            this.btBuscarPorTalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitutlo
            // 
            this.lbTitutlo.AutoSize = true;
            this.lbTitutlo.Location = new System.Drawing.Point(330, 9);
            this.lbTitutlo.Name = "lbTitutlo";
            this.lbTitutlo.Size = new System.Drawing.Size(111, 13);
            this.lbTitutlo.TabIndex = 0;
            this.lbTitutlo.Text = "Chancletas por Marca";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(320, 58);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 1;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(351, 121);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 2;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btBuscarPorColor
            // 
            this.btBuscarPorColor.Location = new System.Drawing.Point(143, 76);
            this.btBuscarPorColor.Name = "btBuscarPorColor";
            this.btBuscarPorColor.Size = new System.Drawing.Size(97, 23);
            this.btBuscarPorColor.TabIndex = 5;
            this.btBuscarPorColor.Text = "Buscar por Color";
            this.btBuscarPorColor.UseVisualStyleBackColor = true;
            this.btBuscarPorColor.Click += new System.EventHandler(this.btBuscarPorColor_Click);
            // 
            // btBuscarPorTalle
            // 
            this.btBuscarPorTalle.Location = new System.Drawing.Point(143, 34);
            this.btBuscarPorTalle.Name = "btBuscarPorTalle";
            this.btBuscarPorTalle.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPorTalle.TabIndex = 6;
            this.btBuscarPorTalle.Text = "Buscar por Talle";
            this.btBuscarPorTalle.UseVisualStyleBackColor = true;
            this.btBuscarPorTalle.Click += new System.EventHandler(this.btBuscarPorTalle_Click);
            // 
            // ChancletasMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btBuscarPorTalle);
            this.Controls.Add(this.btBuscarPorColor);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBuscarPorColor;
        private System.Windows.Forms.Button btBuscarPorTalle;
    }
}