using System;

namespace SPMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing/debug code
            SPDrive Z = new SPDrive();

            Z.setDrvLetter('Z');
            Z.setUncPath("\\\\localhost\\SPMapper");

            Console.WriteLine("Mapping UNC path: {0}, as {1}: drive.", Z.getUncPath(), Z.getDrvLetter());
            Z.mapDrive();
        }
    }
}
