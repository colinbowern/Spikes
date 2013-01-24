(sample content)

.NET Solution Boilerplate Development Notes
===========================================
To develop on this project you will need the following items:
* Visual Studio 2012 Premium
  - Set the AssemblyReferenceResolveMode property in C:\Program Files (x86)\Microsoft Visual Studio 11.0\Team Tools\Static Analysis Tools\FxCop\FxCopCmd.exe.config to StrongNameIgnoringVersion to fix an assembly resolution issue with Ninject (http://davesbox.com/archive/2008/06/14/reference-resolutions-changes-in-code-analysis-and-fxcop-part-2.aspx)
* IIS Express
  - Set the overrideModeDefault to Allow for anonymousAuthentication and windowsAuthentication
* smtp4dev - http://smtp4dev.codeplex.com
  - Required if you want to test email functionality
* SQL Server Developer Edition
  - Reporting Services configured with:
    - Report Server: /ReportServer
    - Report Manager: /ReportManager
    - Email Address: reports@localtest.me
    - SMTP Server: smtp.localtest.me
    - Execution Account: <your user account>
      - Required to run snapshots and subscriptions on a schedule
    - Ensure your user account has the following permissions using Report Manager
      - System Administrator role
      - Content Manager role on root folder
  - If you have Skype installed you need to uncheck the "Use port 80 and 443 as alternatives for incoming connections" in Options> Advanced > Connection otherwise the Skype process takes over port 80/443.
  - If you have VMware installed you will need to either disable Virtual Machine Sharing or change the port to something other than 80/443 as it has a similar issue of not respecting HTTP.SYS URL reservation.
* SQL Server LocalDB
* ReSharper with XUnit Test Runner (see XUnitContrib project)
  
To author the help content:
* Help + Manual
* HTML Help Workshop 1.3 - http://go.microsoft.com/fwlink/?LinkId=14188

Building from the Command Line
==============================
An MSBuild script is used by the build server to execute the various steps necessary to deliver a release package.  This script can also be run locally to create a private build. The following public targets are available using a Visual Studio Command Prompt:

Syntax: Go.cmd [Target]

Targets:
1. Clean: Clean up build output
2. Compile: Clean up build output, updates the version number and compile the solution
3. Test: Run tests
4. Analyze: Run static code analysis
5. Package: Create deployment package