using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul9
{
    class Program
    {
        // To do pt lab:
        //-bipartit cu parcurgere in adancime
        //-* sa verificam daca un graf e tripartit
        public static int[,] matAd;
        private static bool[] visited;
        private static int[] ivisited;

        static void Main(string[] args)
        {
            matAd = load(@"data.in");
            view(matAd);
            Console.WriteLine();
            Console.WriteLine("BFS:");
            BFS(0, matAd.GetLength(0));
            Console.WriteLine();
            Console.WriteLine();
           /* Console.WriteLine("Bipartit:");
            Console.WriteLine(Bipartit(1, matAd.GetLength(0)));
            Console.WriteLine();
            Console.WriteLine();
            ivisited = new int[matAd.GetLength(0)];
            Console.WriteLine("DFS_Bipartit:");
            Console.WriteLine(DFS_Bipartit(1, matAd.GetLength(0), 1));
            Console.WriteLine();
            Console.WriteLine("DFS:");
            visited = new bool[matAd.GetLength(0)];
            DFS(1, matAd.GetLength(0));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tripartit:");
            Console.WriteLine(Tripartit(1, matAd.GetLength(0)));
           */
            Console.ReadKey();
        }

        static int[,] load(string fileName)
        {
            int lines, columns;
            string buffer;
            List<string> data = new List<string>();
            System.IO.TextReader dataLoad = new System.IO.StreamReader(fileName);
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                data.Add(buffer);
            }
            dataLoad.Close();
            lines = data.Count();
            columns = lines;
            int[,] toReturn = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            { 
                for (int j = 0; j < columns; j++)
                {
                    toReturn[i, j] = data[i][j] - 48;
                }
            }
            return toReturn;
        }

        static void view(int[,] toView)
        {
            int lines = toView.GetLength(0);
            int columns = toView.GetLength(1);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(toView[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        static void BFS(int start, int n)
        {
            Queue q = new Queue();
            q.Push(start);
            bool[] visited = new bool[n];
            visited[start] = true;
            while(q.values.Length!=0)
            {
                int nodCurent = q.Pop();
                Console.Write(nodCurent + " ");
                for(int i=0; i<n; i++)
                {
                    if(matAd[nodCurent,i]!=0 && visited[i]==false)
                    {
                        q.Push(i);
                        visited[i] = true;
                    }
                }
            }
        }
        /*
        static void DFS(int nodCurent, int n)
        {
            Console.Write(nodCurent + " ");
            visited[nodCurent] = true;
            for (int i = 0; i < n; i++)
            {
                if (matAd[nodCurent, i] != 0 && visited[i] == false)
                {
                    DFS(i, n);
                }
            }
        }

        static bool DFS_Bipartit(int nodCurent, int n, int value)
        {
            ivisited[nodCurent] = value;
            for (int i = 0; i < n; i++)
            {
                if (matAd[nodCurent, i] != 0)
                {
                    if(ivisited[i] == 0)
					{
                        if(ivisited[nodCurent] == 1)
						{
                            return DFS_Bipartit(i, n, 2);
                        }
						else
						{
                            return DFS_Bipartit(i, n, 1);
                        }
					}
					else
					{
                        if (ivisited[nodCurent] == ivisited[i])
                            return false;
                    }
                }
            }
            return true;
        }

        static bool Bipartit(int start, int n)
        {
            Queue q = new Queue();
            q.Push(start);
            int[] visited = new int[n];
            visited[start] = 1;
            while (q.values.Length != 0)
            {
                int nodCurent = q.Pop();
                for (int i = 0; i < n; i++)
                {
                    if (matAd[nodCurent, i] != 0 )
                    {
                        if(visited[i]==0)
                        { 
                            q.Push(i);
                            if(visited[nodCurent]==1)
                                 visited[i] = 2;
                            else
                                visited[i] = 1;
                        }
                        else
                        {
                            if (visited[nodCurent] == visited[i])
                                return false;
                        }
                    }
                }
            }
            return true;
        }

        static bool Tripartit(int start, int n)
        {
            Queue q = new Queue();
            q.Push(start);
            int[] visited = new int[n];
            visited[start] = 1;
            while (q.values.Length != 0)
            {
                int nodCurent = q.Pop();
                for (int i = 0; i < n; i++)
                {
                    if (matAd[nodCurent, i] != 0)
                    {
                        if (visited[i] == 0)
                        {
                            q.Push(i);
                            if (visited[nodCurent] == 1)
                                visited[i] = 2;
                            else
                                visited[i] = 1;
                        }
                        else
                        {
                            if (visited[nodCurent] == visited[i])
                                if (visited[i] == 3)
                                {
                                    return false;
                                }
								else
								{
                                    visited[i] = 3;
                                }
                        }
                    }
                }
            }
            return true;
        }
        */
    }
}