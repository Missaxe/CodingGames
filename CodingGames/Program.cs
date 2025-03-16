using System.Net.WebSockets;

namespace CodingGames
{
    internal class Program
    {
       //class Shape { }
        //class Square : Shape { }
        //class Circle :Shape { }
        struct Struct
        {
            public int foo;
        }
        static  void Main(string[] args)
        {

            //string[] fruits = { "apple", "orange", "apricot", "kiwi" };

            //var list = new List<string>(fruits);

            //IEnumerable<string> query = list.Where(c => c.Length == 4);


            var kk = DrawHours.DrawHourglass("Maissa");
            Console.WriteLine(kk);  


            //list.Remove("kiwi");
            //Console.WriteLine(query.Count());
            //var res = TranslateClass.Translate("hello, sectret meeting tonight.");

            //List<int> list = new List<int> { 25,225,25,2};
            //var resss = SearchValueClass.SearchValue(list,25);
            ////List<int> nums = new List<int>() { 33,4,56,8,9};
            ////var res = IsOnEvenPositionClass.IsOnEvenPosition(nums,8);
            //var res = ComputeMultipleSumClass.ComputeMultipleSum(12);
            //Console.WriteLine(res);
            //Struct struct1;
            //struct1.foo = 5;

            //Struct struct2 = struct1;
            //struct2.foo = 10;

            //Console.WriteLine(struct1.foo);
            //Console.WriteLine(struct2.foo);
            //Console.WriteLine("MEOOW");



            //var stream = File.Create("filename.txt");
            //try
            //{

            //}
            //finally
            //{
            //    if(stream != null) 
            //        await stream.DisposeAsync();
            //}
            //var stream = File.Create("filename.txt");
            //try
            //{

            //}
            //finally
            //{
            //    if (stream != null)
            //        await stream.Dispose();
            //}
            //using(var stream = File.Create("filename.txt"))
            //{

            //}
            //// Manually create the nodes
            //Node root = new Node { value = 9 };

            //// Manually set left and right values
            //root.left = new Node { value = 3 };
            //root.right = new Node { value = 12 };

            //root.left.right = new Node { value = 7 };

            //root.right.left = new Node { value = 10 };
            //root.right.right = new Node { value = 15 };

            //// Create a Test object and pass the root node
            //Test test = new Test(root);

            //// Test the Find function with various values
            //Node? foundNode = test.Find(9);  // Search for the root node
            //test.PrintNode(foundNode);

            //foundNode = test.Find(7);  // Search for a value in the left subtree
            //test.PrintNode(foundNode);

            //foundNode = test.Find(12); // Search for a value in the right subtree
            //test.PrintNode(foundNode);

            //foundNode = test.Find(5);  // Search for a value that does not exist
            //test.PrintNode(foundNode);

            //Point[] pt = new Point[]
            //{
            //    new Point () { x=0.5,y=0.5},
            //    new Point () { x=0.25,y=0.25},
            //    new Point () { x=1,y=1}
            //};
            //var mm = PIIII.Approx(pt);
            //string[] fruits = { "apple", "orange", "apricot", "kiwi" };

            //var list = new List<string>(fruits);

            //IEnumerable<string> query = list.Where(c => c.Length == 4);



            //list.Remove("kiwi");
            //Console.WriteLine(query.Count());
            //Console.WriteLine("HEEEY");
            //Shape shape = new Square();
            //Circle circle = shape as Circle;
            //var d = new DateTime(0);
            //var kk = d.AddHours(2);
            //Console.WriteLine(kk.Hour);
            //var sd = new SortedDictionary<int, int>();
            //sd[3] = 3;
            //sd[2] = 1;
            //sd[1] = 2;
            //foreach (var item in sd)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //var m = new Dictionary<object, int>();
            //var o1 = new object();
            //var o2 = o1;
            //m[o1] = 1;
            //m[o2] = 2;
            //Console.WriteLine(m[o1]);
            //Console.WriteLine(m[o2]);

            int[] word = new int[] { -9,-1,3,-5,7 };
            //string leters = "ae";
            //var ress = ClozestTo0.ClozestToZero(word);
            //string[] word = new string[]{ "the","dog","got","a","bone"};
            //string leters = "ae";
            //var res = FilterWordss.FilterWords(word, leters);

            //string[] wins = new string[6] 
            //{ "AMZN", "CACC", "EQIX", "GOOG", "ORLY", "ULTA" };
            //float[,] va = new float[,] {
            //    {13.81F,11.09F,12.11F,10.93F,14.83F,16.14F },
            //    {13.34F,10.56F,10.14F,12.17F,14.13F,16.15F } };
            //string[] wins = new string[] { "AMZN", "CACC", "EQIX" };
            //float[,] va = new float[,] {
            //    {13.81F,11.09F,12.11F},
            //    {13.34F,10.56F,10.14F } };

            ////var res = TopStocks.GetTopStocks(wins, va);
            //Console.WriteLine(res);

            //Console.WriteLine("Hello, World!");

        }
    }
}
