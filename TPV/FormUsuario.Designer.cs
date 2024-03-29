﻿
namespace TPV
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnHacerReservas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConsumirProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(73, 47);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(409, 33);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Panel de control del Usuario";
            // 
            // btnHacerReservas
            // 
            this.btnHacerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnHacerReservas.Image")));
            this.btnHacerReservas.Location = new System.Drawing.Point(299, 114);
            this.btnHacerReservas.Name = "btnHacerReservas";
            this.btnHacerReservas.Size = new System.Drawing.Size(204, 147);
            this.btnHacerReservas.TabIndex = 7;
            this.btnHacerReservas.Text = "Hacer reservas";
            this.btnHacerReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHacerReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHacerReservas.UseVisualStyleBackColor = true;
            this.btnHacerReservas.Click += new System.EventHandler(this.btnHacerReservas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(168, 293);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(202, 57);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsumirProductos
            // 
            this.btnConsumirProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumirProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsumirProductos.Image")));
            this.btnConsumirProductos.Location = new System.Drawing.Point(24, 114);
            this.btnConsumirProductos.Name = "btnConsumirProductos";
            this.btnConsumirProductos.Size = new System.Drawing.Size(204, 147);
            this.btnConsumirProductos.TabIndex = 6;
            this.btnConsumirProductos.Text = "Consumir productos";
            this.btnConsumirProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsumirProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsumirProductos.UseVisualStyleBackColor = true;
            this.btnConsumirProductos.Click += new System.EventHandler(this.btnConsumirProductos_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 378);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnHacerReservas);
            this.Controls.Add(this.btnConsumirProductos);
            this.Controls.Add(this.lblAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarAplicacion);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnConsumirProductos;
        private System.Windows.Forms.Button btnHacerReservas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}