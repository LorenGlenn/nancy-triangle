using System.Collections.Generic;
using TriangleShape.Objects;
using Nancy;

namespace TriangleShape
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["length_input.cshtml"];
      Post["/output"] = _ =>{
        Triangle newTriangle = new Triangle(Request.Form["side1"], Request.Form["side2"], Request.Form["side3"]);
        return View["output.cshtml", newTriangle];
      };
    }
  }
}
