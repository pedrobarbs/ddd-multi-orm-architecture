# Semantic multi-orm architecture
A very understandable and intuitive approach that describes a decoupled solution using DDD, Entity Framework, Dapper and IoC. 

Powered by .NET Core 2.2

## Set-up

1. Define 'SemanticAchitecture.Presentation' and 'SemanticAchitecture.API' as startup projects.
2. In each of those projects, configure your connection string at 'appsettings.json'.
3. In order to generate a code-first database, execute the following instructions at the 'nugget package manager console'.
    1. Target project 'SemanticArchitecture.DataAccess.EntityFramework'.
    2. Execute 'add-migration migration'.
    3. Execute 'update-database'.
4. Enjoy it! ;)
