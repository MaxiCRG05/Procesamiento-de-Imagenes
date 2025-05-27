using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Procesamiento_Imagenes
{
	public partial class Form1 : Form
	{
		private VideoCaptureDevice videoSource;
		private FilterInfoCollection videoDevices;
		private bool hayCamara = false;

		public Form1()
		{
			InitializeComponent();
			LimpiarLabels();
			ActivarLabels();
			VerificarSiHayCamara();
		}

		private void VerificarSiHayCamara()
		{
			try
			{
				videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
				hayCamara = videoDevices.Count > 0;
				btnPause.Enabled = hayCamara;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al verificar la cámara: " + ex.Message);
			}
		}

		private void IniciarCamara()
		{
			try
			{
				videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

				if (videoDevices.Count == 0)
				{
					MessageBox.Show("No se encontraron cámaras disponibles");
					return;
				}

				videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
				videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
				videoSource.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al iniciar la cámara: " + ex.Message);
			}
		}

		private void ActualizarResoluciones()
		{
			Res1.Text = $"{imgOriginal.Image.Width}x{imgOriginal.Image.Height} px";
			Res2.Text = $"{imgGrises.Image.Width}x{imgGrises.Image.Height} px";
			Res3.Text = $"{imgBandW.Image.Width}x{imgBandW.Image.Height} px";
			Res4.Text = $"{imgBordes.Image.Width}x{imgBordes.Image.Height} px";
		}

		private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

			Task.Run(() => {
				try
				{
					Stopwatch sw = Stopwatch.StartNew();

					Bitmap grises = ProcesarGrises(frame);
					Bitmap bw = ProcesarBlancoNegro(grises);
					Bitmap bordes = DetectarBordes(grises);

					this.Invoke(new Action(() => {
						var oldOriginal = imgOriginal.Image;
						var oldGrises = imgGrises.Image;
						var oldBw = imgBandW.Image;
						var oldBordes = imgBordes.Image;

						imgOriginal.Image = frame;
						imgGrises.Image = grises;
						imgBandW.Image = bw;
						imgBordes.Image = bordes;

						ActualizarResoluciones();
						sw.Stop();
						PonerTiempo(sw);

						oldOriginal?.Dispose();
						oldGrises?.Dispose();
						oldBw?.Dispose();
						oldBordes?.Dispose();
					}));
				}
				catch (Exception ex)
				{
					Debug.WriteLine($"Error en procesamiento: {ex.Message}");
				}
			});
		}

		private void DetenerCamara()
		{
			if (videoSource != null && videoSource.IsRunning)
			{
				videoSource.SignalToStop();
				videoSource.WaitForStop();
				videoSource.NewFrame -= video_NewFrame;

				LimpiarImagenes();
				LimpiarLabels();
			}
		}

		private void ActivarLabels()
		{
			Res1.Visible = true;
			Res2.Visible = true;
			Res3.Visible = true;
			Res4.Visible = true;
			Tiempo.Visible = true;
		}

		private void LimpiarLabels()
		{
			Res1.Text = "";
			Res2.Text = "";
			Res3.Text = "";
			Res4.Text = "";
			Tiempo.Text = "";
		}

		private void LimpiarImagenes()
		{
			imgBandW.Image = null;
			imgGrises.Image = null;
			imgBordes.Image = null;
		}

		private void PonerTiempo(Stopwatch sw)
		{
			Tiempo.Text = $"{sw.ElapsedMilliseconds} ms";
		}

		private Bitmap ProcesarGrises(Bitmap imagenOriginal)
		{
			Bitmap btm = new Bitmap(imagenOriginal);
			BitmapData bmpdata = btm.LockBits(new Rectangle(0, 0, btm.Width, btm.Height), ImageLockMode.ReadWrite, btm.PixelFormat);
			int numbytes = bmpdata.Stride * btm.Height;
			byte[] bytedata = new byte[numbytes];
			IntPtr arregloImagen = bmpdata.Scan0;

			Marshal.Copy(arregloImagen, bytedata, 0, numbytes);

			for (int i = 0; i < numbytes; i += 4)
			{
				byte gris = (byte)(0.299 * bytedata[i + 2] + 0.587 * bytedata[i + 1] + 0.114 * bytedata[i]);
				bytedata[i] = bytedata[i + 1] = bytedata[i + 2] = gris;
			}

			Marshal.Copy(bytedata, 0, arregloImagen, numbytes);
			btm.UnlockBits(bmpdata);

			return btm;
		}

		private Bitmap ProcesarBlancoNegro(Bitmap imagenGrises)
		{
			Bitmap btm = new Bitmap(imagenGrises);
			BitmapData bmpdata = btm.LockBits(new Rectangle(0, 0, btm.Width, btm.Height),
											ImageLockMode.ReadWrite, btm.PixelFormat);
			int numbytes = bmpdata.Stride * btm.Height;
			byte[] bytedata = new byte[numbytes];
			IntPtr arregloImagen = bmpdata.Scan0;

			Marshal.Copy(arregloImagen, bytedata, 0, numbytes);

			long sum = 0;
			int pixelCount = 0;

			for (int i = 0; i < numbytes; i += 4)
			{
				sum += bytedata[i];
				pixelCount++;
			}

			byte promedioBrillo = (byte)(sum / pixelCount);
			byte umbral = 130;
			bool objetoEsOscuro = promedioBrillo < umbral;

			for (int i = 0; i < numbytes; i += 4)
			{
				byte bwValue;

				if (objetoEsOscuro)
					bwValue = bytedata[i] > umbral ? (byte)255 : (byte)0;
				else
					bwValue = bytedata[i] > umbral ? (byte)0 : (byte)255;

				bytedata[i] = bytedata[i + 1] = bytedata[i + 2] = bwValue;
			}

			Marshal.Copy(bytedata, 0, arregloImagen, numbytes);
			btm.UnlockBits(bmpdata);

			return btm;
		}

		private Bitmap DetectarBordes(Bitmap imagenGrises)
		{
			Bitmap btm = new Bitmap(imagenGrises);
			BitmapData bmpdata = btm.LockBits(new Rectangle(0, 0, btm.Width, btm.Height),
												ImageLockMode.ReadWrite, btm.PixelFormat);
			int numbytes = bmpdata.Stride * btm.Height;
			int umbral = 45;
			byte[] bytedata = new byte[numbytes];
			IntPtr arregloImagen = bmpdata.Scan0;
			Marshal.Copy(arregloImagen, bytedata, 0, numbytes);
			byte[] copiaDatos = new byte[numbytes];
			Array.Copy(bytedata, copiaDatos, numbytes);
			int[,] sobelX = { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
			int[,] sobelY = { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
			int width = btm.Width;
			int height = btm.Height;
			int stride = bmpdata.Stride;
			Bitmap bordes = new Bitmap(width, height);
			using (Graphics g = Graphics.FromImage(bordes))
			{
				g.Clear(Color.Black);
				for (int y = 1; y < height - 1; y++)
				{
					for (int x = 1; x < width - 1; x++)
					{
						int gx = 0, gy = 0;
						int pos = y * stride + x * 4;
						for (int ky = -1; ky <= 1; ky++)
						{
							for (int kx = -1; kx <= 1; kx++)
							{
								int offset = (y + ky) * stride + (x + kx) * 4;
								byte pixelValue = copiaDatos[offset];

								gx += sobelX[ky + 1, kx + 1] * pixelValue;
								gy += sobelY[ky + 1, kx + 1] * pixelValue;
							}
						}
						int magnitude = (int)Math.Sqrt(gx * gx + gy * gy);
						if (magnitude > umbral)
						{
							using (Brush brush = new SolidBrush(Color.White))
							{
								g.FillRectangle(brush, x, y, 1, 1);
							}
						}
					}
				}
			}
			Marshal.Copy(bytedata, 0, arregloImagen, numbytes);
			btm.UnlockBits(bmpdata);

			return bordes;
		}

		private void btnRESET_MouseClick(object sender, MouseEventArgs e)
		{
			VerificarSiHayCamara();
			if (videoSource != null && videoSource.IsRunning)
			{
				DetenerCamara();
				imgOriginal.Image = null;
			}
			else
			{
				LimpiarImagenes();
				LimpiarLabels();
				imgOriginal.Image = null;
			}

		}

		private void ColocarImagenDesdeArchivo()
		{
			using (finder)
			{
				try
				{
					finder.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;*.jfif";
					finder.Title = "Selecciona una imagen";
					finder.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					finder.ShowDialog();
					LimpiarImagenes();
					LimpiarLabels();
					imgOriginal.Image = Image.FromFile(finder.FileName);
					Res1.Text = $"{imgOriginal.Image.Width}x{imgOriginal.Image.Height} px";
				}
				catch (Exception ex)
				{
					imgOriginal.Image = null;
					MessageBox.Show("Error al cargar la imagen: " + ex.Message);
					return;
				}
			}
		}

		private void ColocarImagen()
		{
			if (hayCamara)
			{			
				IniciarCamara();
			}
			else
				ColocarImagenDesdeArchivo();
		}

		private void btnCargar_MouseClick(object sender, MouseEventArgs e)
		{
			ColocarImagen();
		}

		private void ProcesarIMGCPU()
		{
			if (imgOriginal.Image != null)
			{
				imgGrises.Image = ProcesarGrises((Bitmap)imgOriginal.Image);
				imgBandW.Image = ProcesarBlancoNegro((Bitmap)imgOriginal.Image);
			}
			else
			{
				MessageBox.Show("No hay imagen cargada");
			}
		}

		private void btnCPU_MouseClick(object sender, MouseEventArgs e)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			LimpiarImagenes();
			LimpiarLabels();
			ProcesarIMGCPU();
			if(imgGrises.Image != null)
				imgBordes.Image = DetectarBordes((Bitmap)imgGrises.Image);
			sw.Stop();
			if (imgOriginal.Image != null)
			{
				PonerTiempo(sw);
				ActualizarResoluciones();
			}
		}

		private void btnPause_MouseClick(object sender, MouseEventArgs e)
		{
			DetenerCamara();
		}
	}
}