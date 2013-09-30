namespace PDF_Handiwork
{
	internal class InputFile
	{
		private readonly string safeName;

		private readonly string path;

		public InputFile(string path)
		{
			this.path = path;
			this.safeName = System.IO.Path.GetFileName(path);
		}

		public string SafeName
		{
			get
			{
				return this.safeName;
			}
		}

		public string Path
		{
			get
			{
				return this.path;
			}
		}

		public override string ToString()
		{
			return this.SafeName;
		}
	}
}