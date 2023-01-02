namespace DataStructureAlgorithm
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastrucure Algorithm");
            LinkedList<string> list = new LinkedList<string>();
            string text =  "A Positive mindset brings positive thinks";
            string[] textlist = text.Split(" ");
            foreach(var data in textlist)
            {
                list.Add(data);
                list.Search(data);
                //list.RemoveFirstNode();

            }
            list.Display();

            
        }
    }
}
