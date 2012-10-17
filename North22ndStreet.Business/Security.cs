using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    public class Security
    {
        /// <summary>
        /// Create new instance of Security class
        /// </summary>
        public Security() { }

        /// <summary>
        /// Verify username and password
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="password">Password</param>
        /// <returns>Whether or not password and ID match</returns>
        public static int VerifyPassword(string userID, string password)
        {
            SecurityDO sDO = new SecurityDO();
            DataTable dt = sDO.Verify(new object[] { userID, password });
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0] != null)
                {
                    return int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
                return 0;
        }

       

        #region Encryption

        UnicodeEncoding bytConvertor = new UnicodeEncoding();
        RSACryptoServiceProvider RSAServiceProvider = new RSACryptoServiceProvider();

        public string EncryptData(string strData)
        {                
            byte[] enData = Encrypt(getBytes(strData), RSAServiceProvider.ExportParameters(false));
            return bytConvertor.GetString(enData);
        }

        public string DecryptData(string strData)
        {
            byte[] deData = Decrypt(getBytes(strData), RSAServiceProvider.ExportParameters(true));
            return bytConvertor.GetString(deData);
        }

        public byte[] getBytes(string strData)
        {
            return bytConvertor.GetBytes(strData);
        }

        //The below function encrypt the data
        static private byte[] Encrypt(byte[] DataToEncrypt, RSAParameters keyInfo)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(keyInfo);
            return RSA.Encrypt(DataToEncrypt, false);
        }

        //The below function decrypt the data
        static private byte[] Decrypt(byte[] DataToDecrypt, RSAParameters keyInfo)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(keyInfo);
            return RSA.Decrypt(DataToDecrypt, false);
        }

        #endregion Encryption

    }
}
