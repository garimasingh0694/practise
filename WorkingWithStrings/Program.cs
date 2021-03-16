using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "what if i need a\nnew line?";
            // string myString = @"Go to your c:\ drive"; 
            //string myString = string.Format("{0} = {1}", "first", "second");
            //string myString = string.Format("{0:c}", 123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            //string myString = "  That summer we took threes across the board   ";
            // myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            /*
            myString = String.Format("Length before: {0} -- Length after:{1}",
               myString.Length,
               myString.Trim().Length);
            */
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }*/
            StringBuilder mystring = new StringBuilder();

              for (int i = 0; i < 100; i++)
            {
                
                mystring.Append("--");
                mystring.Append(i);
            }


            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
