namespace GarbageCollectorDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[5000];
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
        }
    }
}