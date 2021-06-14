using NameSorter.Comparers;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NameSorter.Test
{
    public class FakeComparer : IComparer<NameSorterObject>
    {
        public int Compare([AllowNull] NameSorterObject objectA, [AllowNull] NameSorterObject objectB)
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
            else if (objectA.NumberOfGivenNames < objectB.NumberOfGivenNames)
            {
                return -1;
            }

            return 0;
        }
    }
}