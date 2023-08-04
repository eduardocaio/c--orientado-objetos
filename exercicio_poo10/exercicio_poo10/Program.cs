namespace exercicio_poo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int M = int.Parse(num[0]);
            int N = int.Parse(num[1]);

            int[,] mat = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int escolha = int.Parse(Console.ReadLine());

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(escolha == mat[i, j])
                    {
                        Console.WriteLine("Position " + i + "," + j + ": ");
                        
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if(i < M - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                    }
                }
            }


            }

        }
    }
