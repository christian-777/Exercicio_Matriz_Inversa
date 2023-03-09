internal class Program
{
    private static void Main(string[] args)
    {
        Random n= new Random();
        int[,] mat = new int[3, 3];
        int[,] invertida = new int[3, 3];

        for (int l = 0; l < mat.GetLength(0); l++)
        {
            for (int c = 0; c < mat.GetLength(0); c++)
            {
                mat[l, c] = n.Next(100);
            }
        }


        for (int l = 0; l < mat.GetLength(0); l++)
        {
            for (int c = 0; c < mat.GetLength(0); c++)
            {
                Console.Write(mat[l, c] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        inverter(mat);



        for (int l = 0; l < invertida.GetLength(0); l++)
        {
            for (int c = 0; c < invertida.GetLength(0); c++)
            {
                Console.Write(invertida[l,c]+" ");
            }
            Console.WriteLine();
        }


        void inverter(int[,] mat)
        {

            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    invertida[l, c] = mat[(mat.GetLength(0)-1)-l, (mat.GetLength(0) - 1) - c];
                }
            }

        }

    }
}