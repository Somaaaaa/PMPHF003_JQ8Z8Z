using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF003_JQ8Z8Z
{
    internal class PMPHF003_JQ8Z8Z
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //deklarálás
            int[,] tomb = new int[n, n];
            int[] elemek = new int[n+n+2];
            int index = 0;
            int azonos = 0;
            for (int i = 0; i < n; i++) // feltöltés
            {
                for (int j = 0; j < n; j++)
                {
                    tomb[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int temp = 0;
            for (int i = 0; i < n; i++) // sor
            {
                for (int j = 0; j < n; j++)
                {
                    temp += tomb[i, j];
                }
                Console.Write(temp + ",");
                elemek[index] = temp;
                index++;
                temp = 0;
            }
            for (int i = 0; i < n; i++) // oszlop
            {
                for (int j = 0; j < n; j++)
                {
                    temp += tomb[j, i];
                }
                Console.Write(temp + ",");
                elemek[index] = temp;
                index++;
                temp = 0;
            }
            for (int i = 0; i < n; i++) // bal átló
            {
                temp += tomb[i, i];
            }
            Console.Write(temp + ",");
            elemek[index] = temp;
            index++;
            temp = 0;
            for (int i = n - 1; i >= 0; i--) // jobb átló
            {
                temp += tomb[n - i - 1, i];
            }
            Console.Write(temp + ",");
            elemek[index] = temp;
            for (int i = 1; i < n; i++) // kiértékelés
            {
                if (elemek[i] == elemek[i - 1]) azonos++;
            }
            if (azonos == n - 1) Console.Write("Y");
            else Console.Write("N");
            Console.ReadLine();
        }
    }
}
