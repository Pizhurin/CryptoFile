using System;
using System.Windows;

namespace CryptoFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Выполнено вместо дз");
        }

       
        private void button_encryptToFile_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустоту полей textBox_password и textBox_securityWord
            if (textBox_password.Text != String.Empty && textBox_securityWord.Text != "")
            {
                //Проверка поля textBox_securityWord на количество знаков не менее 8
                if (textBox_securityWord.Text.Length > 8)
                {
                    string buffer = null;

                    // Открытие файла через окно (OpenFileDialog)
                    buffer = LoadFile.LoadPathTextFile();

                    //Шифровка текста и запись файла в ту же директорию где и источник
                    Cryp.EncryptoInfoByNameFile(buffer, textBox_password.Text, textBox_securityWord.Text);

                    // Вывод сообщения об успехе
                    MessageBox.Show("Successfull!");

                }
                else
                {
                    MessageBox.Show("Security word less 8 simbols");
                }
            }                      
            else
            {
                MessageBox.Show("Empty fields!");
            }
        }

        private void button_decryptToFile_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустоту полей textBox_password и textBox_securityWord
            if (textBox_password.Text != String.Empty && textBox_securityWord.Text != "")
            {
                //Проверка поля textBox_securityWord на количество знаков не менее 8
                if (textBox_securityWord.Text.Length > 8)
                {
                    string pathCryptoFile = null; ;

                    // Открытие файла через окно (OpenFileDialog)
                    pathCryptoFile = LoadFile.LoadPathCryptoFile();

                    //Расшифровка текста и запись файла в ту же директорию где и источник
                   Cryp.DecryptoInfoByNameFile(pathCryptoFile, textBox_password.Text, textBox_securityWord.Text);

                    // Вывод сообщения об успехе
                    MessageBox.Show("Successfull!");
                }
                else
                {
                    MessageBox.Show("Security word less 8 simbols");
                }
            }
            else
            {
                MessageBox.Show("Empty fields!");
            }
        }
    }
}
