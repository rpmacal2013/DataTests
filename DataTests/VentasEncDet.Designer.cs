namespace DataTests
{
    partial class VentasEncDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasEncDet));
            this.dgvVentasEncabezado = new System.Windows.Forms.DataGridView();
            this.dgvVentasDetalle = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotalMesArticulo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasEncabezado
            // 
            this.dgvVentasEncabezado.AllowUserToAddRows = false;
            this.dgvVentasEncabezado.AllowUserToDeleteRows = false;
            this.dgvVentasEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasEncabezado.Location = new System.Drawing.Point(12, 41);
            this.dgvVentasEncabezado.Name = "dgvVentasEncabezado";
            this.dgvVentasEncabezado.ReadOnly = true;
            this.dgvVentasEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasEncabezado.Size = new System.Drawing.Size(776, 201);
            this.dgvVentasEncabezado.TabIndex = 0;
            this.dgvVentasEncabezado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasEncabezado_CellClick);
            // 
            // dgvVentasDetalle
            // 
            this.dgvVentasDetalle.AllowUserToAddRows = false;
            this.dgvVentasDetalle.AllowUserToDeleteRows = false;
            this.dgvVentasDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasDetalle.Location = new System.Drawing.Point(12, 265);
            this.dgvVentasDetalle.Name = "dgvVentasDetalle";
            this.dgvVentasDetalle.ReadOnly = true;
            this.dgvVentasDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasDetalle.Size = new System.Drawing.Size(776, 285);
            this.dgvVentasDetalle.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(27, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnTotalMesArticulo
            // 
            this.btnTotalMesArticulo.Location = new System.Drawing.Point(198, 12);
            this.btnTotalMesArticulo.Name = "btnTotalMesArticulo";
            this.btnTotalMesArticulo.Size = new System.Drawing.Size(159, 23);
            this.btnTotalMesArticulo.TabIndex = 5;
            this.btnTotalMesArticulo.Text = "Total Artículos por Mes";
            this.btnTotalMesArticulo.UseVisualStyleBackColor = true;
            this.btnTotalMesArticulo.Click += new System.EventHandler(this.btnTotalMesArticulo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VentasEncDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTotalMesArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvVentasDetalle);
            this.Controls.Add(this.dgvVentasEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentasEncDet";
            this.Text = "VentasEncDet";
            this.Load += new System.EventHandler(this.VentasEncDet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasEncabezado;
        private System.Windows.Forms.DataGridView dgvVentasDetalle;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTotalMesArticulo;
        private System.Windows.Forms.Button btnSalir;
    }
}