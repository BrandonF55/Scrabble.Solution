using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;
using System;

namespace Scrabble.Controllers
{
    public class ScrabbleController : Controller
    {


        [Route("/")]
        public ActionResult Form() { return View(); }


        [Route("/Output")]
        public ActionResult Output(string input)
        {
            ScrabbleScores test = new ScrabbleScores(input);
            test.getPoints();
            Console.WriteLine(test.Response);
            return View(test);


        }
    }
}

