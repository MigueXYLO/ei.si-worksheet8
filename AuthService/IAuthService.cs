using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AuthService
{
    [ServiceContract]
    public interface IAuthService
    {
        /// <summary>
        /// Verifica se é possível aceder à BD
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string VerifyAcessToBD();

        [OperationContract]
        User[] GetUsers(string login, string password);

        [OperationContract]
        string GetUserDescription(int userID);

        [OperationContract]
        Boolean UpdateUserDescription(string login,string password, string description);

    }

}
