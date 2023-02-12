Each folder has it own instructions

### To create project in .Net

```
dotnet new sln -o {{name}}
cd .\{{name}\
dotnet new webapi -o {{name}}
dotnet sln add .\{{name}}\{{name}}.csproj
```

### Add Migration
```
Windows: add-migration {{name}}
Linux: dotnet ef migrations add {{name}}
```

### Run migrations
```
Terminal: dotnet ef database update
```

### To add seed
```
Terminal: dotnet ef migrations add {{seed-name}}
```

### Commnets
sln -> solution

### Repositório base
https://github.com/leandrocgsi/erudio-microservices-dotnet6