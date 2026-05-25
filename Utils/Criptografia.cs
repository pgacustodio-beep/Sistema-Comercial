using System.Security.Cryptography;
using System.Text;

namespace SistemaComercialETEC.Utils
{
    public class Criptografia
    {
        public static string GerarHash(string texto)
        {
            using (SHA256 sha256 =
                SHA256.Create())
            {
                byte[] bytes =
                    sha256.ComputeHash(
                        Encoding.UTF8.GetBytes(texto));

                StringBuilder builder =
                    new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(
                        b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}