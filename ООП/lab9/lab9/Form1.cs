using Lab9;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Item zhenya = new("Zhenya", 23, 1347.248);
                Item dima = new("Dima", 17, 248.1347);
                label1.Text += Item.ConsolePrint(zhenya);
                label1.Text += Item.ConsolePrint(dima);
                Console.Write("zhenya + dima: ");
                label1.Text += Item.ConsolePrint(zhenya + dima);
                Console.Write("zhenya + 200: ");
                label1.Text += Item.ConsolePrint(zhenya + 200);
                Console.Write("5 * dima: ");
                label1.Text += Item.ConsolePrint(5 * dima);
            }
            catch (ItemException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}