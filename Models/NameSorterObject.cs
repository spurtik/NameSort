using System.Collections.Generic;

namespace NameSorter.Models
{
    public class NameSorterObject
    {
        public NameSorterObject() 
        {
            GivenNames = new List<string>();
        }
        public string LastName 
        {
            get;
            set;
        }
        public List<string> GivenNames 
        {
            get;
            set;
        }
        public int NumberOfGivenNames 
        {
            get 
            {
                return GivenNames.Count;
            }
        }
        public string FullName => $"{string.Join(" ", GivenNames)} {LastName}";
    }
}