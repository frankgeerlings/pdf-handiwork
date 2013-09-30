﻿using System;
using System.Windows.Forms;

namespace PDF_Handiwork
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void AddFilesButtonClick(object sender, EventArgs e)
		{
			var result = openFileDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				var names = openFileDialog1.FileNames;

				foreach (var name in names)
				{
					var inputFile = new InputFile(name);

					InputFilesListBox.Items.Add(inputFile);
				}
			}
		}
	}
}
