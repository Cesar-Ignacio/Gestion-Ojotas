namespace Chancletas.Vistas
{
    partial class ChancletasTalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTalles = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btBusColor = new System.Windows.Forms.Button();
            this.btBusMarca = new System.Windows.Forms.Button();
            this.btBusMarColTall = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chancletas por Talle";
            // 
            // cbxTalles
            // 
            this.cbxTalles.FormattingEnabled = true;
            this.cbxTalles.Location = new System.Drawing.Point(324, 74);
            this.cbxTalles.Name = "cbxTalles";
            this.cbxTalles.Size = new System.Drawing.Size(142, 21);
            this.cbxTalles.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBusColor
            // 
            this.btBusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBusColor.Location = new System.Drawing.Point(206, 326);
            this.btBusColor.Name = "btBusColor";
            this.btBusColor.Size = new System.Drawing.Size(100, 23);
            this.btBusColor.TabIndex = 4;
            this.btBusColor.Text = "Buscar por Color";
            this.btBusColor.UseVisualStyleBackColor = false;
            this.btBusColor.Click += new System.EventHandler(this.btBusColor_Click);
            // 
            // btBusMarca
            // 
            this.btBusMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBusMarca.Location = new System.Drawing.Point(350, 326);
            this.btBusMarca.Name = "btBusMarca";
            this.btBusMarca.Size = new System.Drawing.Size(100, 23);
            this.btBusMarca.TabIndex = 5;
            this.btBusMarca.Text = "Buscar por Marca";
            this.btBusMarca.UseVisualStyleBackColor = false;
            this.btBusMarca.Click += new System.EventHandler(this.btBusMarca_Click);
            // 
            // btBusMarColTall
            // 
            this.btBusMarColTall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btBusMarColTall.Location = new System.Drawing.Point(494, 326);
            this.btBusMarColTall.Name = "btBusMarColTall";
            this.btBusMarColTall.Size = new System.Drawing.Size(130, 23);
            this.btBusMarColTall.TabIndex = 6;
            this.btBusMarColTall.Text = "Buscar por Tall-Col-Mar";
            this.btBusMarColTall.UseVisualStyleBackColor = false;
            this.btBusMarColTall.Click += new System.EventHandler(this.button2_Click);
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
            // ChancletasTalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btBusMarColTall);
            this.Controls.Add(this.btBusMarca);
            this.Controls.Add(this.btBusColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxTalles);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ChancletasTalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar por Col-Tall-Mar";
            this.Load += new System.EventHandler(this.ChancletasTalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTalles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBusColor;
        private System.Windows.Forms.Button btBusMarca;
        private System.Windows.Forms.Button btBusMarColTall;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}