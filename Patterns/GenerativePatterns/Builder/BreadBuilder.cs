using System.Collections.Generic;

namespace Patterns.GenerativePatterns.Builder
{
    internal abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }
        public void StartBake()
        {
            Bread = new Bread();
        }

        public abstract void AddFlour();
        public abstract void AddYeast();
        public abstract void AddAdditionals();
    }
}
