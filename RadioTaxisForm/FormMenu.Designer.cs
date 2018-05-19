namespace RadioTaxisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administacionDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeCuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.menuStrip1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 61);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1187, 513);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administacionDeSociosToolStripMenuItem,
            this.administracionDeCuotasToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administacionDeSociosToolStripMenuItem
            // 
            this.administacionDeSociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSocioToolStripMenuItem,
            this.modificarSocioToolStripMenuItem,
            this.eliminarSocioToolStripMenuItem});
            this.administacionDeSociosToolStripMenuItem.Name = "administacionDeSociosToolStripMenuItem";
            this.administacionDeSociosToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.administacionDeSociosToolStripMenuItem.Text = "Administacion de Socios";
            this.administacionDeSociosToolStripMenuItem.Click += new System.EventHandler(this.administacionDeSociosToolStripMenuItem_Click);
            // 
            // agregarSocioToolStripMenuItem
            // 
            this.agregarSocioToolStripMenuItem.Name = "agregarSocioToolStripMenuItem";
            this.agregarSocioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarSocioToolStripMenuItem.Text = "Agregar Socio";
            // 
            // modificarSocioToolStripMenuItem
            // 
            this.modificarSocioToolStripMenuItem.Name = "modificarSocioToolStripMenuItem";
            this.modificarSocioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificarSocioToolStripMenuItem.Text = "Modificar Socio";
            // 
            // eliminarSocioToolStripMenuItem
            // 
            this.eliminarSocioToolStripMenuItem.Name = "eliminarSocioToolStripMenuItem";
            this.eliminarSocioToolStripMenuItem.ShowShortcutKeys = false;
            this.eliminarSocioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarSocioToolStripMenuItem.Text = "Eliminar Socio";
            this.eliminarSocioToolStripMenuItem.Click += new System.EventHandler(this.eliminarSocioToolStripMenuItem_Click);
            // 
            // administracionDeCuotasToolStripMenuItem
            // 
            this.administracionDeCuotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuotaToolStripMenuItem,
            this.modificarCuotaToolStripMenuItem,
            this.eliminarCuotaToolStripMenuItem});
            this.administracionDeCuotasToolStripMenuItem.Name = "administracionDeCuotasToolStripMenuItem";
            this.administracionDeCuotasToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.administracionDeCuotasToolStripMenuItem.Text = "Administracion de Cuotas";
            // 
            // agregarCuotaToolStripMenuItem
            // 
            this.agregarCuotaToolStripMenuItem.Name = "agregarCuotaToolStripMenuItem";
            this.agregarCuotaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.agregarCuotaToolStripMenuItem.Text = "Agregar Cuota";
            // 
            // modificarCuotaToolStripMenuItem
            // 
            this.modificarCuotaToolStripMenuItem.Name = "modificarCuotaToolStripMenuItem";
            this.modificarCuotaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modificarCuotaToolStripMenuItem.Text = "Modificar Cuota";
            // 
            // eliminarCuotaToolStripMenuItem
            // 
            this.eliminarCuotaToolStripMenuItem.Name = "eliminarCuotaToolStripMenuItem";
            this.eliminarCuotaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarCuotaToolStripMenuItem.Text = "Eliminar Cuota";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hora});
            this.statusStrip1.Location = new System.Drawing.Point(23, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hora
            // 
            this.hora.BackColor = System.Drawing.Color.Gray;
            this.hora.Name = "hora";
            this.hora.RightToLeftAutoMirrorImage = true;
            this.hora.Size = new System.Drawing.Size(17, 17);
            this.hora.Text = "--";
            this.hora.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMenu";
            this.Padding = new System.Windows.Forms.Padding(23, 61, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Asociacion de Radio Taxis de La Region de Los Lagos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administacionDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDeCuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hora;
        private System.Windows.Forms.Timer timer1;
    }
}