Each folder has it own instructions

### To create project 

```
dotnet new sln -o {{name}}
cd .\{{name}\
dotnet new webapi -o {{name}}
dotnet sln add .\{{name}}\{{name}}.csproj
```