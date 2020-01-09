using System;

namespace YourName
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {2,5,65,3};
            Console.Write(pal("kasur rusak"));
            
        }

        static int indexOf(int[] arr, int data)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] == data)
                    return i;
            }

            return 999;
        }

        static int lastIndex(int[] arr)
        {
            int ln = arr.Length;
            return arr[ln-1];
        }

        static bool includes(int[] arr, int data)
        {
            foreach (var x in arr)
            {
                if(data == x)
                    return true;
            }

            return false;
        }

        static int[] fill(int[] arr, int data)
        {
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = data;
            }

            return arr;
        }
        
        static string join(int[] arr, char ch)
        {
            string ret = "";
            int ln = arr.Length;

            for(int i=0; i<ln; i++)
            {
                if(i < ln-1)
                    ret += arr[i].ToString() + ch;
                
                else
                    ret += arr[i].ToString();
            }

            return ret;
        }
        
        static int sum(int[] arr)
        {
            int ret = 0;
            foreach(var x in arr)
                ret += x;

            return ret;
        }

        static int rec(int data)
        {
            if(data ==1)
                return data;

            return data*rec(data-1);
        }

        static string strReverse(string str)
        {
            int ln = str.Length;
            char[] ret = new char[ln];
            for(int i=0; i<ln; i++)
                ret[i] = str[ln-1-i];

            return new string(ret);
        }

        static int[] splice(int[] arr, int index, int data)
        {
            int ln = arr.Length;
            int[] ret = new int[ln+1];
            for(int i=0; i<=ln; i++)
            {   
                if(i < index)
                    ret[i] = arr[i];
                
                else if (i > index)
                {
                    ret[i] = arr[i-1];
                }

                else 
                    ret[index] = data;
            }

            return ret;
        }

        static int[] reverse(int[] arr)
        {
            int ln = arr.Length;
            for(int i=0; i<ln/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[ln-1-i];
                arr[ln-1-i] = temp;
            }

            return arr;
        }

        static int[] bubble(int[] arr)
        {
            int ln = arr.Length;

            for(int i=0; i<ln; i++)
            {
                for(int j=0; j<ln-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            return arr;
        }
    
        static void search()
        {

        }

        static string elimSymbol(string str){
            int ln = str.Length;
            string ret = "";
            foreach (var c in str)
            {
                if(97 <= Convert.ToInt32(c) && Convert.ToInt32(c) <= 122 || 65 <= Convert.ToInt32(c) && Convert.ToInt32(c) <= 90)
                    ret += c;
            }

            return ret;
        }

        static bool pal(string str)
        {
            string strOnl
            int ln = str.Length;
            for(int i=0; i<ln/2; i++)
            {
                if(str[i] != str[ln-1-i])
                    return false;
            }

            return true;
        }
    
        static void FizzBuzz(int num)
        {
            for(int i=1; i<=num; i++)
            {
                if(i%2 == 0 && i%3 == 0)
                    Console.WriteLine("Fizz Buzz");

                else if(i%2 == 0)
                    Console.WriteLine("Fizz");

                else if(i%3 == 0)
                    Console.WriteLine("Buzz");

                else 
                    Console.WriteLine(i);
            }
        }
    
        static char maxChar(string str)
        {
            int ln = str.Length;
            int temp = 0;
            int ret = 0;

            for(int i=0; i<ln; i++)
            {
                if(temp < charCounter(str, str[i]))
                {
                    temp = charCounter(str, str[i]);
                    ret = i;
                }
            }

            return str[ret];
        }

        static int charCounter(string str, char ch)
        {
            int ret = 0;
            foreach (var c in str)
            {
                if(c == ch)
                    ret += 1;
            }

            return ret;
        }

        static bool anagram(string a, string b)
        {

            if(a.Length == b.Length)
            {
                for(int i=0; i<a.Length; i++)
                {
                    if(charCounter(a, a[i]) != charCounter(b, a[i]))
                        return false;
                }

                return true;
            }

            else
                return false;
        }
    
        static string toUpper(string str)
        {
            int ln = str.Length;
            string ret = "";
            for(int i=0; i<ln; i++)
            {
                char temp = str[i];
                if(97 <= Convert.ToInt32(str[i]) && Convert.ToInt32(str[i]) <= 122)
                    temp = Convert.ToChar(Convert.ToInt32(temp) - 32);

                ret += temp;
            }

            return ret;
        }

        static string caesarChipper(string str, int shift)
        {
            int ln = str.Length;
            string ret = "";
            for(int i=0; i<ln; i++)
            {
                char temp = str[i];
                if(97 <= Convert.ToInt32(str[i]) && Convert.ToInt32(str[i]) <= 122 || 65 <= Convert.ToInt32(str[i]) && Convert.ToInt32(str[i]) <= 90)
                    temp = Convert.ToChar(Convert.ToInt32(temp) + shift);

                ret += temp;
            }

            return ret;
        }
    
        static int[] insertionSort(int[] arr)
        {
            int ln = arr.Length;
            for(int i=0; i<ln; i++)
            {
                for(int j=i; j<ln-1; j++)
                {
                    if(arr[j+1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            return arr;
        }
    
        static int[] selectionSort(int[] arr) 
        { 
            int ln = arr.Length; 
            for (int i=0; i<ln-1; i++) 
            {
                int minIndex= i; 
                for (int j=i+1; j<ln; j++)
                {
                    if (arr[j] < arr[minIndex]) 
                        minIndex = j; 
                }

                int temp = arr[minIndex]; 
                arr[minIndex] = arr[i]; 
                arr[i] = temp; 
            }

            return arr;
        }
    }
}