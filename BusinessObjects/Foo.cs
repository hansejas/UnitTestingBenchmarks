using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class Foo
    {
        public IList<int> GetIntFromStrings(IList<string> strings)
        {
            if (strings == null)
            {
                throw new ArgumentNullException("strings cannot be null");
            }

            if (strings.Count <= 0)
            {
                throw new ArgumentException("strings must have a count greater than zero");
            }

            var ints = new List<int>();
            int currentInt;
            foreach (var stringValue in strings)
            {
                if (int.TryParse(stringValue, out currentInt))
                {
                    ints.Add(currentInt);
                }
            }
            return ints;
        }
    }
}
