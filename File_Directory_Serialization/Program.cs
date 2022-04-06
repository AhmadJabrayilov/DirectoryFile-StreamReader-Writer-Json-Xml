using System;
using System.IO;

namespace File_Directory_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\User\Desktop\HOMETASKS\File_Directory_Serialization\File_Directory_Serialization\Files");

            if (!File.Exists(@"C:\Users\User\Desktop\HOMETASKS\File_Directory_Serialization\File_Directory_Serialization\Files\Database.json"))
            {
                File.Create(@"C:\Users\User\Desktop\HOMETASKS\File_Directory_Serialization\File_Directory_Serialization\Files\Database.json");
            }



        }
    }
}
