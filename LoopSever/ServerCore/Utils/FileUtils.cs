namespace LoopSever.ServerCore.Utils;

public static class FileUtils
{
    public static void CreateDir(string pathDir)
    {
        if (!Directory.Exists(pathDir))
        {
            Directory.CreateDirectory(pathDir);
        }
    }
}