using System;
using System.Collections.Generic;

namespace CSharpMultipleInterfaces {

    interface IStorable {
        void Load();
        void Save();
        Boolean NeedsSave {get; set;}
    }

    interface IEncryptable {
        void Encrypt();
        void Decrypt();
    }

    class Document : IStorable, IEncryptable {

        private string name;

        public Document(string s) {
            name = s;
            Console.WriteLine("Creating new document with name '{0}'", name);
        }

        public void Load() {
            Console.WriteLine("Loading the document");
        }

        public void Save() {
            Console.WriteLine("Saving the document");
        }

        public void Encrypt() {
            Console.WriteLine("Encrypting the document");
        }

        public void Decrypt() {
            Console.WriteLine("Decrypting the document");
        }
        public Boolean NeedsSave { get; set; }
    }// End class Document

    class Program {
        
        static void Main(string[] s) {

            Document d = new Document("New Test Document");

            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}