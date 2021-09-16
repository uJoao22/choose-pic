using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace primeiroProgram
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
			OfdJanela.ShowDialog();
			Picimagem02.Image = Image.FromFile(OfdJanela.FileName);
			}
			catch{
				MessageBox.Show("Erro");
			}
		}

	}
}
