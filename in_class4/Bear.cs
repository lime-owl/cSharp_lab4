using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Console
{
    class Bear : Mammal
    {
        public Bear(string speciesName, string weight):base("Bear", "Keep area secure at all times.", "Feed at 9AM and 3PM.", " berries, fish", speciesName, weight)
        {

        }
    }
}
