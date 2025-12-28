using System.Collections.Generic;
using BulanikMantik.Models;

namespace BulanikMantik

{
    public static class FuzzyInitializer
    {
        public static FuzzyInferenceSystem CreateSystem()
        {
            var system = new FuzzyInferenceSystem();

            var hassaslik = new FuzzyVariable("Hassaslik");
            hassaslik.Sets.Add(new FuzzySet("saglam", "trapezoid", new List<double> { -4, -1.5, 2, 4 }));
            hassaslik.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 3, 5, 7 }));
            hassaslik.Sets.Add(new FuzzySet("hassas", "trapezoid", new List<double> { 5.5, 8, 12.5, 14 }));
            system.Inputs["Hassaslik"] = hassaslik;

            var miktar = new FuzzyVariable("Miktar");
            miktar.Sets.Add(new FuzzySet("kucuk", "trapezoid", new List<double> { -4, -1.5, 2, 4 }));
            miktar.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 3, 5, 7 }));
            miktar.Sets.Add(new FuzzySet("buyuk", "trapezoid", new List<double> { 5.5, 8, 12.5, 14 }));
            system.Inputs["Miktar"] = miktar;

            var kirlilik = new FuzzyVariable("Kirlilik");
            kirlilik.Sets.Add(new FuzzySet("kucuk", "trapezoid", new List<double> { -4.5, -2.5, 2, 4.5 }));
            kirlilik.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 3, 5, 7 }));
            kirlilik.Sets.Add(new FuzzySet("buyuk", "trapezoid", new List<double> { 5.5, 8, 12.5, 15 }));
            system.Inputs["Kirlilik"] = kirlilik;

            var donusHizi = new FuzzyVariable("DonusHizi");
            donusHizi.Sets.Add(new FuzzySet("hassas", "trapezoid", new List<double> { -5.8, -2.8, 0.5, 1.5 }));
            donusHizi.Sets.Add(new FuzzySet("normal_hassas", "triangle", new List<double> { 0.5, 2.75, 5 }));
            donusHizi.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 2.75, 5, 7.25 }));
            donusHizi.Sets.Add(new FuzzySet("normal_guclu", "triangle", new List<double> { 5, 7.25, 9.5 }));
            donusHizi.Sets.Add(new FuzzySet("guclu", "trapezoid", new List<double> { 8.5, 9.5, 12.8, 15.2 }));
            system.Outputs["DonusHizi"] = donusHizi;

            var sure = new FuzzyVariable("Sure");
            sure.Sets.Add(new FuzzySet("kisa", "trapezoid", new List<double> { -46.5, -25.28, 22.3, 39.9 }));
            sure.Sets.Add(new FuzzySet("normal_kisa", "triangle", new List<double> { 22.3, 39.9, 57.5 }));
            sure.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 39.9, 57.5, 75.1 }));
            sure.Sets.Add(new FuzzySet("normal_uzun", "triangle", new List<double> { 57.5, 75.1, 92.7 }));
            sure.Sets.Add(new FuzzySet("uzun", "trapezoid", new List<double> { 75, 92.7, 111.6, 130 }));
            system.Outputs["Sure"] = sure;

            var deterjan = new FuzzyVariable("Deterjan");
            deterjan.Sets.Add(new FuzzySet("cok_az", "trapezoid", new List<double> { 0, 0, 20, 85 }));
            deterjan.Sets.Add(new FuzzySet("az", "triangle", new List<double> { 20, 85, 150 }));
            deterjan.Sets.Add(new FuzzySet("orta", "triangle", new List<double> { 85, 150, 215 }));
            deterjan.Sets.Add(new FuzzySet("fazla", "triangle", new List<double> { 150, 215, 280 }));
            deterjan.Sets.Add(new FuzzySet("cok_fazla", "trapezoid", new List<double> { 215, 280, 300, 300 }));
            system.Outputs["Deterjan"] = deterjan;

            AddRules(system);

            return system;
        }

        private static void AddRules(FuzzyInferenceSystem system)
        {
            system.Rules.Add(CreateRule("hassas", "kucuk", "kucuk", "hassas", "kisa", "cok_az"));
            system.Rules.Add(CreateRule("hassas", "kucuk", "orta", "normal_hassas", "kisa", "az"));
            system.Rules.Add(CreateRule("hassas", "kucuk", "buyuk", "orta", "normal_kisa", "orta"));
            system.Rules.Add(CreateRule("hassas", "orta", "kucuk", "hassas", "kisa", "orta"));
            system.Rules.Add(CreateRule("hassas", "orta", "orta", "normal_hassas", "normal_kisa", "orta"));
            system.Rules.Add(CreateRule("hassas", "orta", "buyuk", "orta", "orta", "fazla"));
            system.Rules.Add(CreateRule("hassas", "buyuk", "kucuk", "normal_hassas", "normal_kisa", "orta"));
            system.Rules.Add(CreateRule("hassas", "buyuk", "orta", "normal_hassas", "orta", "fazla"));
            system.Rules.Add(CreateRule("hassas", "buyuk", "buyuk", "orta", "normal_uzun", "fazla"));

            system.Rules.Add(CreateRule("orta", "kucuk", "kucuk", "normal_hassas", "normal_kisa", "az"));
            system.Rules.Add(CreateRule("orta", "kucuk", "orta", "orta", "kisa", "orta"));
            system.Rules.Add(CreateRule("orta", "kucuk", "buyuk", "normal_guclu", "orta", "fazla"));
            system.Rules.Add(CreateRule("orta", "orta", "kucuk", "normal_hassas", "normal_kisa", "orta"));
            system.Rules.Add(CreateRule("orta", "orta", "orta", "orta", "orta", "orta"));
            system.Rules.Add(CreateRule("orta", "orta", "buyuk", "hassas", "uzun", "fazla"));
            system.Rules.Add(CreateRule("orta", "buyuk", "kucuk", "hassas", "orta", "orta"));
            system.Rules.Add(CreateRule("orta", "buyuk", "orta", "hassas", "normal_uzun", "fazla"));
            system.Rules.Add(CreateRule("orta", "buyuk", "buyuk", "hassas", "uzun", "cok_fazla"));

            system.Rules.Add(CreateRule("saglam", "kucuk", "kucuk", "orta", "orta", "az"));
            system.Rules.Add(CreateRule("saglam", "kucuk", "orta", "normal_guclu", "orta", "orta"));
            system.Rules.Add(CreateRule("saglam", "kucuk", "buyuk", "guclu", "normal_uzun", "fazla"));
            system.Rules.Add(CreateRule("saglam", "orta", "kucuk", "orta", "orta", "orta"));
            system.Rules.Add(CreateRule("saglam", "orta", "orta", "normal_guclu", "normal_uzun", "orta"));
            system.Rules.Add(CreateRule("saglam", "orta", "buyuk", "guclu", "orta", "cok_fazla"));
            system.Rules.Add(CreateRule("saglam", "buyuk", "kucuk", "normal_guclu", "normal_uzun", "fazla"));
            system.Rules.Add(CreateRule("saglam", "buyuk", "orta", "normal_guclu", "uzun", "fazla"));
            system.Rules.Add(CreateRule("saglam", "buyuk", "buyuk", "guclu", "uzun", "cok_fazla"));
        }

        private static FuzzyRule CreateRule(string hassaslik, string miktar, string kirlilik, string donusHizi, string sure, string deterjan)
        {
            var rule = new FuzzyRule();
            rule.Inputs["Hassaslik"] = hassaslik;
            rule.Inputs["Miktar"] = miktar;
            rule.Inputs["Kirlilik"] = kirlilik;
            rule.Outputs["DonusHizi"] = donusHizi;
            rule.Outputs["Sure"] = sure;
            rule.Outputs["Deterjan"] = deterjan;
            return rule;
        }
    }
}
