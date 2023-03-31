namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first file");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second file");
            string b = Console.ReadLine();
            diff(a,b);
        }

        private static void diff(string aname, string bname)
        {
            try
            {
                StreamReader sra = new(aname);
                StreamReader srb = new(bname);
                string a = "";
                string b = "";
                int line = 0;
                while ((!sra.EndOfStream) && (!srb.EndOfStream))
                {
                    line++;
                    a = sra.ReadLine();
                    b = srb.ReadLine();

                    if (!a.Equals(b))
                    {
                        Console.WriteLine("Line " + line);
                        Console.WriteLine("< " + a);
                        Console.WriteLine("> " + b);
                    }
                }
                if ((sra.EndOfStream && !srb.EndOfStream) || ((!sra.EndOfStream && srb.EndOfStream)))
                {
                    Console.WriteLine("Files have different number of lines");
                }
            }
            catch (IOException ex) { Console.WriteLine(ex.Message); }
        }
    }
}