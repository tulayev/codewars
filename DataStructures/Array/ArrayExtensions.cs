namespace DataStructures.Array
{
    static class ArrayExtensions
    {
        public static void Swap<T>(this T[] arr, int first, int second)
        {
            T temp = arr[second];
            arr[second] = arr[first];
            arr[first] = temp;
        }
    }
}
