namespace Chancletas.Vistas
{
    partial class btChanMarca
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btChanTalle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(334, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(105, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Chancletas por Color";
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(318, 55);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(138, 21);
            this.cbxColor.TabIndex = 1;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(348, 101);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(91, 37);
            this.btbuscar.TabIndex = 3;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btChanTalle
            // 
            this.btChanTalle.Location = new System.Drawing.Point(116, 18);
            this.btChanTalle.Name = "btChanTalle";
            this.btChanTalle.Size = new System.Drawing.Size(120, 23);
            this.btChanTalle.TabIndex = 4;
            this.btChanTalle.Text = "Chancletas por Talle";
            this.btChanTalle.UseVisualStyleBackColor = true;
            this.btChanTalle.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chancletas por Marca";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btChanMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btChanTalle);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lbTitulo);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "btChanMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChancletasPorColor";
            this.Load += new System.EventHandler(this.ChancletasPorColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btChanTalle;
        private System.Windows.Forms.Button button2;
    }
}