namespace _28._11._24
{
    internal class Program
    {
        //1
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10 || numbers.Any(n => n < 0 || n > 9))
            {
                throw new ArgumentException("цыыфры должны быть от 0 до 9");
            }
            return string.Format("+7 ({0}{1}{2}) {3}{4}{5}-{6}{7}-{8}{9}",
                                 numbers[0], numbers[1], numbers[2],
                                 numbers[3], numbers[4], numbers[5],
                                 numbers[6], numbers[7], numbers[8], numbers[9]);
        }
        //2
        public static string TrimString(string phrase, int len)
        {
            if (len <= 3)
            {
                return phrase.Length <= len ? phrase : phrase.Substring(0, len) + "...";
            }
            return phrase.Length <= len ? phrase : phrase.Substring(0, len - 3) + "...";
        }
        //3
        public static long SquareDigits(long n)
        {
            var result = string.Concat(n.ToString().Select(c => Math.Pow(c - '0', 2)));
            return long.Parse(result);
        }
        //4
        public static string Likes(string[] names)
        {
            switch (names.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{names[0]} likes this";
                case 2: return $"{names[0]} and {names[1]} like this";
                case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
                default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 9, 9, 3, 0, 1, 4, 8, 8, 5, 4})); 
            Console.WriteLine(TrimString("privet dryg kak dela", 14)); 
            Console.WriteLine(SquareDigits(5678)); 
            Console.WriteLine(Likes(new string[] { })); 
            Console.WriteLine(Likes(new string[] { "Peter" }));
            Console.WriteLine(Likes(new string[] { "Jacob", "Alex" })); 
            Console.WriteLine(Likes(new string[] { "Max", "John", "Mark" })); 
            Console.WriteLine(Likes(new string[] { "Alex", "Jacob", "Mark", "Max" })); 
        }
    }
}
