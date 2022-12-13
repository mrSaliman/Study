namespace Lab2
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                Item zhenya = new("Zhenya", 23, 1347.248);
                Item dima = new("Dima", 17, 248.1347);
                Item.ConsolePrint(zhenya);
                Item.ConsolePrint(dima);
                Console.Write("zhenya + dima: ");
                Item.ConsolePrint(zhenya + dima);
                Console.Write("zhenya + 200: ");
                Item.ConsolePrint(zhenya + 200);
                Console.Write("5 * dima: ");
                Item.ConsolePrint(5 * dima);
            }
            catch (ItemException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}