﻿using System;

namespace Win.Tienda
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Checked = true;
            this.reportesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeProductosToolStripMenuItem,
            this.reportesDeClientesToolStripMenuItem,
            this.reportesDeVentasToolStripMenuItem,
            this.reporteDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // reportesDeClientesToolStripMenuItem
            // 
            this.reportesDeClientesToolStripMenuItem.Name = "reportesDeClientesToolStripMenuItem";
            this.reportesDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reportesDeClientesToolStripMenuItem.Text = "Reportes de Clientes";
            // 
            // reportesDeVentasToolStripMenuItem
            // 
            this.reportesDeVentasToolStripMenuItem.Name = "reportesDeVentasToolStripMenuItem";
            this.reportesDeVentasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reportesDeVentasToolStripMenuItem.Text = "Reportes de Ventas";
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            this.reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            this.reporteDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas";
            this.reporteDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.administraciónDeUsuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // administraciónDeUsuariosToolStripMenuItem
            // 
            this.administraciónDeUsuariosToolStripMenuItem.Name = "administraciónDeUsuariosToolStripMenuItem";
            this.administraciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.administraciónDeUsuariosToolStripMenuItem.Text = "Administración de Usuarios";
            this.administraciónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeUsuariosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(436, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 238);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}