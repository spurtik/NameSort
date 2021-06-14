using System;
using NameSorter.Models;

namespace NameSorter.Comparers
{
    public class NameComparer : INameComparer<NameSorterObject>
    {
        public int Compare(NameSorterObject objectA, NameSorterObject objectB)
        {
            if (objectA.LastName.CompareTo(objectB.LastName) > 0)
            {
                return 1;
            }
            else if (objectA.LastName.CompareTo(objectB.LastName) < 0)
            {
                return -1;
            }

            int maximumNumberToLoop = Math.Min(objectA.NumberOfGivenNames, objectB.NumberOfGivenNames);

            for (int i = 0; i < maximumNumberToLoop; i++)
            {
                if (objectA.GivenNames[i].CompareTo(objectB.GivenNames[i]) > 0)
                {
                    return 1;
                }
                else if (objectA.GivenNames[i].CompareTo(objectB.GivenNames[i]) < 0)
                {
                    return -1;
                }
            }

            if (objectA.NumberOfGivenNames > objectB.NumberOfGivenNames)
            {
                return 1;
            }
            else if(objectA.NumberOfGivenNames < objectB.NumberOfGivenNames)
            {
                return -1;
            }

            return 0;
        }
    }
}