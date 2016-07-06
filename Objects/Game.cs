using System;
using System.Text.RegularExpressions;

namespace FindAndReplace
{
  public class Game
  {
    private string _replace;
    private string _s1;
    private string _s2;
    public Game(string replace, string s1, string s2)
    {
      _replace = replace;
      _s1 = s1;
      _s2 = s2;
    }
    public string Replace()
    {
       _replace = Regex.Replace(_replace, @"(?i)"+_s1,_s2);
       return _replace;
    }
    public string ReplaceWholeWord()
    {
       _replace = Regex.Replace(_replace, @"\b(?i)"+_s1+@"\b",_s2);
       return _replace;
    }
  }


}
