using PRG271_Project_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_Services
{
    public class SystemService
    {
        private DataManager _dataManager;
        public SystemService() { 
            _dataManager = new DataManager();
        }

        public Boolean Register(string username, string password) 
        {
            return this._dataManager.Register(username, HashPassword(username,password));
        }

        public Boolean Login(string username, string password)
        {

            if(this._dataManager.GetLoginHash(username) == HashPassword(username,password))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private string HashPassword(string username, string password)
        {
            string iv = "y9E6h6EDvksgha9ISJ6rkg==";
            string key = "/vNQmLQJqP+BU+u1+UyvWdxNeEjg/Eyn9+1GfzAd9mw=";

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                        }
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
    }
}
