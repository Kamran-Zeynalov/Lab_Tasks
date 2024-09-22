namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new("Kamran");
            Company company = new("Code Academy", "M.Hadi",10);

            company.AddWorker(worker);
            company.RemoveWorker("Kamran");
        }



    }
}
