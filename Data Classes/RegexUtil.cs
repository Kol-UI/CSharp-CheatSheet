using System;
using System.Text.RegularExpressions;


static class RegexUtil
{
    static Regex _regex = new Regex(@"/content/([a-z0-9\-]+)\.cs$");
    /// <summary>
    /// This returns the key that is matched within the input.
    /// </summary>
    static public string MatchKey(string input)
    {
        Match match = _regex.Match(input.ToLower());
        if (match.Success)
        {
            return match.Groups[1].Value;
        }
        else
        {
            return null;
        }
    }
}
