namespace Projekt_1
{
    [TestClass]
    public class UnitTest1
    {
        int[] sortedArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] sortedArray2 = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
        int[] sortedArray3 = { -11, -8, -6, -5, -4, -3, -1, 0, 1, 2, 7, 8, 9, 10, 12, 13, 15, 16, 19, 24 };
        int[] sortedArray4 = { -777, -555, -432, -312, -123, -90, -67, 13, 55, 89, 99, 108, 234, 246, 321, 321, 444, 777, 987 };
        int[] sortedArray5 = 
            { -67108864, -8388608, -1048576, -131072, -16384, -2048, -256, 512, 1024, 4096, 8192, 32768, 65536, 262144, 524288, 2097152, 4194304, 16777216, 33554432, 134217728 };
        
        int[] unsortedArray1_1 = { 3, 5, 2, 1, 7, 6, 10, 8, 9, 4 };
        int[] unsortedArray1_2 = { 9, 7, 5, 1, 8, 6, 10, 3, 4, 2 };
        int[] unsortedArray1_3 = { 6, 5, 3, 1, 2, 10, 4, 7, 8, 9 };
        
        int[] unsortedArray2_1 = { 5, -1, -5, -4, 3, -3, -2, 2, 0, 4, 1 };
        int[] unsortedArray2_2 = { 2, 1, -5, 0, 3, 4, -1, -2, 5, -3, -4 };
        int[] unsortedArray2_3 = { -3, -4, -5, 4, 0, -1, 5, 1, 2, -2, 3 };
        
        int[] unsortedArray3_1 = { -1, -5, -11, 8, 7, 19, 24, 15, 10, 1, -3, 2, 9, 12, 16, -6, -4, 13, -8, 0 };
        int[] unsortedArray3_2 = { -6, 10, 24, 9, 16, 8, -4, -1, 1, 2, 13, 7, 19, 12, -3, 0, 15, -11, -8, -5 };
        int[] unsortedArray3_3 = { -6, -1, 16, 12, -4, 0, 13, -11, 10, 1, 15, 8, 2, 24, 7, 9, -8, -3, 19, -5 };
        
        int[] unsortedArray4_1 = { -432, 13, -312, -555, 777, 55, -67, -123, 321, 246, 321, 444, -90, 234, 89, 108, -777, 987, 99};
        int[] unsortedArray4_2 = { -67, 246, 987, -312, -555, -90, 89, 55, -123, 777, 321, 13, 99, 108, -777, 444, -432, 321, 234 };
        int[] unsortedArray4_3 = { -123, 55, 987, 321, 444, -555, -432, -312, 99, 108, 777, -90, 321, 234, 246, -67, 89, -777, 13 };
        
        int[] unsortedArray5_1 = { 1024, 4096, -256, 134217728, -8388608, 33554432, 16777216, -131072, 8192, 4194304, -1048576, 512, 262144, -16384, 524288, 32768, -2048, 65536, 2097152, -67108864 };
        int[] unsortedArray5_2 = { -131072, 1024, -16384, -8388608, -256, 33554432, 262144, 65536, 4096, 32768, 8192, 4194304, 524288, -2048, 16777216, 134217728, 2097152, -67108864, 512, -1048576 };
        int[] unsortedArray5_3 = { -1048576, 134217728, 65536, 33554432, 262144, 524288, -16384, 4096, 512, 16777216, -131072, 2097152, 1024, 4194304, -67108864, 8192, -256, -8388608, 32768, -2048 };

        // SelectionSort
        [TestMethod]
        public void TestSelectionSort_Array1()
        {
            SortingAlgorithms.SelectionSort(unsortedArray1_1);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_1);

            SortingAlgorithms.SelectionSort(unsortedArray1_2);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_2);

            SortingAlgorithms.SelectionSort(unsortedArray1_3);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_3);
        }

        [TestMethod]
        public void TestSelectionSort_Array2()
        {
            SortingAlgorithms.SelectionSort(unsortedArray2_1);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_1);

            SortingAlgorithms.SelectionSort(unsortedArray2_2);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_2);

            SortingAlgorithms.SelectionSort(unsortedArray2_3);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_3);
        }

        [TestMethod]
        public void TestSelectionSort_Array3()
        {
            SortingAlgorithms.SelectionSort(unsortedArray3_1);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_1);

            SortingAlgorithms.SelectionSort(unsortedArray3_2);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_2);

            SortingAlgorithms.SelectionSort(unsortedArray3_3);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_3);
        }

        [TestMethod]
        public void TestSelectionSort_Array4()
        {
            SortingAlgorithms.SelectionSort(unsortedArray4_1);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_1);

            SortingAlgorithms.SelectionSort(unsortedArray4_2);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_2);

            SortingAlgorithms.SelectionSort(unsortedArray4_3);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_3);
        }
        [TestMethod]
        public void TestSelectionSort_Array5()
        {
            SortingAlgorithms.SelectionSort(unsortedArray5_1);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_1);

            SortingAlgorithms.SelectionSort(unsortedArray5_2);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_2);

            SortingAlgorithms.SelectionSort(unsortedArray5_3);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_3);
        }

        // Insertion Sort
        [TestMethod]
        public void TestInsertionSort_Array1()
        {
            SortingAlgorithms.InsertionSort(unsortedArray1_1);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_1);

            SortingAlgorithms.InsertionSort(unsortedArray1_2);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_2);

            SortingAlgorithms.InsertionSort(unsortedArray1_3);
            CollectionAssert.AreEqual(sortedArray1, unsortedArray1_3);
        }

        [TestMethod]
        public void TestInsertionSort_Array2()
        {
            SortingAlgorithms.InsertionSort(unsortedArray2_1);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_1);

            SortingAlgorithms.InsertionSort(unsortedArray2_2);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_2);

            SortingAlgorithms.InsertionSort(unsortedArray2_3);
            CollectionAssert.AreEqual(sortedArray2, unsortedArray2_3);
        }

        [TestMethod]
        public void TestInsertionSort_Array3()
        {
            SortingAlgorithms.InsertionSort(unsortedArray3_1);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_1);

            SortingAlgorithms.InsertionSort(unsortedArray3_2);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_2);

            SortingAlgorithms.InsertionSort(unsortedArray3_3);
            CollectionAssert.AreEqual(sortedArray3, unsortedArray3_3);
        }

        [TestMethod]
        public void TestInsertionSort_Array4()
        {
            SortingAlgorithms.InsertionSort(unsortedArray4_1);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_1);

            SortingAlgorithms.InsertionSort(unsortedArray4_2);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_2);

            SortingAlgorithms.InsertionSort(unsortedArray4_3);
            CollectionAssert.AreEqual(sortedArray4, unsortedArray4_3);
        }
        [TestMethod]
        public void TestInsertionSort_Array5()
        {
            SortingAlgorithms.InsertionSort(unsortedArray5_1);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_1);

            SortingAlgorithms.InsertionSort(unsortedArray5_2);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_2);

            SortingAlgorithms.InsertionSort(unsortedArray5_3);
            CollectionAssert.AreEqual(sortedArray5, unsortedArray5_3);
        }

    }
}