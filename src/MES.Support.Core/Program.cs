using Microsoft.Data.SqlClient;

namespace MES.Support.Core;

class Program
{
    static void Main(string[] args)
    {
        LotService service = new LotService();

        Lot? lot = service.GetLotByNumber("LOT-OPT-5003");

        if (lot != null)
        {
            Console.WriteLine(
                $"Lot: {lot.LotNumber}");

            Console.WriteLine(
                $"Status: {lot.Status}");

            Console.WriteLine(
                $"Quantity: {lot.QuantityCompleted}");
        }
        else
        {
            Console.WriteLine("Lot not found");
        }
    }
}
