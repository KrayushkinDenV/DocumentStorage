namespace DocumentStorage.Services
{
	public static class FileService
	{
		public static async Task SaveFileAsync(IFormFile file)
		{
			var path = Path.Combine(Settings.FileStorageDirectory, file.FileName);
			using(var stream = new FileStream(path, FileMode.Create))
			{
				await file.CopyToAsync(stream);
			}
		}
	}
}
