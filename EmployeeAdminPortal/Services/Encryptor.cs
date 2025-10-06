using System.Security.Cryptography;
using System.Text;

namespace EmployeeAdminPortal.Services
{
    public static class Encryptor
    {
        public static string HashSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesTexto = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytesTexto);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
