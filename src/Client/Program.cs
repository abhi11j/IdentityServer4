using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        private static async Task Main()
        {
            //await clsClientCredentials.mdClientCredentials();

            await clsResourceOwnerPassword.mdResourceOwnerPassword();
        }



        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}
