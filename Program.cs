using System;

namespace SPMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String userHash = "da4e0c698f2570f6d2c9a09c45656f0b896e552f617c1de34ba912e5dc0469c8";
            
            // testing/debug code
            SPDrive Z = new SPDrive('z',"\\\\localhost\\SPMapper");

            // Console.WriteLine("Mapping UNC path: {0}, as {1}: drive.", Z.getUncPath(), Z.getDrvLetter());
            // Z.mapDrive();

            System.Console.WriteLine("Connecting to: {0}", DBConnect.getConnStr());
        }
    }
}
