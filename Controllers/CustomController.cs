using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class CustomController : Controller
{
    // 
    // GET: /Custom/
    public string Index()
    {
        return "Welcome to Digital Springs";
    }

    // 
    // GET: /Custom/Welcome/
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}