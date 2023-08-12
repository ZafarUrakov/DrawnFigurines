namespace DrawnFigurines.Classes;

public static class Messages
{
    public static string GetUserValueByMassage(string massage)
    {
        Console.Write(massage);
        return Console.ReadLine();
    }
}