using System;
using System.Collections.Generic;
using System.Linq;

namespace BulanikMantik.Models
{
    public class FuzzyInferenceSystem
    {
        public Dictionary<string, FuzzyVariable> Inputs { get; set; }
        public Dictionary<string, FuzzyVariable> Outputs { get; set; }
        public List<FuzzyRule> Rules { get; set; }

        public FuzzyInferenceSystem()
        {
            Inputs = new Dictionary<string, FuzzyVariable>();
            Outputs = new Dictionary<string, FuzzyVariable>();
            Rules = new List<FuzzyRule>();
        }

        public Dictionary<string, double> Evaluate(Dictionary<string, double> crispInputs)
        {
            var outputAggregates = new Dictionary<string, Dictionary<string, double>>();

            foreach (var output in Outputs)
            {
                outputAggregates[output.Key] = output.Value.Sets.ToDictionary(s => s.Name, s => 0.0);
            }

            foreach (var rule in Rules)
            {
                var firingStrengths = rule.Inputs.Select(input =>
                    Inputs[input.Key].Fuzzify(crispInputs[input.Key])[input.Value]).ToList();

                double alpha = firingStrengths.Min();

                foreach (var output in rule.Outputs)
                {
                    outputAggregates[output.Key][output.Value] = Math.Max(outputAggregates[output.Key][output.Value], alpha);
                }
            }

            return outputAggregates.ToDictionary(
                kv => kv.Key,
                kv => DefuzzifyWeightedAverage(Outputs[kv.Key], kv.Value)
            );
        }

        private double DefuzzifyWeightedAverage(FuzzyVariable variable, Dictionary<string, double> memberships)
        {
            double numerator = 0, denominator = 0;
            foreach (var kvp in memberships)
            {
                var center = GetSetCenter(variable.Sets.First(s => s.Name == kvp.Key));
                numerator += kvp.Value * center;
                denominator += kvp.Value;
            }
            return denominator == 0 ? 0 : numerator / denominator;
        }

        private double GetSetCenter(FuzzySet set)
        {
            if (set.Type == "triangle") return set.Points[1];
            else return (set.Points[1] + set.Points[2]) / 2;
        }

        public List<string> GetTriggeredRules(Dictionary<string, double> crispInputs)
        {
            var triggeredRules = new List<string>();

            foreach (var rule in Rules)
            {
                var firingStrengths = rule.Inputs.Select(input =>
                    Inputs[input.Key].Fuzzify(crispInputs[input.Key])[input.Value]).ToList();

                double alpha = firingStrengths.Min();

                if (alpha > 0)
                {
                    string ruleDescription = $"[Tetiklendi] Girişler: " +
                        $"{string.Join(", ", rule.Inputs.Select(kv => $"{kv.Key}={kv.Value}"))} " +
                        $"=> Çıkışlar: {string.Join(", ", rule.Outputs.Select(kv => $"{kv.Key}={kv.Value}"))} " +
                        $"| Güç (α): {alpha:0.00}";

                    triggeredRules.Add(ruleDescription);
                }
            }

            return triggeredRules;
        }
    }
}
