/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 22/06/2021
 * Time: 09:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace primeiroProgram
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Picimagem01 = new System.Windows.Forms.PictureBox();
			this.Picimagem02 = new System.Windows.Forms.PictureBox();
			this.OfdJanela = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Picimagem01)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picimagem02)).BeginInit();
			this.SuspendLayout();
			// 
			// Picimagem01
			// 
			this.Picimagem01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Picimagem01.Image = ((System.Drawing.Image)(resources.GetObject("Picimagem01.Image")));
			this.Picimagem01.Location = new System.Drawing.Point(25, 12);
			this.Picimagem01.Name = "Picimagem01";
			this.Picimagem01.Size = new System.Drawing.Size(200, 200);
			this.Picimagem01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picimagem01.TabIndex = 0;
			this.Picimagem01.TabStop = false;
			// 
			// Picimagem02
			// 
			this.Picimagem02.Location = new System.Drawing.Point(246, 12);
			this.Picimagem02.Name = "Picimagem02";
			this.Picimagem02.Size = new System.Drawing.Size(200, 200);
			this.Picimagem02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picimagem02.TabIndex = 1;
			this.Picimagem02.TabStop = false;
			// 
			// OfdJanela
			// 
			this.OfdJanela.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Escolher Imagem";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 470);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Picimagem02);
			this.Controls.Add(this.Picimagem01);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			((System.ComponentModel.ISupportInitialize)(this.Picimagem01)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picimagem02)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog OfdJanela;
		private System.Windows.Forms.PictureBox Picimagem02;
		private System.Windows.Forms.PictureBox Picimagem01;
	}
}
