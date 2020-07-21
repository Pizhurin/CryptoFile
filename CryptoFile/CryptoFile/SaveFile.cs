using Microsoft.Win32;
using System.IO;

namespace CryptoFile
{
    class SaveFile
    {
        /// <summary>
        /// Приимает массив байт и сохраняет их в файл
        /// </summary>
        /// <param name="buffer"></param>
        public static void SaveCrypt(byte[] crypto)
        {
            // Сохранение файла (выводится окно и можно выбрать куда и в каком формате сохранять) с фильтрами
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            saveFileDialog.Filter = "Files encrypt(*.crypt)|*.crypt";
            if (saveFileDialog.ShowDialog() == true)
            {
                //string buffer = "buffer";
                //File.WriteAllText(saveFileDialog.FileName, buffer);
                File.WriteAllBytes(saveFileDialog.FileName, crypto);
            }

        }

        /// <summary>
        /// Приимает строку и сохраняет ее в файл
        /// </summary>
        /// <param name="decrypto"></param>
        public static void SaveDecrypt(string decrypto)
        {
            // Сохранение файла (выводится окно и можно выбрать куда и в каком формате сохранять) с фильтрами
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            saveFileDialog.Filter = "Files decrypt(*.decript)|*.decript";
            if (saveFileDialog.ShowDialog() == true)
            {
                //string buffer = "buffer";
                //File.WriteAllText(saveFileDialog.FileName, buffer);
                File.WriteAllText(saveFileDialog.FileName, decrypto);
            }

        }

    }
}
