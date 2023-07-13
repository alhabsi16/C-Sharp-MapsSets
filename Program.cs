namespace C_Sharp_Maps_Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(1);
            set.Add(2);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(set.Contains(1));

            HashSet<int> set1 = new HashSet<int>() {  1, 2, 3, 5, 6 };
            HashSet<int> set2 = new HashSet<int>() { 1, 5, 7, 9, 3 };

            HashSet<int> set3 = set1.Intersect(set2).ToHashSet();
            set1.UnionWith(set2);
           
            foreach (int i in set1)
            {

                Console.WriteLine(i);
            }
            foreach (int i in set3)
            {
                Console.WriteLine(i);
            }
        }
    }
}