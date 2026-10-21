namespace Pas2.RomanNumerals;

public static class Roman
{
    private static readonly (int Value, string Symbol)[] Parts =
    [
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I"),
    ];

    public static string Format(int value)
    {
        if (value < 1 || value > 3999)
            throw new ArgumentOutOfRangeException(nameof(value));
        var result = new System.Text.StringBuilder();
        foreach (var part in Parts)
            while (value >= part.Value)
            {
                result.Append(part.Symbol);
                value -= part.Value;
            }
        return result.ToString();
    }

    public static int Parse(string text)
    {
        ArgumentNullException.ThrowIfNull(text);
        if (text.Length == 0 || text.Length > 15)
            throw new FormatException("Invalid numeral");
        int value = 0,
            previous = 0;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            int n = text[i] switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new FormatException("Invalid numeral"),
            };
            value += n < previous ? -n : n;
            previous = n;
        }
        if (value < 1 || value > 3999 || Format(value) != text)
            throw new FormatException("Non-canonical numeral");
        return value;
    }
}
