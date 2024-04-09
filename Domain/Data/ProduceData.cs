using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class ProduceData
    {
        public async Task<string> Execute()
        {
            // Gera os dados
            Database data = GenerateData(1000, 1000);

            // Serializa os dados em formato JSON
            string jsonContent = JsonConvert.SerializeObject(data, Formatting.Indented);

            // Escreve o JSON em um arquivo
            string jsonFilePath = "Data//database.json";
            await File.WriteAllTextAsync(jsonFilePath, jsonContent);

            Console.WriteLine("Arquivo JSON gerado com sucesso.");
            return "Arquivo JSON gerado com sucesso.";
        }

        // Método para gerar dados aleatórios
        public static Database GenerateData(int numUsers, int numProducts)
        {
            var random = new Random();

            var users = new List<User>();
            var products = new List<Product>();

            // Gera usuários aleatórios
            for (int i = 1; i <= numUsers; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = "User" + i,
                    Age = random.Next(18, 70) // Idade aleatória entre 18 e 70
                });
            }

            // Gera produtos aleatórios
            for (int i = 1; i <= numProducts; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = "Product" + i,
                    Price = random.NextDouble() * 100 // Preço aleatório entre 0 e 100
                });
            }

            return new Database
            {
                Users = users.ToArray(),
                Products = products.ToArray()
            };
        }

    }
}
