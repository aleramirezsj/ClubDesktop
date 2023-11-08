namespace ClubDesktop
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            sociosToolStripMenuItem = new ToolStripMenuItem();
            gestiToolStripMenuItem = new ToolStripMenuItem();
            listadoDeSociosToolStripMenuItem = new ToolStripMenuItem();
            actividadesToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeActividadesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeActividadesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem = new ToolStripMenuItem();
            cobradoresToolStripMenuItem = new ToolStripMenuItem();
            gestiónCobradoresToolStripMenuItem = new ToolStripMenuItem();
            listadoDeCobradoresToolStripMenuItem = new ToolStripMenuItem();
            cuotasToolStripMenuItem = new ToolStripMenuItem();
            generaciónDeCuotasDeActividadesToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            copiasDeSeguridadToolStripMenuItem = new ToolStripMenuItem();
            usuariosDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, mantenimientoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sociosToolStripMenuItem, actividadesToolStripMenuItem, cobradoresToolStripMenuItem, cuotasToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(65, 20);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // sociosToolStripMenuItem
            // 
            sociosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestiToolStripMenuItem, listadoDeSociosToolStripMenuItem });
            sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            sociosToolStripMenuItem.Size = new Size(180, 22);
            sociosToolStripMenuItem.Text = "Socios";
            // 
            // gestiToolStripMenuItem
            // 
            gestiToolStripMenuItem.Name = "gestiToolStripMenuItem";
            gestiToolStripMenuItem.Size = new Size(180, 22);
            gestiToolStripMenuItem.Text = "Gestión de socios";
            gestiToolStripMenuItem.Click += gestiToolStripMenuItem_Click;
            // 
            // listadoDeSociosToolStripMenuItem
            // 
            listadoDeSociosToolStripMenuItem.Name = "listadoDeSociosToolStripMenuItem";
            listadoDeSociosToolStripMenuItem.Size = new Size(180, 22);
            listadoDeSociosToolStripMenuItem.Text = "Listado de socios";
            // 
            // actividadesToolStripMenuItem
            // 
            actividadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestiónDeActividadesToolStripMenuItem, listadoDeActividadesToolStripMenuItem, listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem });
            actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            actividadesToolStripMenuItem.Size = new Size(180, 22);
            actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // gestiónDeActividadesToolStripMenuItem
            // 
            gestiónDeActividadesToolStripMenuItem.Name = "gestiónDeActividadesToolStripMenuItem";
            gestiónDeActividadesToolStripMenuItem.Size = new Size(314, 22);
            gestiónDeActividadesToolStripMenuItem.Text = "Gestión de actividades";
            // 
            // listadoDeActividadesToolStripMenuItem
            // 
            listadoDeActividadesToolStripMenuItem.Name = "listadoDeActividadesToolStripMenuItem";
            listadoDeActividadesToolStripMenuItem.Size = new Size(314, 22);
            listadoDeActividadesToolStripMenuItem.Text = "Listado de actividades";
            // 
            // listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem
            // 
            listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem.Name = "listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem";
            listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem.Size = new Size(314, 22);
            listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem.Text = "Listado de socios de las diferentes actividades";
            // 
            // cobradoresToolStripMenuItem
            // 
            cobradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestiónCobradoresToolStripMenuItem, listadoDeCobradoresToolStripMenuItem });
            cobradoresToolStripMenuItem.Name = "cobradoresToolStripMenuItem";
            cobradoresToolStripMenuItem.Size = new Size(180, 22);
            cobradoresToolStripMenuItem.Text = "Cobradores";
            // 
            // gestiónCobradoresToolStripMenuItem
            // 
            gestiónCobradoresToolStripMenuItem.Name = "gestiónCobradoresToolStripMenuItem";
            gestiónCobradoresToolStripMenuItem.Size = new Size(190, 22);
            gestiónCobradoresToolStripMenuItem.Text = "Gestión cobradores";
            // 
            // listadoDeCobradoresToolStripMenuItem
            // 
            listadoDeCobradoresToolStripMenuItem.Name = "listadoDeCobradoresToolStripMenuItem";
            listadoDeCobradoresToolStripMenuItem.Size = new Size(190, 22);
            listadoDeCobradoresToolStripMenuItem.Text = "Listado de cobradores";
            // 
            // cuotasToolStripMenuItem
            // 
            cuotasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generaciónDeCuotasDeActividadesToolStripMenuItem });
            cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            cuotasToolStripMenuItem.Size = new Size(180, 22);
            cuotasToolStripMenuItem.Text = "Cuotas";
            // 
            // generaciónDeCuotasDeActividadesToolStripMenuItem
            // 
            generaciónDeCuotasDeActividadesToolStripMenuItem.Name = "generaciónDeCuotasDeActividadesToolStripMenuItem";
            generaciónDeCuotasDeActividadesToolStripMenuItem.Size = new Size(266, 22);
            generaciónDeCuotasDeActividadesToolStripMenuItem.Text = "Generación de cuotas de actividades";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiasDeSeguridadToolStripMenuItem, usuariosDelSistemaToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // copiasDeSeguridadToolStripMenuItem
            // 
            copiasDeSeguridadToolStripMenuItem.Name = "copiasDeSeguridadToolStripMenuItem";
            copiasDeSeguridadToolStripMenuItem.Size = new Size(181, 22);
            copiasDeSeguridadToolStripMenuItem.Text = "Copias de seguridad";
            // 
            // usuariosDelSistemaToolStripMenuItem
            // 
            usuariosDelSistemaToolStripMenuItem.Name = "usuariosDelSistemaToolStripMenuItem";
            usuariosDelSistemaToolStripMenuItem.Size = new Size(181, 22);
            usuariosDelSistemaToolStripMenuItem.Text = "Usuarios del sistema";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem, toolStripSeparator1, acercaDeToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 43);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(40, 40);
            toolStripButton1.Text = "Socios";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            Text = "ClubDesktop 1.0 - Sistema de gestión de clubes";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem actividadesToolStripMenuItem;
        private ToolStripMenuItem cobradoresToolStripMenuItem;
        private ToolStripMenuItem cuotasToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem copiasDeSeguridadToolStripMenuItem;
        private ToolStripMenuItem usuariosDelSistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem gestiToolStripMenuItem;
        private ToolStripMenuItem listadoDeSociosToolStripMenuItem;
        private ToolStripMenuItem gestiónDeActividadesToolStripMenuItem;
        private ToolStripMenuItem listadoDeActividadesToolStripMenuItem;
        private ToolStripMenuItem listadoDeSociosDeLasDiferentesActividadesToolStripMenuItem;
        private ToolStripMenuItem gestiónCobradoresToolStripMenuItem;
        private ToolStripMenuItem listadoDeCobradoresToolStripMenuItem;
        private ToolStripMenuItem generaciónDeCuotasDeActividadesToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}