using System.Collections.Generic;

namespace BulanikMantik.Models
{
    public class FuzzyRule
    {
        public Dictionary<string, string> Inputs { get; set; }
        public Dictionary<string, string> Outputs { get; set; }

        public FuzzyRule()
        {
            Inputs = new Dictionary<string, string>();
            Outputs = new Dictionary<string, string>();
        }
    }
}
