# Recruitment Task - E-commerce API

## Opis projektu
Web API do zarządzania zamówieniami zbudowane w .NET 8, Entity Framework Core i SQL Server.

## Proces CI/CD
W projekcie skonfigurowano **GitHub Actions**:
1. **Build**: Po każdym wypchnięciu kodu (`push`) na gałąź `main`, automat sprawdza, czy kod poprawnie się buduje i przywraca pakiety NuGet.
2. **Wdrożenie**: (To dodamy w kolejnym kroku po konfiguracji Azure).