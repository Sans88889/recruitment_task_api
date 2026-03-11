# Recruitment Task - E-commerce API

Projekt zrealizowany zgodnie z wymaganiami rekrutacyjnymi: asynchroniczne Web API, CI/CD oraz wdrożenie w chmurze Azure.

## Link do wdrożonej aplikacji (Część 3)
Aplikacja jest dostępna publicznie. Można ją przetestować przez interfejs Swagger:
[Interfejs Swagger w Azure](https://recruitment-api-sandra-grdygqc7btf6bbek.polandcentral-01.azurewebsites.net/swagger/index.html)

## Technologie i realizacja zadań
- **Część 1 (API)**: .NET 8, EF Core, asynchroniczne endpointy, relacja wiele-do-wielu (Order <-> Product).
- **Część 2 (CI/CD)**: Wykorzystano **GitHub Actions**. Każdy push na gałąź `main` uruchamia automatyczne budowanie projektu.
- **Część 3 (Azure)**: Aplikacja hostowana na **Azure App Service** (Linux).
- **Część 4 (Bicep)**: Infrastruktura została zdefiniowana w pliku `main.bicep` znajdującym się w głównym folderze repozytorium.

## Infrastruktura jako Kod (Punkt 4)
Plik `main.bicep` definiuje:
- Azure App Service Plan (warstwa S1/F1).
- Azure Web App.
Dzięki temu całe środowisko można odtworzyć jednym poleceniem.

---
*Uwaga: Swagger został skonfigurowany tak, aby był dostępny również w środowisku produkcyjnym na potrzeby ułatwienia weryfikacji zadania.*
