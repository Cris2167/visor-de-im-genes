using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Practica_3__visor_de_imagenes_
{
	public partial class Form1 : Form
	{
		private readonly DirectoryInfo fotosDirectorio = new DirectoryInfo(@"Pictures\");

		public Form1()
		{
			InitializeComponent();

			foreach (var archivo in fotosDirectorio.GetFiles())
				comboBoxImagenes.Items.Add(archivo.Name);

			if (comboBoxImagenes.Items.Count > 0)
				comboBoxImagenes.SelectedIndex = 0;

			PonerImagenActualmenteSeleccionada();

			rbCentrada.Checked = true;
			tsbCentrada.Checked = true;
			centradaToolStripMenuItem.Checked = true;
			checkBoxNormal.Checked = true;
			tsbColor.Checked = true;
			normalToolStripMenuItem.Checked = true;

			rbCentrada_Click(this, new EventArgs());
		}
		private void btPrimero_Click(object sender, EventArgs e)
		{
			comboBoxImagenes.SelectedIndex = 0;
		}
		private void btAnterior_Click(object sender, EventArgs e)
		{
			comboBoxImagenes.SelectedIndex = Math.Clamp(
				comboBoxImagenes.SelectedIndex - 1, 0, comboBoxImagenes.Items.Count - 1
				);
		}
		private void btSiguiente_Click(object sender, EventArgs e)
		{
			comboBoxImagenes.SelectedIndex = Math.Clamp(
				comboBoxImagenes.SelectedIndex + 1, 0, comboBoxImagenes.Items.Count - 1
				);
		}
		private void btUltimo_Click(object sender, EventArgs e)
		{
			comboBoxImagenes.SelectedIndex = comboBoxImagenes.Items.Count - 1;
		}
		private void checkBoxNormal_Click(object sender, EventArgs e)
		{
			if (checkBoxGrises.Checked)
			{
				checkBoxGrises.Checked = false;
				tsbGrises.Checked = false;
				escalaAGrisesToolStripMenuItem.Checked = false;

				PonerImagenActualmenteSeleccionada();
			}
			checkBoxNormal.Checked = true;
			tsbColor.Checked = true;
			normalToolStripMenuItem.Checked = true;
		}
		private void checkBoxGrises_Click(object sender, EventArgs e)
		{
			if (checkBoxNormal.Checked)
			{
				checkBoxNormal.Checked = false;
				tsbColor.Checked = false;
				normalToolStripMenuItem.Checked = false;

				ConvertirAEscalaDeGrises();
			}
			checkBoxGrises.Checked = true;
			tsbGrises.Checked = true;
			escalaAGrisesToolStripMenuItem.Checked = true;
		}

		private void comboBoxImagenes_SelectedIndexChanged(object sender, EventArgs e)
		{
			PonerImagenActualmenteSeleccionada();
		}
		private void pbImagen_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			tslabel1.Text = fotosDirectorio.FullName + comboBoxImagenes.SelectedItem?.ToString();

			if (checkBoxGrises.Checked)
				ConvertirAEscalaDeGrises();
		}
		private void rbCentrada_Click(object sender, EventArgs e)
		{
			pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
			CentrarActivar();
		}
		private void rbAjustar_Click(object sender, EventArgs e)
		{
			pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
			AjustarActivar();
		}
		private void rbZoom_Click(object sender, EventArgs e)
		{
			pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
			ZoomActivar();
		}
		private void rbCentrada_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCentrada.Checked)
			{
				tsbCentrada.Checked = true;
				centradaToolStripMenuItem.Checked = true;
			}
			else
			{
				tsbCentrada.Checked = false;
				centradaToolStripMenuItem.Checked = false;
			}
		}
		private void rbAjustar_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAjustar.Checked)
			{
				tsbAjustar.Checked = true;
				ajustarToolStripMenuItem.Checked = true;
			}
			else
			{
				tsbAjustar.Checked = false;
				ajustarToolStripMenuItem.Checked = false;
			}
		}
		private void rbZoom_CheckedChanged(object sender, EventArgs e)
		{
			if (rbZoom.Checked)
			{
				tsbZoom.Checked = true;
				zoomToolStripMenuItem.Checked = true;
			}
			else
			{
				tsbZoom.Checked = false;
				zoomToolStripMenuItem.Checked = false;
			}
		}
		private void girar90ALaIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Image img = pbImagen.Image;
			img.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pbImagen.Image = img;
		}
		private void girar90ALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Image img = pbImagen.Image;
			img.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pbImagen.Image = img;
		}
		private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(pbImagen.Image);
		}
		private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialogoGuardar = new SaveFileDialog();

			dialogoGuardar.Title = "Guardar como";
			dialogoGuardar.DefaultExt = ".png";
			dialogoGuardar.Filter =
				"BMP (*.bmp)|*.bmp" +
				"|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg" +
				"|PNG (*.png)|*.png" +
				"|Todos los archivos (*.*)|*.*";

			dialogoGuardar.FilterIndex = 3;
			dialogoGuardar.RestoreDirectory = true;
			dialogoGuardar.CreatePrompt = true;
			dialogoGuardar.ValidateNames = true;
			dialogoGuardar.FileName = "Sin titulo.png";

			if (dialogoGuardar.ShowDialog() == DialogResult.OK)
				pbImagen.Image.Save(dialogoGuardar.FileName);
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ConvertirAEscalaDeGrises()
		{
			Bitmap original = new Bitmap(pbImagen.Image);
			Bitmap modificado = new Bitmap(original.Width, original.Height);
			for (int row = 0; row < original.Height; row++)
			{
				for (int col = 0; col < original.Width; col++)
				{
					
					Color pixelOriginal = original.GetPixel(col, row);

					int escalaDeGris = (int) ( pixelOriginal.R * 0.30 + pixelOriginal.G * 0.59 + pixelOriginal.B * 0.11 );

					Color pixelNuevo = Color.FromArgb(pixelOriginal.A, escalaDeGris, escalaDeGris, escalaDeGris);

					modificado.SetPixel(col, row, pixelNuevo);
				}
			}

			pbImagen.Image = modificado;
		}
		private void PonerImagenActualmenteSeleccionada()
		{
			pbImagen.ImageLocation = fotosDirectorio + comboBoxImagenes.SelectedItem?.ToString();
		}

		private void CentrarActivar()
		{
			rbCentrada.Checked = true;
			tsbCentrada.Checked = true;
			centradaToolStripMenuItem.Checked = true;
		}

		private void AjustarActivar()
		{
			rbAjustar.Checked = true;
			tsbAjustar.Checked = true;
			ajustarToolStripMenuItem.Checked = true;
		}

		private void ZoomActivar()
		{
			rbZoom.Checked = true;
			tsbZoom.Checked = true;
			zoomToolStripMenuItem.Checked = true;
		}
	}
}
