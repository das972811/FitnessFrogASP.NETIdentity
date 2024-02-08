To Add Migrations
    dotnet ef migrations add InitialCreate --project ../FitnessFrogDb
    dotnet ef database update --project ../FitnessFrogDb


    dotnet ef migrations add InitialCreate --output-dir /path/to/MigrationsLibrary

    dotnet ef migrations add InitialCreate --project ../FitnessFrogDb --output-dir ../FitnessFrogMigrations


    dotnet add FitnessFrog/FitnessFrog.csproj reference DB/DB.csproj  
