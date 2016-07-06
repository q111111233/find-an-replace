using Nancy;
using System;
using FindAndReplace;

namespace FindAndReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/Replace"] = _ => {
        Game g = new Game(Request.Form["replace"],Request.Form["s1"],Request.Form["s2"]);
        string result;
        if(Request.Form["type"] == "0")
        {
          result = g.ReplaceWholeWord();
        }
        else
        {
          result = g.Replace();
        }
        return View["result.cshtml", result];
      };
      Post["/ReplaceForm"] = _ => {
        return View["form.cshtml", 1];
      };
      Post["/ReplaceWholeWordForm"] = _ => {
        return View["form.cshtml", 0];
      };
    }
  }
}
