public abstract class SmartDevice
{
    string _name;
    bool _is_on = true;

    protected void GlobalStatusUpdate()
    {
        try
        {
            // Attempt to find time device was last turned on
            //after device name, data is stored 
            string[] logContent = File.ReadAllLines("DeviceLogs.txt");
            int index = FindIndex(logContent, $"{_name}InitiatedTime");

            
            // If no error occurs, this code completes successfully
        }
        catch (FileNotFoundException ex)
        {
            // This block is executed if the file is not found
            Console.WriteLine("File not found: " + ex.Message);
        }
    }
}