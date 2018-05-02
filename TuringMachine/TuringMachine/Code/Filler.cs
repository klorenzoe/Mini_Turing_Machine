using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TuringMachine.Models;


namespace TuringMachine.Code
{
    public static class Filler
    {
        private static bool AreTheAutomatasFilled = false;
        public static List<State> palindromesAutomata { get; set; }
        public static List<State> replicatePatternAutomata { get; set; }


        public static void fillAutomatas() {
            if (!AreTheAutomatasFilled)
            {
                palindromesAutomata = fillPalindromesStatus();
                replicatePatternAutomata = fillReplicatePatternStatus();
                AreTheAutomatasFilled = true;
            }
        }


        #region filled
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

        private static List<State> fillReplicatePatternStatus()
        {
            //q0
            var q0 = new State()
            {
                currentState = "q0",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q0", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q0", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q0", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q1", transitionSymbol="#", movement="L"}
                }
            };
            //q1
            var q1 = new State()
            {
                currentState = "q1",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q2", transitionSymbol="X", movement="L"},
                    new Transition() { currentSymbol = "b", transitionState="q2", transitionSymbol="Y", movement="L"},
                    new Transition() { currentSymbol = "c", transitionState="q2", transitionSymbol="Z", movement="L"}
                }
            };
            //q2
            var q2 = new State()
            {
                currentState = "q2",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q2", transitionSymbol="a", movement="L"},
                    new Transition() { currentSymbol = "b", transitionState="q2", transitionSymbol="b", movement="L"},
                    new Transition() { currentSymbol = "c", transitionState="q2", transitionSymbol="c", movement="L"},
                    new Transition() { currentSymbol = "#", transitionState="q3", transitionSymbol="#", movement="R"},
                    new Transition() { currentSymbol = "A", transitionState="q3", transitionSymbol="A", movement="R"},
                    new Transition() { currentSymbol = "B", transitionState="q3", transitionSymbol="B", movement="R"},
                    new Transition() { currentSymbol = "C", transitionState="q3", transitionSymbol="C", movement="R"},
                    new Transition() { currentSymbol = "X", transitionState="q2", transitionSymbol="X", movement="L"},
                    new Transition() { currentSymbol = "Y", transitionState="q2", transitionSymbol="Y", movement="L"},
                    new Transition() { currentSymbol = "Z", transitionState="q2", transitionSymbol="Z", movement="L"}
                }
            };
            //q3
            var q3 = new State()
            {
                currentState = "q3",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q4", transitionSymbol="A", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q5", transitionSymbol="B", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q6", transitionSymbol="C", movement="R"},
                    new Transition() { currentSymbol = "X", transitionState="q7", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "Y", transitionState="q8", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "Z", transitionState="q9", transitionSymbol="c", movement="R"}
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
                    new Transition() { currentSymbol = "#", transitionState="q2", transitionSymbol="a", movement="L"},
                    new Transition() { currentSymbol = "X", transitionState="q4", transitionSymbol="X", movement="R"},
                    new Transition() { currentSymbol = "Y", transitionState="q4", transitionSymbol="Y", movement="R"},
                    new Transition() { currentSymbol = "Z", transitionState="q4", transitionSymbol="Z", movement="R"}
                }
            };
            //q5
            var q5 = new State()
            {
                currentState = "q5",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q5", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q5", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q5", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q2", transitionSymbol="b", movement="L"},
                    new Transition() { currentSymbol = "X", transitionState="q5", transitionSymbol="X", movement="R"},
                    new Transition() { currentSymbol = "Y", transitionState="q5", transitionSymbol="Y", movement="R"},
                    new Transition() { currentSymbol = "Z", transitionState="q5", transitionSymbol="Z", movement="R"}
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
                    new Transition() { currentSymbol = "#", transitionState="q2", transitionSymbol="c", movement="L"},
                    new Transition() { currentSymbol = "X", transitionState="q6", transitionSymbol="X", movement="R"},
                    new Transition() { currentSymbol = "Y", transitionState="q6", transitionSymbol="Y", movement="R"},
                    new Transition() { currentSymbol = "Z", transitionState="q6", transitionSymbol="Z", movement="R"}
                }
            };
            //q7
            var q7 = new State()
            {
                currentState = "q7",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q7", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q7", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q7", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q10", transitionSymbol="a", movement="L"},
                }
            };
            //q8
            var q8 = new State()
            {
                currentState = "q8",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q8", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q8", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q8", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q10", transitionSymbol="b", movement="L"},
                }
            };
            //q9
            var q9 = new State()
            {
                currentState = "q9",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q9", transitionSymbol="a", movement="R"},
                    new Transition() { currentSymbol = "b", transitionState="q9", transitionSymbol="b", movement="R"},
                    new Transition() { currentSymbol = "c", transitionState="q9", transitionSymbol="c", movement="R"},
                    new Transition() { currentSymbol = "#", transitionState="q10", transitionSymbol="c", movement="L"}
                }
            };
            //q10
            var q10 = new State()
            {
                currentState = "q10",
                possibleTransitions = new List<Transition>()
                {
                    new Transition() { currentSymbol = "a", transitionState="q10", transitionSymbol="a", movement="L"},
                    new Transition() { currentSymbol = "b", transitionState="q10", transitionSymbol="b", movement="L"},
                    new Transition() { currentSymbol = "c", transitionState="q10", transitionSymbol="c", movement="L"},
                    new Transition() { currentSymbol = "#", transitionState="q11", transitionSymbol="#", movement="R"},
                    new Transition() { currentSymbol = "A", transitionState="q10", transitionSymbol="a", movement="L"},
                    new Transition() { currentSymbol = "B", transitionState="q10", transitionSymbol="b", movement="L"},
                    new Transition() { currentSymbol = "C", transitionState="q10", transitionSymbol="c", movement="L"}
                }
            };
            var automataStates = new List<State>();
            automataStates.Add(q0);
            automataStates.Add(q1);
            automataStates.Add(q2);
            automataStates.Add(q3);
            automataStates.Add(q4);
            automataStates.Add(q5);
            automataStates.Add(q6);
            automataStates.Add(q7);
            automataStates.Add(q8);
            automataStates.Add(q9);
            automataStates.Add(q10);
            return automataStates;
        }

#endregion

    }
}