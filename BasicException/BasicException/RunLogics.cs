using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicException
{
    public class RunLogics
    {
        private Logic.Logic Logics;
        public RunLogics()
        {

            Logics = new Logic.Logic();
        }
        public void RunLogic1()
        {
            int arrayLength;
            int[] arr;
            Console.WriteLine("Enter array Length please:");
            while (!int.TryParse(Console.ReadLine(), out arrayLength))
            {
                Console.WriteLine("Enter valid Integer only");
            }
            arr = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter Array numbers");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Enter valid Integer only");
                }
            }
            Console.WriteLine("The result of Logic1 is: " + Logics.Logic1(arr));
        }

        public void RunLogic2()
        {
            string inFileName, outFileName;
            Console.WriteLine("Hey!, Whats your student number?");
            Console.WriteLine("enter input file name");
            while (string.IsNullOrEmpty(inFileName = Console.ReadLine())) { throw new ScubaException("Enter Valid file name"); }
            Console.WriteLine("enter output file name");
            while (string.IsNullOrEmpty(outFileName = Console.ReadLine())) { throw new ScubaException("Enter Valid file name"); }
            try
            {
                Logics.Logic2(inFileName, outFileName);
            }
            catch (ScubaException se)
            {
                Console.WriteLine(se.Message.ToString() + se.StudentNum);
                throw;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message.ToString());
                throw;
            }
        }
        public void RunLogic3()
    {
        string data;
        while (string.IsNullOrEmpty(data = Console.ReadLine())) { throw new ScubaException("Enter Valid file name"); }
        try
        {
            Logics.Logic3(data);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message.ToString());
            throw;
        }
        catch (ScubaException se)
        {
            Console.WriteLine(se.Message.ToString() + se.StudentNum);
            throw;
        }
    }

    public void RunLogic4()
    {
        string data1;
        int data2;
        long data3;
        Console.WriteLine("Enter 1 string : ");
        while (string.IsNullOrEmpty(data1 = Console.ReadLine())) { throw new ScubaException("Enter Valid string"); }
        while (!int.TryParse(Console.ReadLine(), out data2))
        {
            throw new ScubaException("Enter Valid int");
        }
        Console.WriteLine("Enter 1 Long number: ");
        while (!long.TryParse(Console.ReadLine(), out data3))
        {
            throw new ScubaException("Enter Valid long");
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
    public void RunLogic5()
    {
        string dllfile;
        Console.WriteLine("Enter dll file : ");
        while (string.IsNullOrEmpty(dllfile = Console.ReadLine())) { throw new ScubaException("Enter Valid string"); }
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
