namespace Chancletas.Vistas
{
    partial class ChancletasColorMarcaTalle
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbxSelecColor = new System.Windows.Forms.ComboBox();
            this.cbxSelecTalle = new System.Windows.Forms.ComboBox();
            this.cbxSelecMarca = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(322, 9);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(164, 13);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Chancletas por Color-Talle-Marca";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(370, 111);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbxSelecColor
            // 
            this.cbxSelecColor.FormattingEnabled = true;
            this.cbxSelecColor.Location = new System.Drawing.Point(129, 84);
            this.cbxSelecColor.Name = "cbxSelecColor";
            this.cbxSelecColor.Size = new System.Drawing.Size(160, 21);
            this.cbxSelecColor.TabIndex = 2;
            // 
            // cbxSelecTalle
            // 
            this.cbxSelecTalle.FormattingEnabled = true;
            this.cbxSelecTalle.Location = new System.Drawing.Point(326, 84);
            this.cbxSelecTalle.Name = "cbxSelecTalle";
            this.cbxSelecTalle.Size = new System.Drawing.Size(161, 21);
            this.cbxSelecTalle.TabIndex = 3;
            // 
            // cbxSelecMarca
            // 
            this.cbxSelecMarca.FormattingEnabled = true;
            this.cbxSelecMarca.Location = new System.Drawing.Point(517, 84);
            this.cbxSelecMarca.Name = "cbxSelecMarca";
            this.cbxSelecMarca.Size = new System.Drawing.Size(160, 21);
            this.cbxSelecMarca.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ChancletasColorMarcaTalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxSelecMarca);
            this.Controls.Add(this.cbxSelecTalle);
            this.Controls.Add(this.cbxSelecColor);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbtitulo);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ChancletasColorMarcaTalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChancletasColorMarcaTalle";
            this.Load += new System.EventHandler(this.ChancletasColorMarcaTalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cbxSelecColor;
        private System.Windows.Forms.ComboBox cbxSelecTalle;
        private System.Windows.Forms.ComboBox cbxSelecMarca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}