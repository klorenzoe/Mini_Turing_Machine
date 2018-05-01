using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuringMachine.Models
{
    public class State
    {
        public string currentState { get; set; }

        public List<Transition> possibleTransitions { get; set; }
    }
}