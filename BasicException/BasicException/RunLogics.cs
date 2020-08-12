using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace BasicException
{
    public class RunLogics
    {
        private Logic.Logic Logics;
        private int StudentNum;
        public RunLogics()
        {
            Console.WriteLine("Enter Student Number");
            StudentNum = int.Parse(Console.ReadLine());
            Logics = new Logic.Logic();
        }
        public void TryReadIntParser(out int data)
        {
            while (!int.TryParse(Console.ReadLine(), out data))
            {
                throw new ScubaException(String.Format("Enter Valid int"), StudentNum);
            }
        }
        public void RunLogic1()
        {
            int arrayLength;
            int[] arr;
            Console.WriteLine("Enter array Length please:");
            try
            {
                TryReadIntParser(out arrayLength);
                arr = new int[arrayLength];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter Array numbers");
                    try
                    {
                        TryReadIntParser(out arr[i]);
                    }
                    catch (ScubaException e)
                    {
                        Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
                    }
                }
                Console.WriteLine("The result of Logic1 is: " + Logics.Logic1(arr));
            }
            catch(ScubaException e)
            {
                Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
            }


        }
        public void TryReadStringParser(out string data)
        {
            while (string.IsNullOrEmpty(data = Console.ReadLine())) { throw new ScubaException(String.Format("Enter Valid file name"), StudentNum); }

        }

        public void RunLogic2()
        {
            string inFileName, outFileName;
            try
            {
                Console.WriteLine("enter input file name");
                TryReadStringParser(out inFileName);
                Console.WriteLine("enter output file name");
                TryReadStringParser(out outFileName);
                try
                {
                    Logics.Logic2(inFileName, outFileName);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
            catch(ScubaException e)
            {
                Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
            }
        }
        public void RunLogic3()
    {
        string data;
            try
            {
                TryReadStringParser(out data);
                try
                {
                    Logics.Logic3(data);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
            catch (ScubaException e)
            {
                Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
            }
           
    }

    public void RunLogic4()
    {
        string data1;
        int data2;
        long data3;
            try
            {
                Console.WriteLine("Enter 1 string : ");
                TryReadStringParser(out data1);
                try
                {
                    Console.WriteLine("Enter int number");
                    TryReadIntParser(out data2);
                    while (!long.TryParse(Console.ReadLine(), out data3))
                    {
                        throw new ScubaException(String.Format("Enter Valid long"), StudentNum);
                    }
                    try
                    {
                        Logics.Logic4(data1, data2, data3);
                    }
                    catch (ScubaException se)
                    {
                        Console.WriteLine(se.Message.ToString() + se.StudentNum);
                        throw;
                    }
                }
                catch (ScubaException e)
                {
                    Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
                }
                Console.WriteLine("Enter 1 Long number: ");

            }
            catch (ScubaException e)
            {
                Console.WriteLine(String.Format("Hey {0}, You have an exception as ScubaException : {1}", e.StudentNum, e.Message));
            }

    }
    public void RunLogic5()
    {
        string dllfile;
        Console.WriteLine("Enter dll file : ");
                while (string.IsNullOrEmpty(dllfile = Console.ReadLine())) { throw new ScubaException(String.Format("Enter Valid string"), StudentNum); }
        try
        {
            Logics.Logic5(dllfile);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Assembly file not found" + e.Message.ToString());
            throw;
        }
        catch (FileLoadException e)
        {
            Console.WriteLine("Couldnt Load the file" + e.Message.ToString());
            throw;
        }
    }

}
}
