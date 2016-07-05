using Nancy;
using System.Collections.Generic;
using ChangeMaker.Objects;
using Xunit;

namespace ChangeMaker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        List<int> userList = Coins.MakeChange(Request.Form["number"]);
        return View["result.cshtml", userList];
      };
    }
  }
}
