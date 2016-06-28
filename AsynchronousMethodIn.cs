namespace Application
{
  public class Program
    {
        public delegate int MyDelegate();
        public static void Main()
        {
            MyDelegate dele = () => Directory.GetFiles(@"X:\JD_DATA\main\engine\Tools\actoreditor", "*", SearchOption.AllDirectories).Length;

            dele.BeginInvoke(ar =>
            {
                var result = ((MyDelegate) ((AsyncResult) ar).AsyncDelegate).EndInvoke(ar);
                Console.WriteLine($"this is dope, found {result} files");
                Console.WriteLine(ar.AsyncState);
            },"This is the end of the world");

            Console.WriteLine("Abe Hutiya hai kya");
            Thread.Sleep(40000);
        }
    }
}
