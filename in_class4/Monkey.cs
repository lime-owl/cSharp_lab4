using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Console
{
    class Monkey : Mammal
    {
        public Monkey(string speciesName, string weight):base("Monkey", "Instructions: Keep area secure at all times.", "Feed at 9AM, 12PM, and 5PM.", " fresh fruit, vegetables, nuts, insects, berries", speciesName, weight )
        {

        }
    }
}
