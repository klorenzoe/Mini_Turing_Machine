using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuringMachine.Models
{
    public class Transition
    {
        public string currentSymbol { get; set; }
        public string transitionState { get; set; }
        public string transitionSymbol { get; set; }
        public string movement { get; set; }
    }
}