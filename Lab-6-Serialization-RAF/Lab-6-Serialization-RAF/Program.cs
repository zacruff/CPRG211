using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace Lab_6_Serialization_RAF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create event object
            int eventNumber = 1;
            string location = "Calgary";
            Event obj = new Event();
            obj.EventNumber = eventNumber;
            obj.Location = location;

            // Create stream object and formatter object
            Stream stream = new FileStream("event.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();

            // Serialize event object
            formatter.Serialize(stream, obj);
            stream.Close();

            // Deserialize object and write values to console
            Stream newStream = new FileStream("event.txt", FileMode.Open, FileAccess.Read);
            Event newObj = (Event)formatter.Deserialize(newStream);
            Console.WriteLine(newObj.EventNumber);
            Console.WriteLine(newObj.Location);
            newStream.Close();

            // Hackathon Question
            Console.WriteLine("Tech Competition");
            ReadFromFile();
        }
        static void ReadFromFile()
        {
            using (Stream fileStream = new FileStream("event.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write("Hackathon");
                writer.Close();
            }

            using (Stream fileStream = new FileStream("event.txt", FileMode.Open, FileAccess.Read))
            {
                // Finding the first character
                StreamReader streamReader = new StreamReader(fileStream);
                char firstLetter = (char)streamReader.Read();
                Console.WriteLine($"The First Character is: \"{firstLetter}\"");
                // Finding the middle character
                StreamReader streamReaderTwo = new StreamReader("event.txt");
                long center = fileStream.Length / 2;
                fileStream.Seek(center, SeekOrigin.Begin);
                char centerLetter = (char)streamReader.Read();
                Console.WriteLine($"The Middle Character is: \"{centerLetter}\"");
                // Finding the last character
                StreamReader streamReaderThree = new StreamReader("event.txt");
                fileStream.Seek(-1, SeekOrigin.Current);
                char lastLetter = (char)streamReader.Read();
                Console.WriteLine($"The Last Character is: \"{lastLetter}\"");
                streamReader.Close();
            }
        }
    }
}