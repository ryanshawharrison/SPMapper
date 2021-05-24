using System;

namespace SPMapper
{
    class SPDrive
    {
        private char drvLetter;
        private String uncPath;

        public SPDrive()
        {
            // do nothing
        }
        public SPDrive(char newDrvLetter, String newUncPath)
        {
            drvLetter = newDrvLetter;
            uncPath = newUncPath;
        }
        public void mapDrive()
        {
            String cmdArgs = "/C net use " + drvLetter.ToString() + ": " + uncPath + " /persistent:yes";
            System.Diagnostics.Process.Start("cmd.exe", cmdArgs);
        }

        // getters and setters
        public String getDrvLetter() {return drvLetter.ToString();}
        public void setDrvLetter(char newDrvLetter) {drvLetter = newDrvLetter;}
        public String getUncPath() {return uncPath;}
        public void setUncPath(String newUncPath) {uncPath = newUncPath;}
    }
}