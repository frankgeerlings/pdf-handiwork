namespace PDF_Handiwork
{
	partial class MainForm
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
			this.InputFilesListBox = new System.Windows.Forms.ListBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SaveButton = new System.Windows.Forms.Button();
			this.AddFilesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InputFilesListBox
			// 
			this.InputFilesListBox.FormattingEnabled = true;
			this.InputFilesListBox.Location = new System.Drawing.Point(12, 12);
			this.InputFilesListBox.Name = "InputFilesListBox";
			this.InputFilesListBox.Size = new System.Drawing.Size(271, 238);
			this.InputFilesListBox.TabIndex = 0;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "pdf";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(295, 227);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 1;
			this.SaveButton.Text = "Save as...";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddFilesButton
			// 
			this.AddFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddFilesButton.Location = new System.Drawing.Point(207, 226);
			this.AddFilesButton.Name = "AddFilesButton";
			this.AddFilesButton.Size = new System.Drawing.Size(75, 23);
			this.AddFilesButton.TabIndex = 2;
			this.AddFilesButton.Text = "&Add files...";
			this.AddFilesButton.UseVisualStyleBackColor = true;
			this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 262);
			this.Controls.Add(this.AddFilesButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.InputFilesListBox);
			this.Name = "MainForm";
			this.Text = "PDF Handiwork";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox InputFilesListBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button AddFilesButton;
	}
}

