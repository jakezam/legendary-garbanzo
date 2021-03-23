![inployd_logo](inployd.png)

# legendary-garbanzo

<hr />

## What is inployd?
   inployd is an app to bring Freelancers, contracts, and general business to one location with the addition of social media.
   Instead of just simple person to person job requests, inployd seeks to add a more personal and social connection to work.

<hr />

## What is legendary-garbanzo?
   Glad you asked, legendary-garbanzo is the backend API interface to the Inployd frontend application. It is a ASP.NET Core Web API application
   that interfaces with our backend Microsoft SQL Server. We use entity-framework for the creation, insertion, deletion, and updating of our data.
   There is no need to update the database manually as we use dotnet ef tools to do that for us with migrations.
   
   Our data is setup in the following format:
   - Users
   - Providers
   - Categories
   - Reviews
   - Jobs
   <br /> <br />
     
<hr />

## Codebase Overview
 - ASP.NET Core 3.1 Web API Application
 - Using Swagger for API documentation
 - Entity-framework for database management
 - Environment based appsettings files.

   ## How to get started:
   To get started working on legendary-garbanzo you need to install dotnet 3.1 and ASP.NET Core utilities.
   
   > Head over to https://dotnet.microsoft.com/download

   Once you have dotnet SDK installed you then need to install dotnet ef tools.

   > Head over to https://docs.microsoft.com/en-us/ef/core/cli/dotnet

   If you plan on using the IIS Launch feature of the app you will also need to setup IIS Express.

   > Can be found here https://www.microsoft.com/en-us/download/details.aspx?id=48264

   If you plan on working with a localhost SQL server (recommended) you will also
   need to install an SQL server to your machine.

   > Can be found here https://www.microsoft.com/en-us/sql-server/sql-server-downloads

   If you choose not to develop on a localhost server you will need to reach out to Nick
   to add your IP Address to the Azure Remote Develop server.  
   \
   After you have completed these steps you can clone the repository
   and do a NuGet restore and you should be up and running.
<hr />

## Launch Notes
   When running the application in a localhost setting you must remember to set
   the 
   
   > ASPNETCORE_ENVIRONEMENT=Local
   
   For your system. To do this with command prompt you can do:

   > set ASPNETCORE_ENVIRONMENT=Local

<hr />

## Git Best Practices
 - To keep the git repository organized and easier to use we will use:
   - Git flow: https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow
   - Conventional Commits: https://www.conventionalcommits.org/en/v1.0.0/
