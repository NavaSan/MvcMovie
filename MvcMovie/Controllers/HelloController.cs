using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers{
    public class HelloController : Controller{
        //
        // GET: /HelloWorld/

        public string Index(){
            return "This is my dafault action...";
        }

        public string Welcome(string name, int numTimes = 1){
            return HtmlEncoder.Default.Encode($"hello {name}, NumTimes is: {numTimes}");
        }
    }
}