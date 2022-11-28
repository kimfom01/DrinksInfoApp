namespace drinks_info_console.Input;

public class Validation
{
    public bool IsValidId(string id)
    {
        int _;
        return int.TryParse(id, out _) && _ > 0;
    }

    public bool IsValidString(string text)
    {
        return !String.IsNullOrEmpty(text);
    }

    internal bool IsValidAns(string ans)
    {
        return ans == "y" || ans == "n";
    }
}
