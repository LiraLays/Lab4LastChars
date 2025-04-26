using System;
using System.Linq;

namespace ClassLibrarySort
{
    public class ClassSort
    {
        /// <summary>
        /// Смена значений местами
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="left">первый индекс для смены значений в массиве</param>
        /// <param name="right">второй индекс для смены значений в массиве</param>
        private static void Swap(char[] MAS, int left, int right)
        {
            char temp = MAS[left];
            MAS[left] = MAS[right];
            MAS[right] = temp;
        }

        /// <summary>
        /// Сортировка методом Пузырька
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] BubbleSort(char[] MAS, bool vect = false)
        {
            for (int i = 0; i < MAS.Length; i++)
                for (int j = 0; j < MAS.Length - i - 1; j++)
                    if (MAS[j].CompareTo(MAS[j + 1]) > 0)
                        Swap(MAS, j, j + 1);

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] InsertSort(char[] MAS, bool vect = false)
        {
            for (int i = 1; i < MAS.Length; i++)
            {
                char key = MAS[i];
                int check = 0;
                for (int j = i - 1; j >= 0 && check == 0;)
                    if (key.CompareTo(MAS[j]) < 0)
                    {
                        MAS[j + 1] = MAS[j];
                        MAS[j] = key;
                        j--;
                    }
                    else
                        check++;

            }

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Рекурсивная сортировка слиянием
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="low">начальный индекс</param>
        /// <param name="high">конечный индекс</param>
        /// <param name="vect">направление сортировки (true - по убыванию, false - по возрастанию)</param>
        private static void Merge_Range(char[] MAS, int low, int high)
        {
            if (high - low > 1)
            {
                int left = low, l_mid = (low + high) / 2, r_mid = (low + high) / 2 + 1, right = high;

                Merge_Range(MAS, left, l_mid);
                Merge_Range(MAS, r_mid, right);

                char[] temp_MAS = new char[high - low + 1];

                for (int i = low; i <= high; i++)
                    temp_MAS[i - low] = MAS[i];

                int k = left, j = r_mid;

                for (int i = low; i <= high; i++)
                    if (k <= l_mid && j <= right)
                    {
                        if (temp_MAS[k - low].CompareTo(temp_MAS[j - low]) < 0)
                            MAS[i] = temp_MAS[k++ - low];
                        else
                            MAS[i] = temp_MAS[j++ - low];
                    }
                    else if (k > l_mid)
                        MAS[i] = temp_MAS[j++ - low];
                    else
                        MAS[i] = temp_MAS[k++ - low];
            }

            else if (high - low == 1)
                if (MAS[low].CompareTo(MAS[high]) > 0)
                    Swap(MAS, low, high);
        }

        /// <summary>
        /// сортировка слиянием
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>остортированный массив</returns>
        public static char[] MergeSort(char[] MAS, bool vect = false)
        {
            Merge_Range(MAS, 0, MAS.Length - 1);

            if (vect)
                Array.Reverse(MAS);
            return MAS;
        }

        /// <summary>
        /// Рекурсивная быстрая сортирока
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="low">левая граница</param>
        /// <param name="high">правая граница</param>
        /// <param name="vect">направление сортировки (false - по возрастанию, true - по убыванию)</param>
        private static void Quick_Range(char[] MAS, int low, int high)
        {
            int left = low, right = high;
            char middle = MAS[(left + right) / 2];

            while (MAS[left].CompareTo(middle) < 0)
                left++;

            while (MAS[right].CompareTo(middle) > 0)
                right--;

            if (left <= right)
            {
                Swap(MAS, left, right);
                left++;
                right--;
            }

            if (low < right)
                Quick_Range(MAS, low, right);
            if (left < high)
                Quick_Range(MAS, left, high);

        }

        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>остортированный массив</returns>
        public static char[] QuickSort(char[] MAS, bool vect = false)
        {
            Quick_Range(MAS, 0, MAS.Length - 1);

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] CountSort(char[] MAS, bool vect = false)
        {
            char maxi = MAS.Max(), mini = MAS.Min();
            int len = Math.Max(Math.Abs(mini), Math.Abs(maxi));
            char[] polnmas = new char[2 * len + 1];
            int j;

            for (int i = 0; i < MAS.Length; i++)
                polnmas[MAS[i] + len]++;

            j = 0;

            for (int i = mini; i <= maxi; i++)
                for (char k = '0'; k < polnmas[i + len]; k++)
                {
                    MAS[j] = (char) i;
                    j++;
                }

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Сортировка элементов двух типов
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] TwoSort(char[] MAS, bool vect = false)
        {
            int left = 0, right = MAS.Length - 1;

            while (left < right)
            {
                while (left < right && MAS[left].CompareTo(MAS.Min()) == 0)
                    left++;

                while (left < right && MAS[right].CompareTo(MAS.Max()) == 0)
                    right--;

                Swap(MAS, left, right);
            }

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Сортировка элементов трёх типов
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] ThreeSort(char[] MAS, bool vect = false)
        {
            char[] uni = BubbleSort(MAS.ToList().Distinct().ToArray());
            int[] IntUni = uni.Select(x => (int) x).ToArray();
            int low = uni.Min(), high = uni.Max(), middle = Math.Abs(IntUni.Sum() - low - high);

            int left = 0;
            int mid = 0;
            int right = MAS.Length - 1;

            while (mid <= right)
            {
                if (MAS[mid].CompareTo(middle) == 0)
                    mid++;

                else if (MAS[mid].CompareTo(high) == 0)
                {
                    Swap(MAS, mid, right);
                    right--;
                }

                else
                {
                    Swap(MAS, left, mid);
                    left++;
                    mid++;
                }
            }

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }

        /// <summary>
        /// Сортировка элементов четырех типов
        /// </summary>
        /// <param name="MAS">целочисленный массив</param>
        /// <param name="vect">направление сортировки (true - по убыванию, ничего - по возрастанию)</param>
        /// <returns>отсортированный массив</returns>
        public static char[] FourSort(char[] MAS, bool vect = false)
        {
            char[] uni = BubbleSort(MAS.ToList().Distinct().ToArray());
            char low, mid1, mid2, high;

            switch (uni.Length)
            {
                case 1:
                    return MAS;
                case 2:
                    return TwoSort(MAS, vect);
                case 3:
                    return ThreeSort(MAS, vect);
            }

            low = uni[0];
            mid1 = uni[1];
            mid2 = uni[2];
            high = uni[3];

            int left = 0;
            int left_mid = 0;
            int right_mid = MAS.Length - 1;
            int right = MAS.Length - 1;
            int cur = 0;

            while (cur <= right_mid)
            {
                if (MAS[cur].CompareTo(low) == 0)
                {
                    Swap(MAS, cur, left);

                    if (left < left_mid)
                        Swap(MAS, cur, left_mid);

                    left++;
                    left_mid++;
                    cur++;
                }

                else if (MAS[cur].CompareTo(mid1) == 0)
                {
                    Swap(MAS, cur, left_mid);
                    left_mid++;
                    cur++;
                }

                else if (MAS[cur].CompareTo(mid2) == 0)
                    cur++;

                else if (MAS[cur].CompareTo(high) == 0)
                {
                    Swap(MAS, cur, right_mid);

                    if (MAS[right_mid].CompareTo(mid2) == 0)
                        right_mid--;

                    Swap(MAS, right_mid, right);
                    right--;
                    right_mid--;
                }
            }

            if (vect)
                Array.Reverse(MAS);

            return MAS;
        }
    }
}
