﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuringMachine.Models;
using TuringMachine.Code;

namespace TuringMachine.Controllers
{
    public class AutomatasController : Controller
    {
        ExecuteAutomata executer = new ExecuteAutomata();

        // GET: ValidatePalindromes
        public ActionResult Palindromes()
        {
            ViewBag.Title = "Palíndromos";
            ViewBag.Validate = "Palindromes";
            ViewBag.Example = "Ej: abcba";
            ViewBag.SuccessMessage = "La entrada es un palindromo";
            ViewBag.FailMessage = "La entrada no es un palindromo";
            return View("results");
        }

        // POST: ValidatePalindromes
        [HttpPost]
        public ActionResult Palindromes(string input)
        {
            Filler.fillAutomatas();
            executer.beforeExecute("q8", Filler.palindromesAutomata);
            var isValid = false;
            var resultList = executer.Execute(input, ref isValid);
            return Json(new { success = isValid, result = resultList });
        }

        //GET: replicatePattern
        public ActionResult ReplicatePattern()
        {
            ViewBag.Title = "Duplicar patrones";
            ViewBag.Validate = "replicatePattern";
            ViewBag.Example = "Ej: abc -> abcabc";
            ViewBag.SuccessMessage = "Entrada duplicada";
            ViewBag.FailMessage = "La entrada no tiene formato válido";
            return View("results");
        }

        // POST: replicatePattern
        [HttpPost]
        public ActionResult ReplicatePattern(string input)
        {
            Filler.fillAutomatas();
            executer.beforeExecute("q11", Filler.replicatePatternAutomata);
            var isValid = false;
            var resultList = executer.Execute(input, ref isValid);
            return Json(new { success = isValid, result = resultList });
        }


        //GET: unaryMultiplication
        public ActionResult UnaryMultiplication()
        {
            ViewBag.Title = "Multiplicación de unarios";
            ViewBag.Validate = "UnaryMultiplication";
            ViewBag.Example = "Ej: ||*|||";
            ViewBag.SuccessMessage = "Se ha podido encontrar un resultado";
            ViewBag.FailMessage = "La entrada no tiene formato válido";
            return View("results");
        }

        // POST: unaryMultiplication
        [HttpPost]
        public ActionResult UnaryMultiplication(string input)
        {
            Filler.fillAutomatas();
            executer.beforeExecute("q10", Filler.unaryMultiplicationAutomata);
            var isValid = false;
            var resultList = executer.Execute(input, ref isValid);
            return Json(new { success = isValid, result = resultList });
        }

        //GET: unarySum
        public ActionResult UnarySum()
        {
            ViewBag.Title = "Suma de unarios";
            ViewBag.Validate = "UnarySum";
            ViewBag.Example = "Ej: |||+||";
            ViewBag.SuccessMessage = "Se ha podido encontrar un resultado";
            ViewBag.FailMessage = "La entrada no tiene formato válido";
            return View("results");
        }

        // POST: unarySum
        [HttpPost]
        public ActionResult UnarySum(string input)
        {
            Filler.fillAutomatas();
            executer.beforeExecute("q4", Filler.unarySumAutomata);
            var isValid = false;
            var resultList = executer.Execute(input, ref isValid);
            return Json(new { success = isValid, result = resultList });
        }

        //GET: unaryMinus
        public ActionResult UnaryMinus()
        {
            ViewBag.Title = "Resta de unarios";
            ViewBag.Validate = "UnaryMinus";
            ViewBag.Example = "Ej: ||||-||";
            ViewBag.SuccessMessage = "Se ha podido encontrar un resultado";
            ViewBag.FailMessage = "La entrada no tiene formato válido";
            return View("results");
        }

        // POST: unaryMinus
        [HttpPost]
        public ActionResult UnaryMinus(string input)
        {
            Filler.fillAutomatas();
            executer.beforeExecute("q8", Filler.unaryMinusAutomata);
            var isValid = false;
            var resultList = executer.Execute(input, ref isValid);
            return Json(new { success = isValid, result = resultList });
        }
    }
}