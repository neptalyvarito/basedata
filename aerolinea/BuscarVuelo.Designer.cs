namespace aerolinea
{
    partial class BuscarVuelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVuelosDisponibles = new System.Windows.Forms.DataGridView();
            this.dtgTarifas = new System.Windows.Forms.DataGridView();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cod_Vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Aeropuerto_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Aeropuerto_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elige un vuelo de ida";
            // 
            // dtgVuelosDisponibles
            // 
            this.dtgVuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Vuelo,
            this.Cod_Aeropuerto_Origen,
            this.Cod_Aeropuerto_Destino,
            this.Fecha_Salida,
            this.Fecha_Llegada,
            this.Costo_Vuelo});
            this.dtgVuelosDisponibles.Location = new System.Drawing.Point(21, 110);
            this.dtgVuelosDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.dtgVuelosDisponibles.Name = "dtgVuelosDisponibles";
            this.dtgVuelosDisponibles.RowHeadersWidth = 51;
            this.dtgVuelosDisponibles.RowTemplate.Height = 24;
            this.dtgVuelosDisponibles.Size = new System.Drawing.Size(427, 347);
            this.dtgVuelosDisponibles.TabIndex = 10;
           // 
            // dtgTarifas
            // 
            this.dtgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTarifas.Location = new System.Drawing.Point(472, 110);
            this.dtgTarifas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTarifas.Name = "dtgTarifas";
            this.dtgTarifas.RowHeadersWidth = 51;
            this.dtgTarifas.RowTemplate.Height = 24;
            this.dtgTarifas.Size = new System.Drawing.Size(283, 347);
            this.dtgTarifas.TabIndex = 11;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Crimson;
            this.btnCliente.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCliente.Location = new System.Drawing.Point(472, 486);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(283, 33);
            this.btnCliente.TabIndex = 12;
            this.btnCliente.Text = "Buscar Asientos";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aerolinea.Properties.Resources.latam_partesuperior;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Cod_Vuelo
            // 
            this.Cod_Vuelo.DataPropertyName = "Cod_Vuelo";
            this.Cod_Vuelo.HeaderText = "Vuelo";
            this.Cod_Vuelo.Name = "Cod_Vuelo";
            // 
            // Cod_Aeropuerto_Origen
            // 
            this.Cod_Aeropuerto_Origen.DataPropertyName = "Cod_Aeropuerto_Origen";
            this.Cod_Aeropuerto_Origen.HeaderText = "Aeropuerto Salida";
            this.Cod_Aeropuerto_Origen.Name = "Cod_Aeropuerto_Origen";
            // 
            // Cod_Aeropuerto_Destino
            // 
            this.Cod_Aeropuerto_Destino.DataPropertyName = "Cod_Aeropuerto_Destino";
            this.Cod_Aeropuerto_Destino.HeaderText = "Aeropuerto Destino";
            this.Cod_Aeropuerto_Destino.Name = "Cod_Aeropuerto_Destino";
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.DataPropertyName = "Fecha_Salida";
            this.Fecha_Salida.HeaderText = "Fecha Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            // 
            // Fecha_Llegada
            // 
            this.Fecha_Llegada.DataPropertyName = "Fecha_Llegada";
            this.Fecha_Llegada.HeaderText = "Fecha llegada";
            this.Fecha_Llegada.Name = "Fecha_Llegada";
            // 
            // Costo_Vuelo
            // 
            this.Costo_Vuelo.DataPropertyName = "Costo_Vuelo";
            this.Costo_Vuelo.HeaderText = "Costo vuelo";
            this.Costo_Vuelo.Name = "Costo_Vuelo";
            // 
            // BuscarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 547);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.dtgTarifas);
            this.Controls.Add(this.dtgVuelosDisponibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarVuelo";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.BuscarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgVuelosDisponibles;
        private System.Windows.Forms.DataGridView dtgTarifas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Aeropuerto_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Aeropuerto_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Vuelo;
    }
}