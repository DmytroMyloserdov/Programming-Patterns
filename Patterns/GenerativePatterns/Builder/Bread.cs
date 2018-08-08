using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.GenerativePatterns.Builder
{
    internal class Bread
    {
        public string Flour { get; set; }
        public bool Yeast { get; set; }
        public List<string> Aditionals { get; set; }

        public Bread()
        {
            Aditionals = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"Flour: { Flour }\n");
            strb.Append(Yeast ? "Yeast\n" : "");
            strb.Append(Aditionals.Any() ? $"Additional:\n{ AdditionalToString() }" : "");

            return strb.ToString();
        }

        private string AdditionalToString()
        {
            StringBuilder strb = new StringBuilder();
            foreach (var add in Aditionals)
            {
                strb.Append($"\t{ add }\n");
            }
            return strb.ToString();
        }
    }
}
