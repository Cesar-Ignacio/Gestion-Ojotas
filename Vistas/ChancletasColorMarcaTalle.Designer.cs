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
            this.components = new System.ComponentModel.Container();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbxSelecColor = new System.Windows.Forms.ComboBox();
            this.cbxSelecTalle = new System.Windows.Forms.ComboBox();
            this.cbxSelecMarca = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBusColor = new System.Windows.Forms.Button();
            this.btBusMarca = new System.Windows.Forms.Button();
            this.btBuscarTalle = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(323, 25);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(164, 13);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Chancletas por Color-Talle-Marca";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBuscar.Location = new System.Drawing.Point(370, 111);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(88, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbxSelecColor
            // 
            this.cbxSelecColor.FormattingEnabled = true;
            this.cbxSelecColor.ItemHeight = 13;
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
            // btBusColor
            // 
            this.btBusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBusColor.Location = new System.Drawing.Point(171, 326);
            this.btBusColor.Name = "btBusColor";
            this.btBusColor.Size = new System.Drawing.Size(118, 23);
            this.btBusColor.TabIndex = 7;
            this.btBusColor.Text = "Buscar por Color";
            this.btBusColor.UseVisualStyleBackColor = false;
            this.btBusColor.Click += new System.EventHandler(this.btBusColor_Click);
            // 
            // btBusMarca
            // 
            this.btBusMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBusMarca.Location = new System.Drawing.Point(352, 326);
            this.btBusMarca.Name = "btBusMarca";
            this.btBusMarca.Size = new System.Drawing.Size(118, 23);
            this.btBusMarca.TabIndex = 8;
            this.btBusMarca.Text = "Buscar por Marca";
            this.btBusMarca.UseVisualStyleBackColor = false;
            this.btBusMarca.Click += new System.EventHandler(this.btBusMarca_Click);
            // 
            // btBuscarTalle
            // 
            this.btBuscarTalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btBuscarTalle.Location = new System.Drawing.Point(514, 326);
            this.btBuscarTalle.Name = "btBuscarTalle";
            this.btBuscarTalle.Size = new System.Drawing.Size(118, 23);
            this.btBuscarTalle.TabIndex = 9;
            this.btBuscarTalle.Text = "Buscar por Talle";
            this.btBuscarTalle.UseVisualStyleBackColor = false;
            this.btBuscarTalle.Click += new System.EventHandler(this.btBuscarTalle_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lbfecha.Location = new System.Drawing.Point(12, 43);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(49, 20);
            this.lbfecha.TabIndex = 11;
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
            this.lbHora.TabIndex = 10;
            this.lbHora.Text = "Hora";
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // ChancletasColorMarcaTalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btBuscarTalle);
            this.Controls.Add(this.btBusMarca);
            this.Controls.Add(this.btBusColor);
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
        private System.Windows.Forms.Button btBusColor;
        private System.Windows.Forms.Button btBusMarca;
        private System.Windows.Forms.Button btBuscarTalle;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}