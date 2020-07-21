using Microsoft.Win32;
using System.IO;

namespace CryptoFile
{
    /// <summary>
    /// Возвращает строку прочитанную из загруженного файла
    /// </summary>
    class LoadFile
    {
        public static string LoadText()
        {
            string buffer = null;
            // Открытие файла через окно с фильтрами
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            fileDialog.Filter = "Text files(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == true)
            {
                string filename = fileDialog.FileName;
                buffer = File.ReadAllText(filename);
            }
            return buffer;
        }

        /// <summary>
        /// Возвращает полный путь к выбранному файлу (.txt)
        /// </summary>
        /// <returns></returns>
        public static string LoadPathTextFile()
        {
            string path = null;
            // Открытие файла через окно с фильтрами
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            fileDialog.Filter = "Text files(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == true)
            {
                path = fileDialog.FileName;
            }
            return path;
        }


        public static byte[] LoadCrypt()
        {
            byte[] bufferBytes = null;
            // Открытие файла через окно с фильтрами
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            fileDialog.Filter = "Files encrypt(*.crypt)|*.crypt";
            if (fileDialog.ShowDialog() == true)
            {
                string filename = fileDialog.FileName;
                bufferBytes = File.ReadAllBytes(filename);
            }
            return bufferBytes;
        }

        /// <summary>
        /// Возвращает полный путь к выбранному файлу (.crypt)
        /// </summary>
        /// <returns></returns>
        public static string LoadPathCryptoFile()
        {
            string path = null;
            // Открытие файла через окно с фильтрами
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Text files(*.txt)|*.txt|Files decrypt(*.decript)|*.decript|Files encrypt(*.crypt)|*.crypt";
            fileDialog.Filter = "Files encrypt(*.crypt)|*.crypt";
            if (fileDialog.ShowDialog() == true)
            {
                path = fileDialog.FileName;                
            }
            return path;
        }
    }
}
