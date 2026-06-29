FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BlazorCrud_Proyecto01/BlazorCrud_Proyecto01.csproj", "BlazorCrud_Proyecto01/"]
RUN dotnet restore "BlazorCrud_Proyecto01/BlazorCrud_Proyecto01.csproj"
COPY . .
WORKDIR "/src/BlazorCrud_Proyecto01"

# 🔹 Crear carpeta scopedcss para evitar error
RUN mkdir -p /src/BlazorCrud_Proyecto01/obj/Debug/net7.0/scopedcss/bundle/

RUN dotnet build "BlazorCrud_Proyecto01.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BlazorCrud_Proyecto01.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorCrud_Proyecto01.dll"]
