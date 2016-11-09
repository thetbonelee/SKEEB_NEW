public static class Data
{
    private static int score;
    private static string level;

    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    public static string Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }
}