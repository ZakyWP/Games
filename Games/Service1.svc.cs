using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Games
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

       

    private const string ConnectionString =
            "Server = tcp:mwp-server.database.windows.net,1433;Initial Catalog = mwp - db; Persist Security Info=False;User ID =Michael; Password=Secret1234; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

       


        public string GetGames()
        {
            throw new NotImplementedException();
        }

        public int AddGame(string Name, string ReleaseDate, string Platform)
        {
            const string InsertGame =
                "insert into games (Name, ReleaseDate, Platform), values (@Name, @ReleaseDate, @Platform )";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString)) 
            {
                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(InsertGame, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", Name);
                    insertCommand.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                    insertCommand.Parameters.AddWithValue("@Platform", Platform);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public string ReadGame()
        {
            throw new NotImplementedException();
        }
    }
}
