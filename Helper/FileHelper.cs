namespace AnimalAppApi.Helper
{
    public static class FileHelper
    {
        public static void CreatedIfNotExist(string path)
        {
            if (File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
