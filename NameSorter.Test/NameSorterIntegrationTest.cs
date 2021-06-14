using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Comparers;
using NameSorter.Helpers;
using NameSorter.Models;
using NameSorter.Sorters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Test
{
    [TestClass]
    public class NameSorterIntegrationTest
    {
        private void SortedResult(NameSorterObject[] arr)
        {
            Array.Sort(arr, new FakeComparer());
        }

        private NameSorterObject[] ExpectedResultOfTenElements;

        public NameSorterIntegrationTest()
        {
            IFileHelper<NameSorterObject> fileHelper = new NameSorterFileHelper("unsorted-names-list.txt", "sorted-names-list.txt");
            List<NameSorterObject> listObj = fileHelper.ReadFile();
            NameSorterObject[] arr = listObj.ToArray();
            SortedResult(arr);
            ExpectedResultOfTenElements = arr;
        }

        [TestMethod]
        public void GivenListOfObjectHasOneThousandNames_OrderByASC()
        {
            ISorter<NameSorterObject> sorter = new NameSorter.Sorters.NameSort(new NameComparer());
            IFileHelper<NameSorterObject> fileHelper = new NameSorterFileHelper("unsorted-names-list.txt", "sorted-names-list.txt");
            List<NameSorterObject> listObj = fileHelper.ReadFile();

            sorter.Sort(listObj);

            fileHelper.WriteFile(listObj);

            for (int i = 0; i < listObj.Count; i++)
            {
                Assert.AreEqual(ExpectedResultOfTenElements[i].FullName, listObj[i].FullName);
            }
        }
    }
}