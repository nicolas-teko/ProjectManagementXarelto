\# ADR 0001 – Architektur \& technische Basis (MVP)



\*\*Status:\*\* Accepted  

\*\*Datum:\*\* 2026-02-15  

\*\*Projekt:\*\* ProjectManagementXarelto  



\## Kontext



Es soll eine einfache, lokal laufende Windows-Desktop-Anwendung zur Verwaltung von Projekten, Informationselementen und Kommentaren entstehen. Die Lösung soll bewusst minimal und nicht overengineered sein, aber strukturell sauber aufgebaut werden.



---



\## Entscheidungen



\### 1. UI-Technologie

\*\*WinForms (.NET 8)\*\*  

Begründung: Schnellste und einfachste Lösung für eine reine Windows-Desktop-Anwendung.



\### 2. Solution-Struktur

Drei Projekte innerhalb einer Solution:

\- `ProjectManagementXarelto.App` → UI (WinForms)

\- `ProjectManagementXarelto.Core` → Modelle \& Businesslogik

\- `ProjectManagementXarelto.Data` → EF Core \& Persistenz



Ziel: Klare Trennung von UI, Domäne und Datenzugriff.



\### 3. Datenbank

\*\*SQLite + Entity Framework Core\*\*



\- Filebasierte DB

\- Keine Serverinstallation

\- Nutzung von EF Core Migrations

\- Design-Time Factory für Migration-Support



\### 4. Authentifizierung (MVP)

Kein echtes Login.  

Zwei vordefinierte Benutzer (Projektleiter / Projektmanager) werden per Seed erzeugt. Rollen steuern die Berechtigungen.



\### 5. Berechtigungsmodell

\- Projekt erstellen → nur Projektleiter

\- Information erstellen/bearbeiten → Projektleiter \& Projektmanager

\- Kommentar erstellen → Projektleiter \& Projektmanager

\- Projekte und Kommentare sind nach Erstellung nicht editierbar

\- Informationen sind editierbar



\### 6. Datenhaltung

\- Normalisierte Tabellenstruktur

\- Tags und Links als eigene Entitäten

\- Cascade-Delete für abhängige Entitäten

\- Unique-Constraint für Tags pro Information



\### 7. Versionsverwaltung

\- Git-Repository direkt aus Visual Studio

\- Standard VisualStudio `.gitignore`

\- Ergänzung: `\*.db` wird ignoriert



---



\## Konsequenzen



\- Schnelle MVP-Umsetzung mit klarer Struktur

\- Erweiterbar ohne Architekturbruch

\- Keine unnötige Komplexität (kein echtes Auth-System, kein Server)

