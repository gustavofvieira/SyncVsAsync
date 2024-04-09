using Newtonsoft.Json;
using System;
using System.IO;

namespace Domain.Data
{
    public class ConsumeDataSync
    {
        public Database Execute(string jsonFilePath)
        {
            // Caminho do arquivo JSON
            //string jsonFilePath = "Data//Data.json";
            //string jsonFilePath = "Data//thousand.json";

            Database data = new Database();

            // Verifica se o arquivo JSON existe
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonContent = File.ReadAllText(jsonFilePath);

                    // Desserializa o JSON para um objeto C#
                    data = JsonConvert.DeserializeObject<Database>(jsonContent);

                    // Exibe os dados lidos do JSON
                    Console.WriteLine("Users:");
                    foreach (var user in data.Users)
                    {
                        Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
                    }

                    Console.WriteLine("\nProducts:");
                    foreach (var product in data.Products)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("O arquivo JSON não foi encontrado.");
            }

            return data;
        }
    }
}
