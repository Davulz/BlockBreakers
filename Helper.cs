namespace BlockBreaker
{
    internal class Helper
    {
        private static object lockobject = new object();

        public static void PrintAtPosition(int x, int y, string text)
        {
            lock (lockobject)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(text);
            }
        }

        public static void PrintAtPosition(int x, int y, char symbol)
        {
            lock (lockobject)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }
    }
}
