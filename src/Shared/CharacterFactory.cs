namespace Shared;

internal static class CharacterFactory
{

    private static readonly Random random = new();
    private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    public static string GenerateRandomString(int length)
    {
        var stringChars = new char[length];
        for (var i = 0; i < length; i++)
        {
            stringChars[i] = CHARS[random.Next(CHARS.Length)];
        }
        return new string(stringChars);
    }

}

