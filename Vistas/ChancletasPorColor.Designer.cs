namespace Chancletas.Vistas
{
    partial class ChancletasPorColor
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btBusTalle = new System.Windows.Forms.Button();
            this.btBuscarMarca = new System.Windows.Forms.Button();
            this.btBuscarColTalMar = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
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
            this.btbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btbuscar.Location = new System.Drawing.Point(348, 101);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(91, 37);
            this.btbuscar.TabIndex = 3;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btBusTalle
            // 
            this.btBusTalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBusTalle.Location = new System.Drawing.Point(160, 324);
            this.btBusTalle.Name = "btBusTalle";
            this.btBusTalle.Size = new System.Drawing.Size(120, 23);
            this.btBusTalle.TabIndex = 4;
            this.btBusTalle.Text = "Buscar por Talle";
            this.btBusTalle.UseVisualStyleBackColor = false;
            this.btBusTalle.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btBuscarMarca
            // 
            this.btBuscarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscarMarca.Location = new System.Drawing.Point(319, 324);
            this.btBuscarMarca.Name = "btBuscarMarca";
            this.btBuscarMarca.Size = new System.Drawing.Size(120, 23);
            this.btBuscarMarca.TabIndex = 6;
            this.btBuscarMarca.Text = "Buscar por Marca";
            this.btBuscarMarca.UseVisualStyleBackColor = false;
            this.btBuscarMarca.Click += new System.EventHandler(this.button2_Click);
            // 
            // btBuscarColTalMar
            // 
            this.btBuscarColTalMar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btBuscarColTalMar.Location = new System.Drawing.Point(479, 324);
            this.btBuscarColTalMar.Name = "btBuscarColTalMar";
            this.btBuscarColTalMar.Size = new System.Drawing.Size(175, 23);
            this.btBuscarColTalMar.TabIndex = 7;
            this.btBuscarColTalMar.Text = "Buscar por Mar-Tal-Col";
            this.btBuscarColTalMar.UseVisualStyleBackColor = false;
            this.btBuscarColTalMar.Click += new System.EventHandler(this.btBuscarColTalMar_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lbfecha.Location = new System.Drawing.Point(12, 43);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(49, 20);
            this.lbfecha.TabIndex = 9;
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
            this.lbHora.TabIndex = 8;
            this.lbHora.Text = "Hora";
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // ChancletasPorColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btBuscarColTalMar);
            this.Controls.Add(this.btBuscarMarca);
            this.Controls.Add(this.btBusTalle);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lbTitulo);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ChancletasPorColor";
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
        private System.Windows.Forms.Button btBusTalle;
        private System.Windows.Forms.Button btBuscarMarca;
        private System.Windows.Forms.Button btBuscarColTalMar;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}