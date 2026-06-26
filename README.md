# ProjectManagementXarelto

Eine einfache Anwendung zur Verwaltung von Projekten, Informationen, Tags, URLs und Kommentaren.  
Die Anwendung wurde mit **C# (.NET 8)** entwickelt und nutzt **SQLite** als lokale Datenbank.

## Verfügbare Versionen

- **Desktop-Version (WinForms)** - `master` Branch
  - Windows-Desktopanwendung
  - Entwickelt mit WinForms
  - Entwicklung mit Visual Studio empfohlen

- **Web-Version (ASP.NET Core MVC)** - `feature/web-frontend` Branch  
  - Web-basierte Anwendung
  - Moderne Browser-basierte UI
  - Entwicklung in VS Code oder Visual Studio

---

# Anforderungen

Damit die Anwendung lokal gestartet werden kann, werden folgende Komponenten benötigt:

- **Windows Betriebssystem**
- **.NET 8 Desktop Runtime**
- **Visual Studio 2022** (oder neuer) mit:
  - .NET Desktop Development Workload

Optional (für Datenbankanalyse):
- **DB Browser for SQLite**
  Download: https://sqlitebrowser.org/dl/

---

# Projektstruktur

Die Anwendung ist in vier Projekte unterteilt:

- **ProjectManagementXarelto.App**  
  Enthält die WinForms Benutzeroberfläche (Desktop-Version).

- **ProjectManagementXarelto.Web**  
  Enthält die ASP.NET Core MVC Benutzeroberfläche (Web-Version).

- **ProjectManagementXarelto.Core**  
  Enthält die Domänenmodelle und grundlegende Logik.

- **ProjectManagementXarelto.Data**  
  Enthält den Datenzugriff über Entity Framework Core sowie den DbContext.

---

# Anwendung lokal starten

## Desktop-Version (WinForms)

```bash
git checkout master
cd ProjectManagementXarelto
dotnet build
dotnet run --project ProjectManagementXarelto.App
```

## Web-Version (ASP.NET Core MVC)

```bash
git checkout feature/web-frontend
cd ProjectManagementXarelto
dotnet build
dotnet run --project ProjectManagementXarelto.Web
```

Die Web-App ist dann unter `https://localhost:5182` erreichbar (oder wie in der Ausgabe angezeigt).
