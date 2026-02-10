namespace ThreeSumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos de prueba 
            int[] arr = {-1,  0, 1, 2, -1, -4};
            int delta = 0; 

            IThreeSum solver = new ThreeSum(); 
            IList<IList<int>> result = solver.GetTriples(arr, delta); 

            Console.WriteLine("Tripletas encontradas: ");
            foreach(var triplet in result)
            {
                Console.WriteLine(string.Join(", ", triplet)); 
            } 
        }
    }
}