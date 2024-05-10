using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace AuthService
{
    public class AuthService : IAuthService
    {
        public Boolean UpdateUserDescription(string login, string password, string description)
        {
            int userID = SqlServerHelper.UserExists(login, password);
            if (userID <= 0)
            {
                return false;
            }
            if(SqlServerHelper.UpdateUserDescription(userID, description) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetUserDescription(int userID)
        {
            var user = SqlServerHelper.GetUser(userID);
            return user.Description;
        }
        public User[] GetUsers(string login, string password)
        {
            if(SqlServerHelper.UserExists(login, password) <= 0)
            {
                return null;
            }
            var users = SqlServerHelper.GetUsers();
            return users.ToArray();
        }

        /// <summary>
        /// Exemplo
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string VerifyAcessToBD()
        {
            User user = SqlServerHelper.GetUser(1);
            if (user == null)
                return "Erro ao aceder à base de dados";
            return user.Name;
        }


    }

}