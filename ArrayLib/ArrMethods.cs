using System;

namespace ArrayLib
{
    public class ArrMethods
    {
        // Push Method
        public static T[] Push<T>(T[] arr, T item)
        {
            T[] newArray = new T[arr.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == newArray.Length - 1)
                {
                    newArray[i] = item;
                }
                else
                {
                    newArray[i] = arr[i];
                }

            }
            return newArray;
        }

        // Pop Method
        public static T[] Pop<T>(T[] arr)
        {
            T[] newArray = new T[arr.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }

            return newArray;
        }

        // Shift Method
        public static T[] Shift<T>(T[] arr)
        {
            T[] newArray = new T[arr.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[i + 1];
            }

            return newArray;
        }

        // Unshift Method
        public static T[] Unshift<T>(T[] arr, T item)
        {
            T[] newArray = new T[arr.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == 0)
                {
                    newArray[i] = item;
                }
                else
                {
                    newArray[i] = arr[i - 1];
                }
            }

            return newArray;
        }

        // IndexOf Method
        public static int IndexOf<T>(T[] arr, T item)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == item.ToString())
                {
                    index = i;
                }
            }

            return index;
        }


        // Fill Method
        public static T[] Fill<T>(T[] arr, T value, int start = 0, int finish = 0)
        {

            T[] newArray = arr;

            if (start == 0 && finish == 0)
            {
                finish = arr.Length;
            }

            for (int i = start; i <= finish; i++)
            {
                newArray[i] = value;
            }

            return newArray;
        }

        //Concat Method
        public static T[] Concat<T>(T[] arr1, T[] arr2)
        {
            T[] newArray = new T[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {

                newArray[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                newArray[arr1.Length + i] = arr2[i];
            }
            return newArray;
        }

        //ToString Method
        public static string ToString<T>(T[] arr)
        {
            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i].ToString() + ',';
            }
            return result;
        }

        //Includes Method
        public static bool Includes<T>(T[] arr, T item)
        {
            bool res = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == item.ToString())
                {
                    res = true;
                }
            }

            return res;
        }
    }
}
