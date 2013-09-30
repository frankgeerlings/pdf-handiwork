namespace PDF_Handiwork
{
	using System.Collections.Generic;
	using System.IO;

	using iTextSharp.text;
	using iTextSharp.text.pdf;

	public class PdfMerger
	{
		public void MergeIntoStream(IEnumerable<InputFile> items, Stream targetStream)
		{
			var document = new Document();

			var writer = PdfWriter.GetInstance(document, targetStream);

			document.Open();

			var contentBytes = writer.DirectContent;

			foreach (var inputFile in items)
			{
				var reader = new PdfReader(inputFile.Path);

				var n = reader.NumberOfPages;

				var firstPage = true;

				for (var i = 1; i <= n; i++)
				{
					document.SetPageSize(reader.GetPageSizeWithRotation(1));
					document.NewPage();

					if (firstPage)
					{
						firstPage = false;

						var fileRef = new Chunk(string.Empty);
						fileRef.SetLocalDestination(inputFile.Path);
						document.Add(fileRef);
					}

					var page = writer.GetImportedPage(reader, i);

					if (reader.GetPageRotation(i) % 180 == 90) // landscape
					{
						contentBytes.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
					}
					else
					{
						contentBytes.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
					}
				}
			}

			document.Close();
		}
	}
}