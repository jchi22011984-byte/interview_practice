

namespace ThreeSumApp
{
    public interface IThreeSum
    {
        IList<IList<int>> GetTriples(int[] arr, int delta); 
    }
    public class ThreeSum : IThreeSum
    {
        public IList<IList<int>> GetTriples(int[] arr, int delta)
        {
            // sort the array 
            Array.Sort(arr);

            // declare a var to hold the results
            IList<IList<int>> triplets = new List<IList<int>>(); 

            for(int i = 0; i < arr.Length - 2; i++)
            {
                // create the anchors 
                int left = i + 1; 
                int right = arr.Length - 1;

                while(left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right]; 
                    if(sum == delta)
                    {
                        triplets.Add(new List<int> { arr[i], arr[left], arr[right] }); 
                        // move pointers and skip dups
                        while (left < right && arr[left] == arr[left + 1]) left++; 
                        while (left < right && arr[right] == arr[right - 1]) right--; 
                        left++; 
                        right--; 
                    } else if(sum < delta)
                    {
                        // move left pointer 
                        left++; 
                    } else
                    {
                        right--; 
                    }

                    
                }
            }
            // return the triplets
            return triplets; 
        }
    }
}