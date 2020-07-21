using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoFile
{
    class Cryp
    {
        public static void EncryptoInfoByNameFile(string path, string password, string securityWord)
        {
            string[] FileNameWithExtension = path.Split(new char[] { '.' });

            // Создать поток шифруемого файла
            FileStream fileStreamEncrypt = File.Create(FileNameWithExtension[0] + ".crypt");
            // Создать поток исходного файла
            FileStream fileStreamSource = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            // Создать массив байт из исходного файла
            byte[] buffer = new byte[fileStreamSource.Length];
            fileStreamSource.Read(buffer, 0, buffer.Length);
            
            // Пароль
            string cryptoPassword = password;
            //Соль
            byte[] cryptoSecurityWord = Encoding.Default.GetBytes(securityWord);

            // Создание экземпляра алгоритма шифрования
            RijndaelManaged rijndaelManaged = new RijndaelManaged();

            // Генерация ключа
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(cryptoPassword, cryptoSecurityWord);

            // Создание параметров шифрования
            rijndaelManaged.Key = rfc2898.GetBytes(rijndaelManaged.KeySize / 8);
            rijndaelManaged.IV = rfc2898.GetBytes(rijndaelManaged.BlockSize / 8);

            // Получение совместимого с CryptoStream шифратора
            ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor();

            // Создание потока для шифрования 

            CryptoStream cryptoStream = new CryptoStream(fileStreamEncrypt, encryptor, CryptoStreamMode.Write);

            // не понятно зачем эта операция (делали в классе)
            cryptoStream.Write(buffer, 0, buffer.Length);

            // Закрыть потоки (не требуется, если открывать через using)
            cryptoStream.Close();   //шифратор
            fileStreamEncrypt.Close();         // поток в памяти 
            fileStreamSource.Close();           // Поток источника
        }


        public static void DecryptoInfoByNameFile(string path, string password, string securityWord)
        {
            string[] cryptoFileNameWithExtension = path.Split(new char[] { '.' });

            // Создать поток для расшифрованного файла
            using (FileStream fileStreamDecrypt = File.Create(cryptoFileNameWithExtension[0] + ".decrypt"))
            {
                // Создать поток расшифруемого файла
                using (FileStream fileStreamEncrypt = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    // Пароль
                    string decryptoPassword = password;

                    //Соль
                    byte[] decryptoSecurityWord = Encoding.ASCII.GetBytes(securityWord);

                    // Создание алгоритма шифрования
                    RijndaelManaged alg = new RijndaelManaged();

                    // Генерация пароля
                    Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, decryptoSecurityWord);

                    // Получение параметров щифрования
                    alg.Key = key.GetBytes(alg.KeySize / 8);
                    alg.IV = key.GetBytes(alg.BlockSize / 8);

                    // Получение шифратора совместимого с CryptoStream
                    ICryptoTransform decryptor = alg.CreateDecryptor();


                    // Создание потока для чтения расшифрованного файла
                    using (CryptoStream decryptoStream = new CryptoStream(fileStreamEncrypt, decryptor, CryptoStreamMode.Read))
                    {

                        int b = decryptoStream.ReadByte();
                        while (b != -1)
                        {
                            fileStreamDecrypt.WriteByte((byte)b);
                            b = decryptoStream.ReadByte();         
                        }
                    }
                }
            }
        }
    }
}
