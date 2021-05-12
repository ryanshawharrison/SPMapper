using System;

namespace SPMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing/debug code
            SPDrive myDrive = new SPDrive();

            myDrive.setUncPath("\\\\myserver\\share");
            myDrive.setUsername("Ryan");
            myDrive.setPassword("P@ssw0rd");
            myDrive.SetPersist(true);

            Console.WriteLine("Mapping drive: {0}, using username {1} and password {2}, perist: {3}", myDrive.getUncPath(), myDrive.getUsername(), myDrive.getPassword(), myDrive.getPersist().ToString());
        }
    }
}
