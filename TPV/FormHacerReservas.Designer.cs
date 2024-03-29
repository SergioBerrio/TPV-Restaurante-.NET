﻿
namespace TPV
{
    partial class FormHacerReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHacerReservas));
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoModificar = new System.Windows.Forms.ComboBox();
            this.mcModificar = new System.Windows.Forms.MonthCalendar();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbAnadir = new System.Windows.Forms.GroupBox();
            this.mcInsertar = new System.Windows.Forms.MonthCalendar();
            this.gbTipoReserva = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lbReservas = new System.Windows.Forms.ListBox();
            this.gpReservas = new System.Windows.Forms.GroupBox();
            this.gbEliminar.SuspendLayout();
            this.gbModificar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAnadir.SuspendLayout();
            this.gbTipoReserva.SuspendLayout();
            this.gpReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.Location = new System.Drawing.Point(495, 275);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(236, 116);
            this.gbEliminar.TabIndex = 36;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar reserva";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(23, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 49);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.groupBox1);
            this.gbModificar.Controls.Add(this.mcModificar);
            this.gbModificar.Controls.Add(this.btnModificar);
            this.gbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificar.Location = new System.Drawing.Point(22, 275);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(454, 228);
            this.gbModificar.TabIndex = 35;
            this.gbModificar.TabStop = false;
            this.gbModificar.Text = "Modificar reserva";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoModificar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 80);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de reserva";
            // 
            // cbTipoModificar
            // 
            this.cbTipoModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoModificar.FormattingEnabled = true;
            this.cbTipoModificar.Items.AddRange(new object[] {
            "Comida",
            "Cena"});
            this.cbTipoModificar.Location = new System.Drawing.Point(21, 41);
            this.cbTipoModificar.Name = "cbTipoModificar";
            this.cbTipoModificar.Size = new System.Drawing.Size(147, 21);
            this.cbTipoModificar.TabIndex = 37;
            // 
            // mcModificar
            // 
            this.mcModificar.Location = new System.Drawing.Point(23, 42);
            this.mcModificar.Name = "mcModificar";
            this.mcModificar.TabIndex = 40;
            this.mcModificar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcModificar_DateSelected);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(239, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 48);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbAnadir
            // 
            this.gbAnadir.Controls.Add(this.mcInsertar);
            this.gbAnadir.Controls.Add(this.gbTipoReserva);
            this.gbAnadir.Controls.Add(this.btnAnadir);
            this.gbAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnadir.Location = new System.Drawing.Point(196, 27);
            this.gbAnadir.Name = "gbAnadir";
            this.gbAnadir.Size = new System.Drawing.Size(544, 220);
            this.gbAnadir.TabIndex = 34;
            this.gbAnadir.TabStop = false;
            this.gbAnadir.Text = "Añadir reserva";
            // 
            // mcInsertar
            // 
            this.mcInsertar.Location = new System.Drawing.Point(33, 36);
            this.mcInsertar.Name = "mcInsertar";
            this.mcInsertar.TabIndex = 39;
            this.mcInsertar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcInsertar_DateSelected);
            // 
            // gbTipoReserva
            // 
            this.gbTipoReserva.Controls.Add(this.cbTipo);
            this.gbTipoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoReserva.Location = new System.Drawing.Point(251, 36);
            this.gbTipoReserva.Name = "gbTipoReserva";
            this.gbTipoReserva.Size = new System.Drawing.Size(252, 80);
            this.gbTipoReserva.TabIndex = 38;
            this.gbTipoReserva.TabStop = false;
            this.gbTipoReserva.Text = "Tipo de reserva";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Comida",
            "Cena"});
            this.cbTipo.Location = new System.Drawing.Point(21, 41);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(215, 21);
            this.cbTipo.TabIndex = 37;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAnadir.Image")));
            this.btnAnadir.Location = new System.Drawing.Point(299, 150);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(172, 48);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(603, 461);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(128, 42);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lbReservas
            // 
            this.lbReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservas.FormattingEnabled = true;
            this.lbReservas.ItemHeight = 18;
            this.lbReservas.Location = new System.Drawing.Point(23, 36);
            this.lbReservas.Name = "lbReservas";
            this.lbReservas.ScrollAlwaysVisible = true;
            this.lbReservas.Size = new System.Drawing.Size(109, 166);
            this.lbReservas.TabIndex = 33;
            // 
            // gpReservas
            // 
            this.gpReservas.Controls.Add(this.lbReservas);
            this.gpReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpReservas.Location = new System.Drawing.Point(22, 27);
            this.gpReservas.Name = "gpReservas";
            this.gpReservas.Size = new System.Drawing.Size(152, 219);
            this.gpReservas.TabIndex = 37;
            this.gpReservas.TabStop = false;
            this.gpReservas.Text = "Tus reservas";
            // 
            // FormHacerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 525);
            this.Controls.Add(this.gpReservas);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbAnadir);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHacerReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacer reservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarAplicacion);
            this.Load += new System.EventHandler(this.FormHacerReservas_Load);
            this.gbEliminar.ResumeLayout(false);
            this.gbModificar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbAnadir.ResumeLayout(false);
            this.gbTipoReserva.ResumeLayout(false);
            this.gpReservas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbAnadir;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lbReservas;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox gbTipoReserva;
        private System.Windows.Forms.MonthCalendar mcInsertar;
        private System.Windows.Forms.MonthCalendar mcModificar;
        private System.Windows.Forms.GroupBox gpReservas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoModificar;
    }
}