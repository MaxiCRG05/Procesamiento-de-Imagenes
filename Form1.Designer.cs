namespace Procesamiento_Imagenes
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCargar = new System.Windows.Forms.Button();
			this.btnCPU = new System.Windows.Forms.Button();
			this.btnGPU = new System.Windows.Forms.Button();
			this.btnRESET = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.imgOriginal = new System.Windows.Forms.PictureBox();
			this.imgGrises = new System.Windows.Forms.PictureBox();
			this.imgBandW = new System.Windows.Forms.PictureBox();
			this.finder = new System.Windows.Forms.OpenFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Res1 = new System.Windows.Forms.Label();
			this.Res3 = new System.Windows.Forms.Label();
			this.Res2 = new System.Windows.Forms.Label();
			this.Tiempo = new System.Windows.Forms.Label();
			this.Res4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.imgBordes = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGrises)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBandW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBordes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCargar
			// 
			this.btnCargar.AutoSize = true;
			this.btnCargar.Location = new System.Drawing.Point(12, 12);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(107, 36);
			this.btnCargar.TabIndex = 0;
			this.btnCargar.Text = "CARGAR IMAGEN";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCargar_MouseClick);
			// 
			// btnCPU
			// 
			this.btnCPU.AutoSize = true;
			this.btnCPU.Location = new System.Drawing.Point(25, 57);
			this.btnCPU.Name = "btnCPU";
			this.btnCPU.Size = new System.Drawing.Size(75, 23);
			this.btnCPU.TabIndex = 1;
			this.btnCPU.Text = "CPU";
			this.btnCPU.UseVisualStyleBackColor = true;
			this.btnCPU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCPU_MouseClick);
			// 
			// btnGPU
			// 
			this.btnGPU.AutoSize = true;
			this.btnGPU.Location = new System.Drawing.Point(25, 86);
			this.btnGPU.Name = "btnGPU";
			this.btnGPU.Size = new System.Drawing.Size(75, 23);
			this.btnGPU.TabIndex = 2;
			this.btnGPU.Text = "GPU";
			this.btnGPU.UseVisualStyleBackColor = true;
			// 
			// btnRESET
			// 
			this.btnRESET.AutoSize = true;
			this.btnRESET.Location = new System.Drawing.Point(25, 115);
			this.btnRESET.Name = "btnRESET";
			this.btnRESET.Size = new System.Drawing.Size(75, 23);
			this.btnRESET.TabIndex = 3;
			this.btnRESET.Text = "RESETEAR";
			this.btnRESET.UseVisualStyleBackColor = true;
			this.btnRESET.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRESET_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 384);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "TIEMPO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(271, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "IMÁGEN ORIGINAL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(634, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "IMÁGEN ESCALA DE GRISES";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(253, 413);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "IMÁGEN BLANCO Y NEGRO";
			// 
			// imgOriginal
			// 
			this.imgOriginal.Location = new System.Drawing.Point(138, 57);
			this.imgOriginal.Name = "imgOriginal";
			this.imgOriginal.Size = new System.Drawing.Size(385, 293);
			this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgOriginal.TabIndex = 8;
			this.imgOriginal.TabStop = false;
			// 
			// imgGrises
			// 
			this.imgGrises.Location = new System.Drawing.Point(529, 57);
			this.imgGrises.Name = "imgGrises";
			this.imgGrises.Size = new System.Drawing.Size(385, 293);
			this.imgGrises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgGrises.TabIndex = 9;
			this.imgGrises.TabStop = false;
			// 
			// imgBandW
			// 
			this.imgBandW.Location = new System.Drawing.Point(138, 435);
			this.imgBandW.Name = "imgBandW";
			this.imgBandW.Size = new System.Drawing.Size(385, 293);
			this.imgBandW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBandW.TabIndex = 10;
			this.imgBandW.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(286, 362);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "RESOLUCIÓN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(286, 739);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "RESOLUCIÓN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(677, 362);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "RESOLUCIÓN";
			// 
			// Res1
			// 
			this.Res1.AutoSize = true;
			this.Res1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Res1.Location = new System.Drawing.Point(277, 384);
			this.Res1.Name = "Res1";
			this.Res1.Size = new System.Drawing.Size(97, 19);
			this.Res1.TabIndex = 14;
			this.Res1.Text = "RESOLUCIÓN";
			this.Res1.Visible = false;
			// 
			// Res3
			// 
			this.Res3.AutoSize = true;
			this.Res3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Res3.Location = new System.Drawing.Point(276, 761);
			this.Res3.Name = "Res3";
			this.Res3.Size = new System.Drawing.Size(97, 19);
			this.Res3.TabIndex = 15;
			this.Res3.Text = "RESOLUCIÓN";
			this.Res3.Visible = false;
			// 
			// Res2
			// 
			this.Res2.AutoSize = true;
			this.Res2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Res2.Location = new System.Drawing.Point(667, 384);
			this.Res2.Name = "Res2";
			this.Res2.Size = new System.Drawing.Size(97, 19);
			this.Res2.TabIndex = 16;
			this.Res2.Text = "RESOLUCIÓN";
			this.Res2.Visible = false;
			// 
			// Tiempo
			// 
			this.Tiempo.AutoSize = true;
			this.Tiempo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tiempo.Location = new System.Drawing.Point(21, 407);
			this.Tiempo.Name = "Tiempo";
			this.Tiempo.Size = new System.Drawing.Size(61, 19);
			this.Tiempo.TabIndex = 17;
			this.Tiempo.Text = "TIEMPO";
			this.Tiempo.Visible = false;
			// 
			// Res4
			// 
			this.Res4.AutoSize = true;
			this.Res4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Res4.Location = new System.Drawing.Point(661, 761);
			this.Res4.Name = "Res4";
			this.Res4.Size = new System.Drawing.Size(97, 19);
			this.Res4.TabIndex = 22;
			this.Res4.Text = "RESOLUCIÓN";
			this.Res4.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(671, 739);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "RESOLUCIÓN";
			// 
			// imgBordes
			// 
			this.imgBordes.Location = new System.Drawing.Point(529, 435);
			this.imgBordes.Name = "imgBordes";
			this.imgBordes.Size = new System.Drawing.Size(385, 293);
			this.imgBordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBordes.TabIndex = 20;
			this.imgBordes.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(661, 413);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "IMÁGEN BORDES";
			// 
			// btnPause
			// 
			this.btnPause.Location = new System.Drawing.Point(25, 144);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(75, 36);
			this.btnPause.TabIndex = 23;
			this.btnPause.Text = "PAUSAR CAMARA";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPause_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 789);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.Res4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.imgBordes);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Tiempo);
			this.Controls.Add(this.Res2);
			this.Controls.Add(this.Res3);
			this.Controls.Add(this.Res1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.imgBandW);
			this.Controls.Add(this.imgGrises);
			this.Controls.Add(this.imgOriginal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRESET);
			this.Controls.Add(this.btnGPU);
			this.Controls.Add(this.btnCPU);
			this.Controls.Add(this.btnCargar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Procesador";
			((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgGrises)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBandW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBordes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.Button btnCPU;
		private System.Windows.Forms.Button btnGPU;
		private System.Windows.Forms.Button btnRESET;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox imgOriginal;
		private System.Windows.Forms.PictureBox imgGrises;
		private System.Windows.Forms.PictureBox imgBandW;
		private System.Windows.Forms.OpenFileDialog finder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label Res1;
		private System.Windows.Forms.Label Res3;
		private System.Windows.Forms.Label Res2;
		private System.Windows.Forms.Label Tiempo;
		private System.Windows.Forms.Label Res4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox imgBordes;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnPause;
	}
}

