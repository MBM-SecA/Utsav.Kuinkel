using System.IO;

class Assignment2
{
    public void CreatDirectory()
    {
        Directory.CreateDirectory(@"../Parent");
        string fileHello = File.ReadAllText("Hello.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"../Parent/Folder{i + 1}");
            File.WriteAllText($"../Parent/Folder{i + 1}/Hello.cs", fileHello);
        }
    }
}