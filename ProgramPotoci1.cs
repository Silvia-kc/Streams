// See https://aka.ms/new-console-template for more information
string filePath = "text.txt";
try
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        int lineNumber = 0;
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            if (lineNumber % 2 != 0)
            {
                Console.WriteLine(line);
            }
            lineNumber++;
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine("Error reading the file: " + ex.Message);
}