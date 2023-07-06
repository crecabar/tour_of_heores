# Imagen base para la compilación del proyecto
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Establecer el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiar los archivos necesarios para restaurar las dependencias
COPY ProyectoBackend.csproj ./
RUN dotnet restore

# Copiar todo el código fuente y compilar la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Imagen base para el runtime de .NET Core
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Establecer el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiar los archivos publicados desde la etapa de compilación
COPY --from=build-env /app/out .

# Exponer el puerto en el que se ejecutará la aplicación
EXPOSE 80

# Especificar el comando de inicio de la aplicación
ENTRYPOINT ["dotnet", "ProyectoBackend.dll"]
