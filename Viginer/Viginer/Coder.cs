using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coders
{
    class Coder
    {
        private static char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
        private int N = characters.Length;
        /// <summary>
        /// Метод шифрования 
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <param name="key">Ключ шифровки</param>
        /// <returns>Зашифрованная строка</returns>
        public string Encode(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            string result = "";
            int key_index = 0;
            
            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) + Array.IndexOf(characters, key[key_index])) % N;
                result += characters[c];
                key_index++;
                if ((key_index + 1) == key.Length) key_index = 0;
            }
            return result; 
        }
        /// <summary>
        /// Метод расшифровки
        /// </summary>
        /// <param name="input">Строка которую нужно расш.</param>
        /// <param name="key">Ключ шифровки</param>
        /// <returns>Расшифрованная строка</returns>
        public string Decode(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            string result = "";
            int key_index = 0;

            foreach(char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, key[key_index])) % N;
                result += characters[p];
                key_index++;
                if ((key_index + 1) == key.Length) key_index = 0;
            }
            return result;
        }
        /// <summary>
        /// Генерируем псевдослучайный ключ (метод гаммирования)
        /// </summary>
        /// <param name="length">Длина ключа</param>
        /// <param name="startSeed">Число инициализации генератора случайных чисел(всегда должен быть одним и тем же)</param>
        /// <returns>Псевдослучайный ключ</returns>
        public string Generate_Pseudorandom_Key(int length, int startSeed)
        {
            Random rand = new Random(startSeed);
            string result = "";
            for (int i = 0; i < length;i++)
            {
                result += characters[rand.Next(0, characters.Length)];
            }
            return result;
        }
    }
}
