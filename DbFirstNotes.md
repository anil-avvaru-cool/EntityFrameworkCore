## Entity framework powershell Commands

ConnString example:
"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;"
"Data Source=anil-avvaru-pc;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;Encrypt=False"
Powershell:

**With DataAnnotations:**

Scaffold-DBContext connString Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation

**With Directories:**

Scaffold-DBContext connString Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models/Generated -DataAnnotation -ContextNamespace ContossoPizza.Data -Namespace ContosoPizza.Models

### Dotnet ef commands

dotnet ef dbcontext scaffold connString Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models
