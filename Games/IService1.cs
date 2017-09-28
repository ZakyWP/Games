using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Games
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        IList<Games> GetAllGames();

        [OperationContract]
        int AddGame(string Name, string ReleaseDate, string Platform);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string Platform { get; set; }
    }
}
