using System;

namespace SPMapper
{
    class SPDrive
    {
        private String uncPath;
        private String username;
        private String password;
        private Boolean persist;

        

        // getters and setters
        public String getUncPath()
        {
            return uncPath;
        }

        public void setUncPath(String newUncPath)
        {
            uncPath = newUncPath;
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String newUsername)
        {
            username = newUsername;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String newPassword)
        {
            password = newPassword;
        }

        public Boolean getPersist()
        {
            return persist;
        }

        public void SetPersist(Boolean newPersist)
        {
            persist = newPersist;
        }
    }
}