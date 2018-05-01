using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuringMachine.Models;

namespace TuringMachine.Controllers
{
    public class ValidatePalindromesController : Controller
    {
        string currentState = "q0";
        int currentIndex = 1;
        List<State> automataStates = new List<State>();
        List<Result> ResultList = new List<Result>();

        // GET: ValidatePalindromes
        public ActionResult Palindromes()
        {
            return View();
        }

        // POST: ValidatePalindromes
        [HttpPost]
        public ActionResult Validate(string input)
        {
            AutomataHelper.fillAutomatas();
            automataStates = AutomataHelper.palindromesAutomata;
            try
            {
                ValidateTheInputWithTransitions(input);
                return Json(new { success = true, result = ResultList });
            }
            catch
            {
                return Json(new { success = false, result = ResultList });
            }
        }

        private void ValidateTheInputWithTransitions(string input)
        {
             input = "#" + input + "#";

            ResultList.Add(new Result()
            {
                indexHead = currentIndex,
                inputChanged = input
            });

            
            var inputArray = input.ToList();
            while (true)
            {
                var thisState = automataStates.Find(x => x.currentState == currentState);
                var thisTransition = thisState.possibleTransitions.Find(x => x.currentSymbol == inputArray[currentIndex].ToString());
                inputArray[currentIndex] = char.Parse(thisTransition.transitionSymbol); //change the symbol with the new symbol
                MakingTransition(thisTransition, String.Join("",inputArray));

                if (inputArray[inputArray.Count - 1] != '#')
                {
                    inputArray.Add('#');
                }

                if (IsAcceptanceStatus(currentState)) break;
            }
        }

        private void MakingTransition(Transition tran, string input) {
            //change the current state
            currentState = tran.transitionState;

            //change the header to right or left
            if (tran.movement == "R")
                currentIndex++;
            else
                currentIndex--;

            //add the result of the list
            ResultList.Add(new Result()
            {
                indexHead = currentIndex,
                inputChanged = input
            });

        }

        private bool IsAcceptanceStatus(string state_) {
            return state_ == "q8" ? true : false;
        }
       
    }
}