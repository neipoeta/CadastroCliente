using System.Linq;

public static class MaskUtils
{
    public static string RemoveMask(string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }
}
