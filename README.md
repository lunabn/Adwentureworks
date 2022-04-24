# Adventureworks
Command Usage – dotnet new mvc:
1. “dotnet new mvc”
The command creates a new “ASP.NET Core MVC Web Application”, the application contains basic boilerplate files and directory. The name of the project is not specified in the command, so by default, the name of the project will be taken from the name of the folder the command has been executed in. The command also restores the dependencies required by the web project. As the default language is C#, a C# ASP.NET MVC project will be created.

The MVC application created is ready to use, on executing the command “dotnet run”, the application will be hosted on local IIS Express server and the same will be listening on the following ports:

```
c:\AdventureWorks>dotnet new mvc
```


```
dotnet run
```


Sample https://docs.microsoft.com/en-us/ef/core/cli/dotnet

Installing the tools
dotnet ef can be installed as either a global or local tool. Most developers prefer installing dotnet ef as a global tool using the following command:


```
dotnet tool install --global dotnet-ef
```

Before you can use the tools on a specific project, you'll need to add the Microsoft.EntityFrameworkCore.Design package to it.

.NET CLI

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Verify installation
Run the following commands to verify that EF Core CLI tools are correctly installed:

.NET CLI

```
dotnet ef
```

The following example scaffolds all schemas and tables and puts the new files in the Models folder.

```
dotnet ef dbcontext scaffold "Server=tcp:sqlserver.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=youruser;Password=yourpassword;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

https://gavilan.blog/2018/04/28/asp-net-core-2-doing-scaffolding-with-dotnet-cli-aspnet-codegenerator/

As we can see, we have many options, we can indicate the name of the controller, if it will use asynchronous methods, if it will not use views (useful for web api), the model, the context, in short, we have options to make the controller we need. Let’s see first a simple example. We will generate an api-style controller, without views, with write and read actions:

```
dotnet aspnet-codegenerator controller -name ExampleController -actions -api            -outDir Controllers
```

That should create a controller called ExampleController in the Controllers folder.

Now let’s involve a model. We are going to generate a controller, which is not API style, without views, with writing and reading actions focused on a given model. In the case of the project we are working on, the model is called Person, and the data context is called ApplicationDbContext:

```
dotnet aspnet-codegenerator controller -name PeopleController -actions -nv -m Person -dc ApplicationDbContext -outDir Controllers
```

Of course, when you are scaffolding a Controller, you can generate all the views for the different viewTemplates (Create, List, Edit, etc.), you just don’t specify the -nv options. So for example, in the previous case, if you also would like to create the views, just do it like this:

```
dotnet aspnet-codegenerator controller -name PeopleController -actions -m Person -dc ApplicationDbContext -outDir Controllers
```

Please notice that all I did was to remove the -nv option. But let’s say that for some reason, you want to generate the views yourself. Let’s see how to scaffold Views.
