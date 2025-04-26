using System;
using System.Collections.Generic;
using ClassLibrarySort;

namespace TestSort
{
    public class TestSort
    {
        /// <summary>
        /// Функция, возвращающая данные для сортировок
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestData()
        {
            int[] data1 = { 54, 32, 4, 28, 75, -46, 74, 80, 3, 45 }; // Входные данные
            int[] expectedAsc1 = { -46, 3, 4, 28, 32, 45, 54, 74, 75, 80 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc1 = { 80, 75, 74, 54, 45, 32, 28, 4, 3, -46 }; // Ожидаемый результат сортировки по убыванию

            int[] data2 = { 361, 729, 640, 932, 456, 694, 487, 619, 806, 300 }; // Входные данные
            int[] expectedAsc2 = { 300, 361, 456, 487, 619, 640, 694, 729, 806, 932 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc2 = { 932, 806, 729, 694, 640, 619, 487, 456, 361, 300 }; // Ожидаемый результат сортировки по убыванию

            int[] data3 = { 2480, 7180, 9494, -3868, 7100, 6884, 7209, 15, 216, 8311 }; // Входные данные
            int[] expectedAsc3 = { -3868, 15, 216, 2480, 6884, 7100, 7180, 7209, 8311, 9494 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc3 = { 9494, 8311, 7209, 7180, 7100, 6884, 2480, 216, 15, -3868 }; // Ожидаемый результат сортировки по убыванию

            int[] data4 = { 948, 444, 32, 948, 973, 216, 70, 573, 210, 530 }; // Входные данные
            int[] expectedAsc4 = { 32, 70, 210, 216, 444, 530, 573, 948, 948, 973 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc4 = { 973, 948, 948, 573, 530, 444, 216, 210, 70, 32 }; // Ожидаемый результат сортировки по убыванию

            int[] data5 = { 21, 41, 38, 13, 17, 90, 75, 71, 29, 22, 5, 46, 22, 69, 72 }; // Входные данные
            int[] expectedAsc5 = { 5, 13, 17, 21, 22, 22, 29, 38, 41, 46, 69, 71, 72, 75, 90 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc5 = { 90, 75, 72, 71, 69, 46, 41, 38, 29, 22, 22, 21, 17, 13, 5 }; // Ожидаемый результат сортировки по убыванию
            // Возврат данных для использования в тестах
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
            yield return new object[] { data4, expectedAsc4, expectedDesc4 };
            yield return new object[] { data5, expectedAsc5, expectedDesc5 };
        }
        /// <summary>
        /// Функция, возвращающая данные для сортировки из двух чисел
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataTwo()
        {
            int[] data1 = { 3, 3, 5, 3, 3, 5, 5, 3, 5, 5 }; // Входные данные
            int[] expectedAsc1 = { 3, 3, 3, 3, 3, 5, 5, 5, 5, 5 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc1 = { 5, 5, 5, 5, 5, 3, 3, 3, 3, 3 }; // Ожидаемый результат сортировки по убыванию

            int[] data2 = { 98, 98, 122, 98, 98, 122, 122, 122, 98, 122 }; // Входные данные
            int[] expectedAsc2 = { 98, 98, 98, 98, 98, 122, 122, 122, 122, 122 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc2 = { 122, 122, 122, 122, 122, 98, 98, 98, 98, 98 }; // Ожидаемый результат сортировки по убыванию

            int[] data3 = { 712, 712, 712, 2048, 2048, 2048, 712, 2048, 712, 2048 }; // Входные данные
            int[] expectedAsc3 = { 712, 712, 712, 712, 712, 2048, 2048, 2048, 2048, 2048 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc3 = { 2048, 2048, 2048, 2048, 2048, 712, 712, 712, 712, 712 }; // Ожидаемый результат сортировки по убыванию
            // Возврат данных для использования в тестах
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// Функция, возвращающая данные для сортировки из трех чисел
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataThree()
        {
            int[] data1 = { 5, 2, 5, 9, 2, 5, 9, 5, 2, 9 }; // Входные данные
            int[] expectedAsc1 = { 2, 2, 2, 5, 5, 5, 5, 9, 9, 9 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc1 = { 9, 9, 9, 5, 5, 5, 5, 2, 2, 2 }; // Ожидаемый результат сортировки по убыванию

            int[] data2 = { 78, 11, 222, 78, 78, 78, 222, 222, 78, 11 }; // Входные данные
            int[] expectedAsc2 = { 11, 11, 78, 78, 78, 78, 78, 222, 222, 222 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc2 = { 222, 222, 222, 78, 78, 78, 78, 78, 11, 11 }; // Ожидаемый результат сортировки по убыванию

            int[] data3 = { 1072, 4582, 11111, 4582, 1072, 1072, 11111, 4582, 11111, 1072 }; // Входные данные
            int[] expectedAsc3 = { 1072, 1072, 1072, 1072, 4582, 4582, 4582, 11111, 11111, 11111 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc3 = { 11111, 11111, 11111, 4582, 4582, 4582, 1072, 1072, 1072, 1072 }; // Ожидаемый результат сортировки по убыванию
            // Возврат данных для использования в тестах
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// Функция, возвращающая данные для сортировки из четырех чисел
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> TestDataFour()
        {
            int[] data1 = { 3, 2, 4, 2, 3, 4, 2, 4, 4, 1 }; // Входные данные
            int[] expectedAsc1 = { 1, 2, 2, 2, 3, 3, 4, 4, 4, 4 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc1 = { 4, 4, 4, 4, 3, 3, 2, 2, 2, 1 }; // Ожидаемый результат сортировки по убыванию

            int[] data2 = { 111, 27, -45, 111, 111, -45, 111, -45, 111, 92 }; // Входные данные
            int[] expectedAsc2 = { -45, -45, -45, 27, 92, 111, 111, 111, 111, 111 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc2 = { 111, 111, 111, 111, 111, 92, 27, -45, -45, -45 }; // Ожидаемый результат сортировки по убыванию

            int[] data3 = { 1222, 988, 7812, 12345, 12345, 988, 1222, 1222, 7812, 7812 }; // Входные данные
            int[] expectedAsc3 = { 988, 988, 1222, 1222, 1222, 7812, 7812, 7812, 12345, 12345 }; // Ожидаемый результат сортировки по возрастанию
            int[] expectedDesc3 = { 12345, 12345, 7812, 7812, 7812, 1222, 1222, 1222, 988, 988 }; // Ожидаемый результат сортировки по убыванию
            // Возврат данных для использования в тестах
            yield return new object[] { data1, expectedAsc1, expectedDesc1 };
            yield return new object[] { data2, expectedAsc2, expectedDesc2 };
            yield return new object[] { data3, expectedAsc3, expectedDesc3 };
        }
        /// <summary>
        /// Метод проверки сортировки пузырьком
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void BubbleTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.BubbleSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.BubbleSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки вставками
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void InsertTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.InsertSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.InsertSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки слиянием
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void MergeTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.MergeSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.MergeSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки быстрой сортировки
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void QuickSort(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.QuickSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.QuickSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки черепками
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestData))]
        public void CountTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.CountSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.CountSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки из двух чисел
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataTwo))]
        public void TwoTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.TwoSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.TwoSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки из трех чисел
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataThree))]
        public void ThreeTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.ThreeSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.ThreeSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
        /// <summary>
        /// Метод проверки сортировки из четырех чисел
        /// </summary>
        /// <param name="m"></param>
        /// <param name="expectedAsc"></param>
        /// <param name="expectedDesc"></param>
        [Theory]
        [MemberData(nameof(TestDataFour))]
        public void FourTest(int[] m, int[] expectedAsc, int[] expectedDesc)
        {
            int[] resultAsc = ClassSort.FourSort(m); // Получение результата
            Assert.Equal(expectedAsc, resultAsc); // Сравнение с ожидаемым значением

            int[] resultDesc = ClassSort.FourSort(m, true); // Получение результата
            Assert.Equal(expectedDesc, resultDesc); // Сравнение с ожидаемым значением
        }
    }
}