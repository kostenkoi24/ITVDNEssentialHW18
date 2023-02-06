using System;


namespace Homework18_1
{
    using Homework14_3;
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary myDictionary = new MyDictionary();


            myDictionary.Add("Akey", "Avalue");
            myDictionary.Add("Bkey", "Bvalue");


            Console.WriteLine(myDictionary.Length);

            Console.WriteLine(myDictionary[0]);
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary[3]); //return default


            foreach (string element in myDictionary)
            {
                Console.WriteLine($"Name:{element}");
            }


            Console.ReadKey();
        }
    }
}





namespace Homework14_3
{


    class MyDictionary //: IEnumerable //, IEnumerator
    {
        string[] dictionaryKeys;
        string[] dictionaryValues;
        int length;


        public MyDictionary()
        {
            dictionaryKeys = null;
            dictionaryValues = null;
        }


        public int Length { get => length; }



        public void Add(string key, string value)
        {

            if (dictionaryKeys == null)
            {
                dictionaryKeys = new string[1];
                dictionaryValues = new string[dictionaryKeys.Length];
            }
            else
            {
                length = dictionaryKeys.Length;
                Array.Resize<string>(ref dictionaryKeys, length + 1);
                Array.Resize<string>(ref dictionaryValues, length + 1);
            }


            dictionaryKeys[length] = key;
            dictionaryValues[length] = value;
        }

        public string this[int index]
        {
            get
            {
                if (index < dictionaryValues.Length)
                {
                    return dictionaryValues[index];
                }
                else
                {
                    return default;
                }

            }
        }

        int position = -1;

        public bool MoveNext()
        {
            if (position < dictionaryKeys.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public string /*object*/ Current
        {
            get { return dictionaryValues[position]; }
        }

        //public IEnumerator GetEnumerator()
        public MyDictionary GetEnumerator()
        {
            return this;
        }

    }
}