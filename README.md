# ProjectManagementXarelto

Eine einfache Windows-Desktopanwendung zur Verwaltung von Projekten, Informationen, Tags und Kommentaren.  
Die Anwendung wurde mit **C# (.NET 8)** und **WinForms** entwickelt und nutzt **SQLite** als lokale Datenbank.

---

# Anforderungen

Damit die Anwendung lokal gestartet werden kann, werden folgende Komponenten benötigt:

- **Windows Betriebssystem**
- **.NET 8 Desktop Runtime**
- **Visual Studio 2022** (oder neuer) mit:
  - .NET Desktop Development Workload

Optional (für Datenbankanalyse):
- **DB Browser for SQLite**

---

# Projektstruktur

Die Anwendung ist in drei Projekte unterteilt:

- **ProjectManagementXarelto.App**  
  Enthält die Benutzeroberfläche (WinForms).

- **ProjectManagementXarelto.Core**  
  Enthält die Domänenmodelle und grundlegende Logik.

- **ProjectManagementXarelto.Data**  
  Enthält den Datenzugriff über Entity Framework Core sowie den DbContext.

---

# Anwendung lokal starten

1. Repository klonen oder herunterladen

```bash
git clone <repository-url>
