using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TuringMachine.Models;

namespace TuringMachine.Code
{
    public class ExecuteAutomata
    {
        string currentState = "q0";
        string acceptanceStatus = "";
        int currentIndex = 1;
        List<State> automataStates = new List<State>();
        List<Result> ResultList = new List<Result>();

        public void beforeExecute(string acceptanceStatus_, List<State> automataStates_)
        {
            acceptanceStatus = acceptanceStatus_;
            automataStates = automataStates_;
        }

        public List<Result> Execute(string input, ref bool isValid)
        {
            try
            {
                ValidateTheInputWithTransitions(input);
                isValid = true;
            }
            catch (Exception e)
            {
                isValid = false;
            }
            return ResultList;
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
                MakingTransition(thisTransition, String.Join("", inputArray));

                if (inputArray[inputArray.Count - 1] != '#')
                {
                    inputArray.Add('#');
                }

                if (IsAcceptanceStatus(currentState)) break;
            }
        }

        private void MakingTransition(Transition tran, string input)
        {
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

        private bool IsAcceptanceStatus(string state_)
        {
            return state_ == acceptanceStatus ? true : false;
        }

    }
}