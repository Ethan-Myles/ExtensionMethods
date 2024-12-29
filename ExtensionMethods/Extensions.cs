namespace ExtensionMethods{

    public static class Extensions
    {
        public static bool IsLessThan(this int i, int value)
        {
            return i < value;
        }

        public static IEnumerable<List<T>> ChunkBy<T>(this List<T> list, int chunkSize)
        {
            //Check for valid chunk size
            if (chunkSize <= 0)
                throw new ArgumentException("Chunk size must be greater than zero.");

            //Create chunks
            for (int i = 0; i < list.Count; i += chunkSize)
            {
                yield return list.GetRange(i, Math.Min(chunkSize, list.Count - i));
            }
        }

        public static IEnumerable<string> Capitalise(this IEnumerable<string> strings)
        {
            foreach (var str in strings)
            {
                if (string.IsNullOrEmpty(str))
                {
                    yield return str;
                }
                else
                {
                    //Capitalise the first letter and make the rest lowercase
                    yield return char.ToUpper(str[0]) + str.Substring(1).ToLower();
                }
            }
        }
    }

}
