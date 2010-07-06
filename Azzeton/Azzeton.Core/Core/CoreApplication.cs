using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using Azzeton.Shared;
using Azzeton.Shared.Security;
using System.IO;
using System.Text;
namespace Azzeton.Core
{
    /// <summary>
    /// Application level object
    /// </summary>
    public class CoreApplication 
    {
        /// <summary>
        /// Check user credentials against database
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns>true if found</returns>
        public static bool Login(string username, string password)
        {
            try
            {
                string _password = Azzeton.Shared.Security.SuperCryptor.Encrypt(password, "punana");
                Collection<SearchParameter> _criteria = new Collection<SearchParameter>();
                _criteria.Add(new SearchParameter("Username", username, ComparismType.Equal));
                _criteria.Add(new SearchParameter("Password", _password, ComparismType.Equal));

                //Collection<IUser> _users = new UserManager().Get(_criteria, SearchUsing.AND);
                //if (_users.Count > 0)
                //{
                //    CoreGlobals.CurrentUser = _users[0];
                //    new SystemAuditManager().Add(new SystemAudit(0, "User Login", string.Format(CultureInfo.InvariantCulture, "User {0} Logged Into {1}", CoreGlobals.CurrentUser.Username, ProductSettings.ProductName), "OK", DateTime.Now, CoreGlobals.CurrentUser.Id));
                //    return true;
                //}
                return false;
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}
            return false;
        }
        /// <summary>
        /// Generate a random string
        /// </summary>
        /// <returns>Generated string</returns>
        public static string AutoGenearatePasword()
        {
            Random rand = new Random();
            StringBuilder _builder = new StringBuilder();
            for (int i = 1; i <= 3; i++)
                _builder.Append(rand.Next(9, 65).ToString("X2", CultureInfo.InvariantCulture));
            return _builder.ToString();
        }
        /// <summary>
        /// Check user credentials against database
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns>true if found</returns>
        public bool LoginUser(string username, string password)
        {
            return CoreApplication.Login(username, password);
        }
        public bool HasErrors { get; set; }
    }
}
