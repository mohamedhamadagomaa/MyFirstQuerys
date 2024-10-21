namespace LinQ.CADelegate
{
    internal class Program
    {
        delegate void MDelegate();

        static void Main(string[] args)
        {
            M2(M1);
            //Console.WriteLine("Hello, World");
        }
        static void M1()
        {
            Console.WriteLine("Hello I'm Method M1");
        }
        static void M2(MDelegate mDel)
        {
            mDel();

            Console.WriteLine("M2");
        }

    }
}