[Author("Philip")]
public class StartUp
{
    [Author("Ivan")]
    public static void Main()
    {
        Tracker tracker = new Tracker();

        tracker.PrintMethodsByAuthor();
    }
}