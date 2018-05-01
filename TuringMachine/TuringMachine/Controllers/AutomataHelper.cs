using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TuringMachine.Models;


namespace TuringMachine.Controllers
{
    public static class AutomataHelper
    {
        private static bool AreTheAutomatasFilled = false;
        public static List<State> palindromesAutomata { get; set; }
        

        public static void fillAutomatas() {
            if (!AreTheAutomatasFilled)
            {
                palindromesAutomata = fillPalindromesStatus();

                AreTheAutomatasFilled = true;
            }
        }
        private static List<State> fillPalindromesStatus()
        {
            //q0
            var q0 = new State()
            {
                currentState = "q0",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q1", transitionSymbol="#", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q4", transitionSymbol="#", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q6", transitionSymbol="#", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q8", transitionSymbol="#", movement="R"}
                }
            };
            //q1
            var q1 = new State()
            {
                currentState = "q1",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q1", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q1", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q1", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q2", transitionSymbol="#", movement="L"}
                }
            };
            //q2
            var q2 = new State()
            {
                currentState = "q2",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q3", transitionSymbol="#", movement="L"},
                    new Transition() { currentSymbol = "#", transitionState="q8", transitionSymbol="#", movement="L"}
                }
            };
            //q3
            var q3 = new State()
            {
                currentState = "q3",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q3", transitionSymbol="a", movement="L"},
                    new Transition() { currentSymbol = "b", transitionState="q3", transitionSymbol="b", movement="L"},
                    new Transition() { currentSymbol = "c", transitionState="q3", transitionSymbol="c", movement="L"},
                    new Transition() { currentSymbol = "#", transitionState="q0", transitionSymbol="#", movement="R"}
                }
            };
            //q4
            var q4 = new State()
            {
                currentState = "q4",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q4", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q4", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q4", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q5", transitionSymbol="#", movement="L"}
                }
            };
            //q5
            var q5 = new State()
            {
                currentState = "q5",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "b", transitionState="q3", transitionSymbol="#", movement="L"},
                    new Transition() { currentSymbol = "#", transitionState="q8", transitionSymbol="#", movement="L"},
                }
            };
            //q6
            var q6 = new State()
            {
                currentState = "q6",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q6", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q6", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q6", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q7", transitionSymbol="#", movement="L"}
                }
            };
            //q7
            var q7 = new State()
            {
                currentState = "q7",
                possibleTransitions = new List<Transition>()
                {
                   new Transition() { currentSymbol = "c", transitionState="q3", transitionSymbol="#", movement="L"},
                   new Transition() { currentSymbol = "#", transitionState="q8", transitionSymbol="#", movement="L"}
                }
            };
            //q8

            var automataStates = new List<State>();
            automataStates.Add(q0);
            automataStates.Add(q1);
            automataStates.Add(q2);
            automataStates.Add(q3);
            automataStates.Add(q4);
            automataStates.Add(q5);
            automataStates.Add(q6);
            automataStates.Add(q7);
            return automataStates;
        }
    }
}