using System;
using System.Threading.Tasks;
using vCard;

//Burada ilk once API dan melumatlari cekirik, daha sonra hemin melumatlari Deserializasiya edirik. En sonda ise Bu melumatlari vcard dizisine kaydedirik.
namespace VCardGenerator
{
    class Program
    { 
        static async Task Main(string[] args)
        {
            var apiClient = new RandomUserApiClient();
            var deserializer = new RandomUserDeserializer();
            var saver = new VCardSaver();

            string jsonData = await apiClient.GetRandomUserData();
            VCard vcard = deserializer.Deserialize(jsonData);

            string directory = @"C:\VCardDirectory";
            saver.SaveToFile(vcard, directory);

            Console.WriteLine($"vCard created and saved to {directory}");
        }
    }
}
