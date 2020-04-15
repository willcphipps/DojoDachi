using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoDachi.Controllers {
    public class HomeController : Controller {
        public static DojoDachi dojoDachi = new DojoDachi ();
        [HttpGet ("")]
        public IActionResult Index () {

            return View ("Index", dojoDachi);
        }

        [HttpGet ("feed")]
        public IActionResult Feed () {
            dojoDachi.EatMeal ();
            if (dojoDachi.HasDied () == true) {
                return View ("Died", dojoDachi);
            }
            if (dojoDachi.HasWon () == true) {
                return View ("Win", dojoDachi);
            }
            return View ("Index", dojoDachi);
        }

        [HttpGet ("play")]
        public IActionResult Play () {
            dojoDachi.Playing ();
            if (dojoDachi.HasDied () == true) {
                return View ("Died",dojoDachi);
            }
            if (dojoDachi.HasWon () == true) {
                return View ("Win", dojoDachi);
            }
            return View ("Index", dojoDachi);
        }

        [HttpGet ("work")]
        public IActionResult Work () {
            dojoDachi.Working ();
            if (dojoDachi.HasDied () == true) {
                return View ("Died", dojoDachi);
            }
            if (dojoDachi.HasWon () == true) {
                return View ("Win", dojoDachi);
            }
            return View ("Index", dojoDachi);
        }

        [HttpGet ("sleep")]
        public IActionResult Sleep () {
            dojoDachi.Sleeping ();
            if (dojoDachi.HasDied () == true) {
                return View ("Died", dojoDachi);
            }
            if (dojoDachi.HasWon () == true) {
                return View ("Win",dojoDachi);
            }
            return View ("Index", dojoDachi);
        }

        [HttpGet ("restart")]
        public IActionResult Restart () {
            dojoDachi.Restart ();
            return View ("Index", dojoDachi);
        }
    }

}