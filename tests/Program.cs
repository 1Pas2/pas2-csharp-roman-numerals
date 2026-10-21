using Pas2.RomanNumerals;

static void Check(bool condition, string message)
{
    if (!condition)
        throw new Exception(message);
}
static void Fails(Action action)
{
    try
    {
        action();
    }
    catch (Exception)
    {
        return;
    }
    throw new Exception("Expected failure");
}
Check(Roman.Format(1994) == "MCMXCIV", "format");
Check(Roman.Parse("XLII") == 42, "parse");
for (int n = 1; n <= 3999; n++)
    Check(Roman.Parse(Roman.Format(n)) == n, "roundtrip");
Fails(() => Roman.Parse("IIII"));
Fails(() => Roman.Parse("iv"));
Fails(() => Roman.Format(0));
Console.WriteLine("All checks passed");
