using System;
using System.Diagnostics;

namespace ListAndDictionaryExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Exercise 1:
            Console.WriteLine("Input your list of integers: ");
            string input = Console.ReadLine();
            string[] splitList = input.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in splitList)
            {
                intList.Add(int.Parse(item));
            }

            foreach (int item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Exercise 2:
            intList.Sort();
            Console.WriteLine("The largest integer is " + intList[intList.Count - 1]);
            Console.WriteLine("The smallest integer is " + intList[0]);

            // Exercise 3:
            Console.Write("Input your integer to be removed: ");
            Int32.TryParse(Console.ReadLine(), out int removedInt);
            intList.Remove(removedInt);

            // Exercise 4:
            intList.Sort();
            intList.Reverse();

            // Exercise 5:
            Console.WriteLine("Input your paragraph: ");
            string paragraph = Console.ReadLine();
            string[] words = paragraph.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            // Exercise 6:
            PhoneNumberList phoneNumbers = new PhoneNumberList();

            // Exercise 7:
            StudentList studentList = new StudentList();

            // Exercise 8:
            ProductList productList = new ProductList();
        }

        public void DoExercise1()
        {
            Console.WriteLine("Input your list of integers: ");
            string input = Console.ReadLine();
            string[] splitList = input.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in splitList)
            {
                intList.Add(int.Parse(item));
            }

            foreach (int item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void DoExercise2()
        {
            Console.WriteLine("Input your list of integers: ");
            string input = Console.ReadLine();
            string[] splitList = input.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in splitList)
            {
                intList.Add(int.Parse(item));
            }

            intList.Sort();
            Console.WriteLine("The largest integer is " + intList[intList.Count - 1]);
            Console.WriteLine("The smallest integer is " + intList[0]);
        }

        public void DoExercise3()
        {
            Console.WriteLine("Input your list of integers: ");
            string input = Console.ReadLine();
            string[] splitList = input.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in splitList)
            {
                intList.Add(int.Parse(item));
            }

            Console.Write("Input your integer to be removed: ");
            Int32.TryParse(Console.ReadLine(), out int removedInt);
            intList.Remove(removedInt);
        }

        public void DoExercise4()
        {
            Console.WriteLine("Input your list of integers: ");
            string input = Console.ReadLine();
            string[] splitList = input.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in splitList)
            {
                intList.Add(int.Parse(item));
            }
            intList.Sort();
            intList.Reverse();
        }

        public void DoExercise5()
        {
            Console.WriteLine("Input your paragraph: ");
            string paragraph = Console.ReadLine();
            string[] words = paragraph.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }
        }
    }

    public class PhoneNumberList
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public PhoneNumberList() { }

        public void Add(string name, string number)
        {
            if (dictionary.ContainsKey(name))
                dictionary[name] = number;
            else
                dictionary.Add(name, number);
        }

        public void PrintDictionary()
        {
            foreach (string name in dictionary.Keys)
            {
                Console.WriteLine(name + ": " + dictionary[name]);
            }
        }

        public string Search(string name)
        {
            return dictionary[name];
        }
    }

    public class StudentList
    {
        private Dictionary<string, double> dictionary = new Dictionary<string, double>();
        private List<string> names;
        private List<double> grades;

        public StudentList() { }

        public void Add(string name, double grade)
        {
            if (dictionary.ContainsKey(name))
                dictionary[name] = grade;
            else 
                dictionary.Add(name, grade);
        }

        public void Sort()
        {
            names = new List<string>();
            grades = new List<double>();

            foreach (string name in dictionary.Keys)
            {
                // put each pair into lists
                names.Add(name);
                grades.Add(dictionary[name]);

                // Continue to move the grade and the corresponding name to the left untill there is no smaller grade
                for (int i = grades.Count - 1; i > 0; i--)
                {
                    if (grades[i] > grades[i - 1])
                    {
                        // Switch positions
                        double tempGrade = grades[i];
                        grades[i] = grades[i - 1];
                        grades[i - 1] = tempGrade;

                        string tempName = names[i];
                        names[i] = names[i - 1];
                        names[i - 1] = tempName;
                    } else 
                        break;
                }
            }

            List<string> pairs = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                pairs.Add(names[i] + ": " + grades[i]);
            }

            foreach (string pair in pairs)
            {
                Console.WriteLine(pair);
            }
        }
    }

    public class ProductList
    {
        private Dictionary<string, int> dictionary = new Dictionary<string, int>();

        public ProductList() { }

        public void Add(string name, int price)
        {
            if (dictionary.ContainsKey(name))
                dictionary[name] = price;
            else
                dictionary.Add(name, price);
        }

        public string FindMostExpensive()
        {
            List<int> priceList = new List<int>();
            foreach (string name in dictionary.Keys)
                priceList.Add(dictionary[name]);
            priceList.Sort();
            return "";
        }
    }
}