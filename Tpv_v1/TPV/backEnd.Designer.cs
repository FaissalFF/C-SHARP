﻿
namespace TPV
{
    partial class backEnd
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnInsertarFruta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPral = new System.Windows.Forms.Label();
            this.flpFrutas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.gbInsertar = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminarFruta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnExclamacion = new System.Windows.Forms.Button();
            this.pbImagenCargada = new System.Windows.Forms.PictureBox();
            this.gbInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(97, 40);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(143, 37);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Añadir Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnInsertarFruta
            // 
            this.btnInsertarFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarFruta.Location = new System.Drawing.Point(97, 90);
            this.btnInsertarFruta.Name = "btnInsertarFruta";
            this.btnInsertarFruta.Size = new System.Drawing.Size(143, 37);
            this.btnInsertarFruta.TabIndex = 1;
            this.btnInsertarFruta.Text = "Insertar Fruta";
            this.btnInsertarFruta.UseVisualStyleBackColor = true;
            this.btnInsertarFruta.Click += new System.EventHandler(this.btnInsertarFruta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(97, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPral
            // 
            this.lblPral.AutoSize = true;
            this.lblPral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPral.Location = new System.Drawing.Point(406, 32);
            this.lblPral.Name = "lblPral";
            this.lblPral.Size = new System.Drawing.Size(0, 20);
            this.lblPral.TabIndex = 3;
            // 
            // flpFrutas
            // 
            this.flpFrutas.Location = new System.Drawing.Point(410, 61);
            this.flpFrutas.Name = "flpFrutas";
            this.flpFrutas.Size = new System.Drawing.Size(550, 168);
            this.flpFrutas.TabIndex = 4;
            this.flpFrutas.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(10, 95);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(10, 130);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(68, 20);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.Location = new System.Drawing.Point(10, 173);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(106, 20);
            this.lblProcedencia.TabIndex = 9;
            this.lblProcedencia.Text = "Procedencia.";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(10, 214);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock:";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(144, 124);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(209, 35);
            this.btnCargarImagen.TabIndex = 11;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(144, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 26);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(144, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(209, 26);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedencia.Location = new System.Drawing.Point(144, 170);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(209, 26);
            this.txtProcedencia.TabIndex = 15;
            this.txtProcedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(144, 211);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(209, 26);
            this.txtStock.TabIndex = 16;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadir.Location = new System.Drawing.Point(385, 205);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(88, 39);
            this.btnAniadir.TabIndex = 17;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // gbInsertar
            // 
            this.gbInsertar.Controls.Add(this.pbImagenCargada);
            this.gbInsertar.Controls.Add(this.txtId);
            this.gbInsertar.Controls.Add(this.lblId);
            this.gbInsertar.Controls.Add(this.btnGuardarCambios);
            this.gbInsertar.Controls.Add(this.btnAniadir);
            this.gbInsertar.Controls.Add(this.lblNombre);
            this.gbInsertar.Controls.Add(this.txtStock);
            this.gbInsertar.Controls.Add(this.lblPrecio);
            this.gbInsertar.Controls.Add(this.txtProcedencia);
            this.gbInsertar.Controls.Add(this.lblImagen);
            this.gbInsertar.Controls.Add(this.txtPrecio);
            this.gbInsertar.Controls.Add(this.lblProcedencia);
            this.gbInsertar.Controls.Add(this.txtNombre);
            this.gbInsertar.Controls.Add(this.lblStock);
            this.gbInsertar.Controls.Add(this.btnCargarImagen);
            this.gbInsertar.Location = new System.Drawing.Point(410, 12);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(497, 268);
            this.gbInsertar.TabIndex = 18;
            this.gbInsertar.TabStop = false;
            this.gbInsertar.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(144, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(209, 26);
            this.txtId.TabIndex = 20;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(10, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(144, 205);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(209, 39);
            this.btnGuardarCambios.TabIndex = 18;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEliminarFruta
            // 
            this.btnEliminarFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFruta.Location = new System.Drawing.Point(97, 193);
            this.btnEliminarFruta.Name = "btnEliminarFruta";
            this.btnEliminarFruta.Size = new System.Drawing.Size(143, 37);
            this.btnEliminarFruta.TabIndex = 20;
            this.btnEliminarFruta.Text = "Eliminar Fruta";
            this.btnEliminarFruta.UseVisualStyleBackColor = true;
            this.btnEliminarFruta.Click += new System.EventHandler(this.btnEliminarFruta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(97, 142);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 37);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar Fruta";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnExclamacion
            // 
            this.btnExclamacion.AutoSize = true;
            this.btnExclamacion.Location = new System.Drawing.Point(258, 40);
            this.btnExclamacion.Name = "btnExclamacion";
            this.btnExclamacion.Size = new System.Drawing.Size(37, 37);
            this.btnExclamacion.TabIndex = 22;
            this.btnExclamacion.UseVisualStyleBackColor = true;
            this.btnExclamacion.Visible = false;
            this.btnExclamacion.Click += new System.EventHandler(this.btnExclamacion_Click_1);
            // 
            // pbImagenCargada
            // 
            this.pbImagenCargada.Location = new System.Drawing.Point(385, 106);
            this.pbImagenCargada.Name = "pbImagenCargada";
            this.pbImagenCargada.Size = new System.Drawing.Size(88, 69);
            this.pbImagenCargada.TabIndex = 21;
            this.pbImagenCargada.TabStop = false;
            // 
            // backEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 328);
            this.Controls.Add(this.btnExclamacion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFruta);
            this.Controls.Add(this.gbInsertar);
            this.Controls.Add(this.flpFrutas);
            this.Controls.Add(this.lblPral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsertarFruta);
            this.Controls.Add(this.btnStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backEnd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.backEnd_Load);
            this.gbInsertar.ResumeLayout(false);
            this.gbInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnInsertarFruta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPral;
        private System.Windows.Forms.FlowLayoutPanel flpFrutas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.GroupBox gbInsertar;
        private System.Windows.Forms.Button btnEliminarFruta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExclamacion;
        private System.Windows.Forms.PictureBox pbImagenCargada;
    }
}