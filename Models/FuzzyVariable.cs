using System.Collections.Generic;
using System.Linq;

namespace BulanikMantik.Models
{
    public class FuzzyVariable
    {
        public string Name { get; set; }
        public List<FuzzySet> Sets { get; set; }

        public FuzzyVariable(string name)
        {
            Name = name;
            Sets = new List<FuzzySet>();
        }

        public Dictionary<string, double> Fuzzify(double input)
        {
            return Sets.ToDictionary(set => set.Name, set => set.GetMembership(input));
        }
    }
}
