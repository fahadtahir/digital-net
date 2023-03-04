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
}