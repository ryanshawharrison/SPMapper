# SPMapper: SharePoint Drive Mapping Tool

A simple command line tool build on .NET Core 3.1 which will allow users to define a list of SharePoint document libraries that will be mapped as a Windows network drive.

## Planned Features

- Configuration will be managed on a per-user basis and stored in JSON/TOML or similar.
- After initial configuration, SPMapper will automatically configure system settings and map the SP libraries as network drives.
- Intended to be used at logon to remap the drives similar to how a logon script or Group Policy would handle network drive mapping.
- Will check logon status to SharePoint Online and Internet Connection settings to ensure they are set appropriately.