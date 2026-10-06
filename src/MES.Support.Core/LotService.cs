using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MES.Support.Core
{
    public class LotService
    {
        private readonly DatabaseConnection _databaseConnection;

        public LotService()
        {
            _databaseConnection = new DatabaseConnection();
        }

        public Lot GetLotByNumber(string lotNumber)
        {
            string sql = @"
                SELECT
                    LotID,
                    LotNumber,
                    LotStatus,
                    QuantityCompleted
                FROM Production.LOT WITH (NOLOCK)
                WHERE
                    LotNumber = @LotNumber";

            using SqlConnection connection = 
                _databaseConnection.GetConnection();

            connection.Open();

            using SqlCommand command =
                new SqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@LotNumber",
                lotNumber);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Lot lot = new Lot();

                lot.LotID = reader.GetInt32(0);

                lot.LotNumber = reader.GetString(1);

                lot.Status = reader.GetString(2);

                lot.QuantityCompleted = reader.GetInt32(3);

                return lot;
            }

            return null;
            
        }
    }
}
