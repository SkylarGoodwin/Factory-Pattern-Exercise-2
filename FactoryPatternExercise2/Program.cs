namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what database would you like to access? (SQL, Mondo, List)");
            var input = Console.ReadLine();
            IDataAccess db = DataAccessFactory.GetDataAccessType(input);
            var products = db.LoadData();
            db.SaveData();

            foreach ( var product in products ) 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
            }
        }
    }
}
