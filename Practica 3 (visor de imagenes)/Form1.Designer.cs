namespace Practica_3__visor_de_imagenes_
{
	partial class Form1
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
			if (disposing && ( components != null ))
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            tslabel1 = new ToolStripStatusLabel();
            menuStrip = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            visionToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            escalaAGrisesToolStripMenuItem = new ToolStripMenuItem();
            tamañoToolStripMenuItem = new ToolStripMenuItem();
            centradaToolStripMenuItem = new ToolStripMenuItem();
            ajustarToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            gbVision = new GroupBox();
            checkBoxNormal = new CheckBox();
            checkBoxGrises = new CheckBox();
            gbTamano = new GroupBox();
            rbZoom = new RadioButton();
            rbAjustar = new RadioButton();
            rbCentrada = new RadioButton();
            labelImagenActual = new Label();
            comboBoxImagenes = new ComboBox();
            pbImagen = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            girar90ALaIzquierdaToolStripMenuItem = new ToolStripMenuItem();
            girar90ALaDerechaToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            btPrimero = new Button();
            btAnterior = new Button();
            btSiguiente = new Button();
            btUltimo = new Button();
            tsbColor = new ToolStripButton();
            tsbGrises = new ToolStripButton();
            tsbCentrada = new ToolStripButton();
            tsbAjustar = new ToolStripButton();
            tsbZoom = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            statusStrip1.SuspendLayout();
            menuStrip.SuspendLayout();
            gbVision.SuspendLayout();
            gbTamano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslabel1 });
            statusStrip1.Location = new Point(0, 590);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(755, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslabel1
            // 
            tslabel1.Name = "tslabel1";
            tslabel1.Size = new Size(0, 16);
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.BurlyWood;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, visionToolStripMenuItem, tamañoToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(755, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(145, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(145, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // visionToolStripMenuItem
            // 
            visionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, escalaAGrisesToolStripMenuItem });
            visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            visionToolStripMenuItem.Size = new Size(63, 24);
            visionToolStripMenuItem.Text = "Vision";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(187, 26);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += checkBoxNormal_Click;
            // 
            // escalaAGrisesToolStripMenuItem
            // 
            escalaAGrisesToolStripMenuItem.Name = "escalaAGrisesToolStripMenuItem";
            escalaAGrisesToolStripMenuItem.Size = new Size(187, 26);
            escalaAGrisesToolStripMenuItem.Text = "Escala a grises";
            escalaAGrisesToolStripMenuItem.Click += checkBoxGrises_Click;
            // 
            // tamañoToolStripMenuItem
            // 
            tamañoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centradaToolStripMenuItem, ajustarToolStripMenuItem, zoomToolStripMenuItem });
            tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            tamañoToolStripMenuItem.Size = new Size(75, 24);
            tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // centradaToolStripMenuItem
            // 
            centradaToolStripMenuItem.Name = "centradaToolStripMenuItem";
            centradaToolStripMenuItem.Size = new Size(152, 26);
            centradaToolStripMenuItem.Text = "Centrada";
            centradaToolStripMenuItem.Click += rbCentrada_Click;
            // 
            // ajustarToolStripMenuItem
            // 
            ajustarToolStripMenuItem.Name = "ajustarToolStripMenuItem";
            ajustarToolStripMenuItem.Size = new Size(152, 26);
            ajustarToolStripMenuItem.Text = "Ajustar";
            ajustarToolStripMenuItem.Click += rbAjustar_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(152, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += rbZoom_Click;
            // 
            // gbVision
            // 
            gbVision.BackColor = Color.Bisque;
            gbVision.Controls.Add(checkBoxNormal);
            gbVision.Controls.Add(checkBoxGrises);
            gbVision.Location = new Point(12, 95);
            gbVision.Name = "gbVision";
            gbVision.Size = new Size(532, 79);
            gbVision.TabIndex = 3;
            gbVision.TabStop = false;
            gbVision.Text = "Vision";
            // 
            // checkBoxNormal
            // 
            checkBoxNormal.AutoSize = true;
            checkBoxNormal.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxNormal.Location = new Point(95, 36);
            checkBoxNormal.Name = "checkBoxNormal";
            checkBoxNormal.Size = new Size(95, 27);
            checkBoxNormal.TabIndex = 1;
            checkBoxNormal.Text = "Normal";
            checkBoxNormal.UseVisualStyleBackColor = true;
            checkBoxNormal.Click += checkBoxNormal_Click;
            // 
            // checkBoxGrises
            // 
            checkBoxGrises.AutoSize = true;
            checkBoxGrises.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxGrises.Location = new Point(336, 36);
            checkBoxGrises.Name = "checkBoxGrises";
            checkBoxGrises.Size = new Size(163, 27);
            checkBoxGrises.TabIndex = 0;
            checkBoxGrises.Text = "Escala de Grises";
            checkBoxGrises.UseVisualStyleBackColor = true;
            checkBoxGrises.Click += checkBoxGrises_Click;
            // 
            // gbTamano
            // 
            gbTamano.BackColor = Color.Bisque;
            gbTamano.Controls.Add(rbZoom);
            gbTamano.Controls.Add(rbAjustar);
            gbTamano.Controls.Add(rbCentrada);
            gbTamano.Location = new Point(571, 278);
            gbTamano.Name = "gbTamano";
            gbTamano.Size = new Size(157, 180);
            gbTamano.TabIndex = 4;
            gbTamano.TabStop = false;
            gbTamano.Text = "Tamaño";
            // 
            // rbZoom
            // 
            rbZoom.AutoSize = true;
            rbZoom.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbZoom.Location = new Point(27, 127);
            rbZoom.Name = "rbZoom";
            rbZoom.Size = new Size(80, 27);
            rbZoom.TabIndex = 2;
            rbZoom.TabStop = true;
            rbZoom.Text = "Zoom";
            rbZoom.UseVisualStyleBackColor = true;
            rbZoom.CheckedChanged += rbZoom_CheckedChanged;
            rbZoom.Click += rbZoom_Click;
            // 
            // rbAjustar
            // 
            rbAjustar.AutoSize = true;
            rbAjustar.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAjustar.Location = new Point(27, 83);
            rbAjustar.Name = "rbAjustar";
            rbAjustar.Size = new Size(92, 27);
            rbAjustar.TabIndex = 1;
            rbAjustar.TabStop = true;
            rbAjustar.Text = "Ajustar";
            rbAjustar.UseVisualStyleBackColor = true;
            rbAjustar.CheckedChanged += rbAjustar_CheckedChanged;
            rbAjustar.Click += rbAjustar_Click;
            // 
            // rbCentrada
            // 
            rbCentrada.AutoSize = true;
            rbCentrada.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCentrada.Location = new Point(27, 36);
            rbCentrada.Name = "rbCentrada";
            rbCentrada.Size = new Size(108, 27);
            rbCentrada.TabIndex = 0;
            rbCentrada.Text = "Centrada";
            rbCentrada.UseVisualStyleBackColor = true;
            rbCentrada.CheckedChanged += rbCentrada_CheckedChanged;
            rbCentrada.Click += rbCentrada_Click;
            // 
            // labelImagenActual
            // 
            labelImagenActual.AutoSize = true;
            labelImagenActual.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelImagenActual.Location = new Point(41, 545);
            labelImagenActual.Name = "labelImagenActual";
            labelImagenActual.Size = new Size(113, 20);
            labelImagenActual.TabIndex = 5;
            labelImagenActual.Text = "Imagen Actual";
            // 
            // comboBoxImagenes
            // 
            comboBoxImagenes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxImagenes.FormattingEnabled = true;
            comboBoxImagenes.Location = new Point(151, 545);
            comboBoxImagenes.Name = "comboBoxImagenes";
            comboBoxImagenes.Size = new Size(277, 28);
            comboBoxImagenes.TabIndex = 6;
            comboBoxImagenes.SelectedIndexChanged += comboBoxImagenes_SelectedIndexChanged;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.SeaShell;
            pbImagen.ContextMenuStrip = contextMenuStrip1;
            pbImagen.Location = new Point(12, 223);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(532, 316);
            pbImagen.TabIndex = 7;
            pbImagen.TabStop = false;
            pbImagen.LoadCompleted += pbImagen_LoadCompleted;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { girar90ALaIzquierdaToolStripMenuItem, girar90ALaDerechaToolStripMenuItem, copiarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(231, 76);
            // 
            // girar90ALaIzquierdaToolStripMenuItem
            // 
            girar90ALaIzquierdaToolStripMenuItem.Name = "girar90ALaIzquierdaToolStripMenuItem";
            girar90ALaIzquierdaToolStripMenuItem.Size = new Size(230, 24);
            girar90ALaIzquierdaToolStripMenuItem.Text = "Girar 90° a la Izquierda";
            girar90ALaIzquierdaToolStripMenuItem.Click += girar90ALaIzquierdaToolStripMenuItem_Click;
            // 
            // girar90ALaDerechaToolStripMenuItem
            // 
            girar90ALaDerechaToolStripMenuItem.Name = "girar90ALaDerechaToolStripMenuItem";
            girar90ALaDerechaToolStripMenuItem.Size = new Size(230, 24);
            girar90ALaDerechaToolStripMenuItem.Text = "Girar 90° a la Derecha";
            girar90ALaDerechaToolStripMenuItem.Click += girar90ALaDerechaToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(230, 24);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // btPrimero
            // 
            btPrimero.BackColor = Color.PeachPuff;
            btPrimero.Location = new Point(34, 180);
            btPrimero.Name = "btPrimero";
            btPrimero.Size = new Size(94, 29);
            btPrimero.TabIndex = 8;
            btPrimero.Text = "<<";
            btPrimero.UseVisualStyleBackColor = false;
            btPrimero.Click += btPrimero_Click;
            // 
            // btAnterior
            // 
            btAnterior.BackColor = Color.PeachPuff;
            btAnterior.Location = new Point(160, 180);
            btAnterior.Name = "btAnterior";
            btAnterior.Size = new Size(94, 29);
            btAnterior.TabIndex = 9;
            btAnterior.Text = "<";
            btAnterior.UseVisualStyleBackColor = false;
            btAnterior.Click += btAnterior_Click;
            // 
            // btSiguiente
            // 
            btSiguiente.BackColor = Color.PeachPuff;
            btSiguiente.Location = new Point(308, 180);
            btSiguiente.Name = "btSiguiente";
            btSiguiente.Size = new Size(94, 29);
            btSiguiente.TabIndex = 10;
            btSiguiente.Text = ">";
            btSiguiente.UseVisualStyleBackColor = false;
            btSiguiente.Click += btSiguiente_Click;
            // 
            // btUltimo
            // 
            btUltimo.BackColor = Color.PeachPuff;
            btUltimo.Location = new Point(428, 180);
            btUltimo.Name = "btUltimo";
            btUltimo.Size = new Size(94, 29);
            btUltimo.TabIndex = 11;
            btUltimo.Text = ">>";
            btUltimo.UseVisualStyleBackColor = false;
            btUltimo.Click += btUltimo_Click;
            // 
            // tsbColor
            // 
            tsbColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbColor.Image = Properties.Resources.IconoColor;
            tsbColor.ImageTransparentColor = Color.Magenta;
            tsbColor.Name = "tsbColor";
            tsbColor.Size = new Size(54, 54);
            tsbColor.Text = "Color";
            tsbColor.Click += checkBoxNormal_Click;
            // 
            // tsbGrises
            // 
            tsbGrises.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGrises.Image = Properties.Resources.IconoGrises;
            tsbGrises.ImageTransparentColor = Color.Magenta;
            tsbGrises.Name = "tsbGrises";
            tsbGrises.Size = new Size(54, 54);
            tsbGrises.Text = "Escala de Grises";
            tsbGrises.Click += checkBoxGrises_Click;
            // 
            // tsbCentrada
            // 
            tsbCentrada.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCentrada.Image = Properties.Resources.IconoCentrada;
            tsbCentrada.ImageTransparentColor = Color.Magenta;
            tsbCentrada.Name = "tsbCentrada";
            tsbCentrada.Size = new Size(54, 54);
            tsbCentrada.Text = "Centrar";
            tsbCentrada.Click += rbCentrada_Click;
            // 
            // tsbAjustar
            // 
            tsbAjustar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAjustar.Image = Properties.Resources.IconoAjustar;
            tsbAjustar.ImageTransparentColor = Color.Magenta;
            tsbAjustar.Name = "tsbAjustar";
            tsbAjustar.Size = new Size(54, 54);
            tsbAjustar.Text = "Ajustar";
            tsbAjustar.Click += rbAjustar_Click;
            // 
            // tsbZoom
            // 
            tsbZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbZoom.Image = Properties.Resources.IconoZoom;
            tsbZoom.ImageTransparentColor = Color.Magenta;
            tsbZoom.Name = "tsbZoom";
            tsbZoom.Size = new Size(54, 54);
            tsbZoom.Text = "Zoom";
            tsbZoom.Click += rbZoom_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.BurlyWood;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbColor, tsbGrises, tsbCentrada, tsbAjustar, tsbZoom });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(755, 57);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(755, 612);
            Controls.Add(btUltimo);
            Controls.Add(btSiguiente);
            Controls.Add(btAnterior);
            Controls.Add(btPrimero);
            Controls.Add(pbImagen);
            Controls.Add(comboBoxImagenes);
            Controls.Add(labelImagenActual);
            Controls.Add(gbTamano);
            Controls.Add(gbVision);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Visor de Imagenes";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            gbVision.ResumeLayout(false);
            gbVision.PerformLayout();
            gbTamano.ResumeLayout(false);
            gbTamano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
		private MenuStrip menuStrip;
		private ToolStripMenuItem archivoToolStripMenuItem;
		private GroupBox gbVision;
		private GroupBox gbTamano;
		private Label labelImagenActual;
		private ComboBox comboBoxImagenes;
		private PictureBox pbImagen;
		private Button btPrimero;
		private Button btAnterior;
		private Button btSiguiente;
		private Button btUltimo;
		private CheckBox checkBoxNormal;
		private CheckBox checkBoxGrises;
		private RadioButton rbZoom;
		private RadioButton rbAjustar;
		private RadioButton rbCentrada;
		private ToolStripMenuItem guardarToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem visionToolStripMenuItem;
		private ToolStripMenuItem tamañoToolStripMenuItem;
		private ToolStripMenuItem normalToolStripMenuItem;
		private ToolStripMenuItem escalaAGrisesToolStripMenuItem;
		private ToolStripMenuItem centradaToolStripMenuItem;
		private ToolStripMenuItem ajustarToolStripMenuItem;
		private ToolStripMenuItem zoomToolStripMenuItem;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem girar90ALaIzquierdaToolStripMenuItem;
		private ToolStripMenuItem girar90ALaDerechaToolStripMenuItem;
		private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripButton tsbColor;
        private ToolStripButton tsbGrises;
        private ToolStripButton tsbCentrada;
        private ToolStripButton tsbAjustar;
        private ToolStripButton tsbZoom;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel tslabel1;
    }
}
