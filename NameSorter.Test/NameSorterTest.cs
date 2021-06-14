using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Comparers;
using NameSorter.Models;
using NameSorter.Sorters;
using System.Linq;

namespace NameSorter.Test
{
    [TestClass]
    public class NameSorterTest
    {
        [TestMethod]
        public void GivenANullValue_ShouldThrowAgurmentNullException()
        {
             //arrange
            ISorter<NameSorterObject> sorter = new NameSorter.Sorters.NameSort(new NameComparer());
            //action & assertion
            Assert.ThrowsException<ArgumentNullException>(() => sorter.Sort(null));
        }
    
    [TestMethod]
        public void GivenAEmptyValue_TheSortFunctionShouldReturnEmptyList()
        {
            //arrange
            ISorter<NameSorterObject> sorter = new NameSorter.Sorters.NameSort(new NameComparer());
            List<NameSorterObject> listEmptyObject = new List<NameSorterObject>();
            //action
            sorter.Sort(listEmptyObject);
            //assertion
            Assert.AreEqual(0, listEmptyObject.Count);
        }

        [TestMethod]
        public void GivenListOfObjectHasOnlyOneItem_TheSortFunctionShouldReturnOneItem()
        {
            //arrange
            ISorter<NameSorterObject> sorter = new NameSorter.Sorters.NameSort(new NameComparer());
            List<NameSorterObject> listObject = FizzWare.NBuilder.Builder<NameSorterObject>.CreateListOfSize(1).Build().ToList();
            //action
            sorter.Sort(listObject);
            //assertion
            Assert.AreEqual(1, listObject.Count);
        }

        [TestMethod]
        public void GivenOneThousandElements_ElementShouldBeSorted()
        {
            //arrange
            ISorter<NameSorterObject> sorter = new NameSorter.Sorters.NameSort(new NameComparer());
            List<NameSorterObject> listObject = FizzWare.NBuilder.Builder<NameSorterObject>.CreateListOfSize(1000).Build().OrderByDescending(a => a.LastName).ToList();
            List<NameSorterObject> sortedlistObject = listObject.OrderBy(a => a.LastName).ToList();
            //action
            sorter.Sort(listObject);
            //assertion
            for (int i = 0; i < listObject.Count; i++)
            {
                Assert.AreEqual(sortedlistObject[i], listObject[i]);
            }
        }
    }
}
