using System;
using System.Collections.Generic;
using ClassLibrarySort;

namespace TestSort
{
    public class TestSort
    {
        /// <summary>
        /// �������, ������������ ������ ��� ����������
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestData()
        {
            int[] data1 = { 54, 32, 4, 28, 75, -46, 74, 80, 3, 45 }; // ������� ������
            int[] expectedAsc1 = { -46, 3, 4, 28, 32, 45, 54, 74, 75, 80 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc1 = { 80, 75, 74, 54, 45, 32, 28, 4, 3, -46 }; // ��������� ��������� ���������� �� ��������

            int[] data2 = { 361, 729, 640, 932, 456, 694, 487, 619, 806, 300 }; // ������� ������
            int[] expectedAsc2 = { 300, 361, 456, 487, 619, 640, 694, 729, 806, 932 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc2 = { 932, 806, 729, 694, 640, 619, 487, 456, 361, 300 }; // ��������� ��������� ���������� �� ��������

            int[] data3 = { 2480, 7180, 9494, -3868, 7100, 6884, 7209, 15, 216, 8311 }; // ������� ������
            int[] expectedAsc3 = { -3868, 15, 216, 2480, 6884, 7100, 7180, 7209, 8311, 9494 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc3 = { 9494, 8311, 7209, 7180, 7100, 6884, 2480, 216, 15, -3868 }; // ��������� ��������� ���������� �� ��������

            int[] data4 = { 948, 444, 32, 948, 973, 216, 70, 573, 210, 530 }; // ������� ������
            int[] expectedAsc4 = { 32, 70, 210, 216, 444, 530, 573, 948, 948, 973 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc4 = { 973, 948, 948, 573, 530, 444, 216, 210, 70, 32 }; // ��������� ��������� ���������� �� ��������

            int[] data5 = { 21, 41, 38, 13, 17, 90, 75, 71, 29, 22, 5, 46, 22, 69, 72 }; // ������� ������
            int[] expectedAsc5 = { 5, 13, 17, 21, 22, 22, 29, 38, 41, 46, 69, 71, 72, 75, 90 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc5 = { 90, 75, 72, 71, 69, 46, 41, 38, 29, 22, 22, 21, 17, 13, 5 }; // ��������� ��������� ���������� �� ��������
            // ������� ������ ��� ������������� � ������
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
            yield return new object[] { data4, expectedAsc4, expectedDesc4 };
            yield return new object[] { data5, expectedAsc5, expectedDesc5 };
        }
        /// <summary>
        /// �������, ������������ ������ ��� ���������� �� ���� �����
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataTwo()
        {
            int[] data1 = { 3, 3, 5, 3, 3, 5, 5, 3, 5, 5 }; // ������� ������
            int[] expectedAsc1 = { 3, 3, 3, 3, 3, 5, 5, 5, 5, 5 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc1 = { 5, 5, 5, 5, 5, 3, 3, 3, 3, 3 }; // ��������� ��������� ���������� �� ��������

            int[] data2 = { 98, 98, 122, 98, 98, 122, 122, 122, 98, 122 }; // ������� ������
            int[] expectedAsc2 = { 98, 98, 98, 98, 98, 122, 122, 122, 122, 122 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc2 = { 122, 122, 122, 122, 122, 98, 98, 98, 98, 98 }; // ��������� ��������� ���������� �� ��������

            int[] data3 = { 712, 712, 712, 2048, 2048, 2048, 712, 2048, 712, 2048 }; // ������� ������
            int[] expectedAsc3 = { 712, 712, 712, 712, 712, 2048, 2048, 2048, 2048, 2048 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc3 = { 2048, 2048, 2048, 2048, 2048, 712, 712, 712, 712, 712 }; // ��������� ��������� ���������� �� ��������
            // ������� ������ ��� ������������� � ������
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// �������, ������������ ������ ��� ���������� �� ���� �����
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataThree()
        {
            int[] data1 = { 5, 2, 5, 9, 2, 5, 9, 5, 2, 9 }; // ������� ������
            int[] expectedAsc1 = { 2, 2, 2, 5, 5, 5, 5, 9, 9, 9 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc1 = { 9, 9, 9, 5, 5, 5, 5, 2, 2, 2 }; // ��������� ��������� ���������� �� ��������

            int[] data2 = { 78, 11, 222, 78, 78, 78, 222, 222, 78, 11 }; // ������� ������
            int[] expectedAsc2 = { 11, 11, 78, 78, 78, 78, 78, 222, 222, 222 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc2 = { 222, 222, 222, 78, 78, 78, 78, 78, 11, 11 }; // ��������� ��������� ���������� �� ��������

            int[] data3 = { 1072, 4582, 11111, 4582, 1072, 1072, 11111, 4582, 11111, 1072 }; // ������� ������
            int[] expectedAsc3 = { 1072, 1072, 1072, 1072, 4582, 4582, 4582, 11111, 11111, 11111 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc3 = { 11111, 11111, 11111, 4582, 4582, 4582, 1072, 1072, 1072, 1072 }; // ��������� ��������� ���������� �� ��������
            // ������� ������ ��� ������������� � ������
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// �������, ������������ ������ ��� ���������� �� ������� �����
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataFour()
        {
            int[] data1 = { 3, 2, 4, 2, 3, 4, 2, 4, 4, 1 }; // ������� ������
            int[] expectedAsc1 = { 1, 2, 2, 2, 3, 3, 4, 4, 4, 4 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc1 = { 4, 4, 4, 4, 3, 3, 2, 2, 2, 1 }; // ��������� ��������� ���������� �� ��������

            int[] data2 = { 111, 27, -45, 111, 111, -45, 111, -45, 111, 92 }; // ������� ������
            int[] expectedAsc2 = { -45, -45, -45, 27, 92, 111, 111, 111, 111, 111 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc2 = { 111, 111, 111, 111, 111, 92, 27, -45, -45, -45 }; // ��������� ��������� ���������� �� ��������

            int[] data3 = { 1222, 988, 7812, 12345, 12345, 988, 1222, 1222, 7812, 7812 }; // ������� ������
            int[] expectedAsc3 = { 988, 988, 1222, 1222, 1222, 7812, 7812, 7812, 12345, 12345 }; // ��������� ��������� ���������� �� �����������
            int[] expectedDesc3 = { 12345, 12345, 7812, 7812, 7812, 1222, 1222, 1222, 988, 988 }; // ��������� ��������� ���������� �� ��������
            // ������� ������ ��� ������������� � ������
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// ����� �������� ���������� ���������
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void BubbleTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.BubbleSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.BubbleSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� ���������
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void InsertTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.InsertSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.InsertSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� ��������
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void MergeTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.MergeSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.MergeSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ������� ����������
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void QuickSort(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.QuickSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.QuickSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� ���������
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void CountTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.CountSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.CountSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� �� ���� �����
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataTwo))]
        public void TwoTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.TwoSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.TwoSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� �� ���� �����
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataThree))]
        public void ThreeTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.ThreeSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.ThreeSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
        /// <summary>
        /// ����� �������� ���������� �� ������� �����
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataFour))]
        public void FourTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.FourSort(m); // ��������� ����������
            Assert.Equal(expectedAsc, resultAsc); // ��������� � ��������� ���������

            int[] resultDesc = ClassSort.FourSort(m, true); // ��������� ����������
            Assert.Equal(expectedDesc, resultDesc); // ��������� � ��������� ���������
        }
    }
}