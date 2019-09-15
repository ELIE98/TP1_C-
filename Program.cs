using System;
using System.Collections.Generic;
using System.IO;


namespace EXOCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //lire fichier et retourner le nombre de mot

            // exercice 10 et 11
            var path = @"C:\Users\ELIE\Desktop\EXOCsharp\fichier.txt";
            var count = 0;
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);

                foreach (var item in line.Trim())
                {
                     count++;
                }
               
                
            }
           
           System.Console.WriteLine(" nombre de mot = " + count);
           file.Close();
          

         
            
        }
    }
}
