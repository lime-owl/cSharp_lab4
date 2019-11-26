using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace in_class4
{
    abstract class Mammal
    {
       public string MammalName { get; set; }
       public string SpeciesName { get; set; }
       public string Weight { get; set; }
       public string Note { get; set; }
       public string FeedNote { get; set; }
       public string Diet { get; set; }

        public Mammal (string mname, string note, string feedNote, string diet, string speciesName, string weight)
        {
            MammalName = mname;
            SpeciesName = speciesName;
            Diet = diet;
            Weight = weight;
            Note = note;
            FeedNote = feedNote;
        }
        public string GetServing(string w)
        {
            decimal convertVal = decimal.Parse(w);
            decimal total = decimal.Multiply(convertVal, 0.008m);
            return total.ToString(CultureInfo.InvariantCulture);
        }
    }
}
