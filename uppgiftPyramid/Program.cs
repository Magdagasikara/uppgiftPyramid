using System.Xml;

namespace uppgiftPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // askthe user for a umber
            Console.Write("Hej, ange en siffra: ");
            int chosenNumber = int.Parse(Console.ReadLine());

            // initlialize the first row, including the emptySpace needed to center the numbers
            // size of the empty space will decrease with each iteration
            string emptySpace = "";
            string spaceOrNot = "";
            string x1 = "";
            string x2 = "";
            string x3 = "";
            string x4 = "";

            // initialize the iterator
            int i =1;

            do
            {
                //emptySpace is smaller n smaller with each iteration
                emptySpace = String.Format("{0," + (chosenNumber - i + 1 )+ "}", " ");

                // values of each "pyramide" of this iteration
                if (i != 1)
                {
                    spaceOrNot = " ";
                        }
                    x1 = emptySpace + x1.Trim() + spaceOrNot + i.ToString() + emptySpace;
                    x2 = emptySpace + x2.Trim() + spaceOrNot + chosenNumber.ToString() + emptySpace;
                    x3 = emptySpace + x3.Trim().Replace((i - 1).ToString(), i.ToString()) + spaceOrNot + i.ToString() + emptySpace;
                    x4 = emptySpace + i.ToString() + spaceOrNot + x4.Trim() + emptySpace;
                

                // we print out the iteration we enter
                Console.WriteLine($"{x1}\t{x2}\t{x3}\t{x4}");

                // iterate
                i++;


            } while (i <= chosenNumber);

        }
    }
}