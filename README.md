Each folder has it own instructions

### To create project 

```
dotnet new sls -o {{name}}
cd .\{{name}\
dotnet new webapi -o {{name}}
dotnet sls add .\{{name}}\{{name}}.csproj
```