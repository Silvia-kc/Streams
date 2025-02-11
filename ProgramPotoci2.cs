// See https://aka.ms/new-console-template for more information
string inputFilePath = "text.txt";
string outputFilePath = "output.txt";
try
{
    using (StreamReader reader = new StreamReader(inputFilePath))
    using (StreamWriter writer = new StreamWriter(outputFilePath))
    {
        int lineNumber = 1;
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            writer.WriteLine($"Line {lineNumber}: {line}");
            lineNumber++;
        }
    }
    Console.WriteLine("File processing complete. Check output.txt");
}
catch (IOException ex)
{
    Console.WriteLine("Error processing the file: " + ex.Message);
}
