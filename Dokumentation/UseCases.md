# Use Cases – ProjectManagementXarelto

## UC-01 Rolle wählen (Login)

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Benutzer startet die Anwendung und wählt eine Rolle.

**Ablauf:**

1. Anwendung starten.
2. Benutzer klickt auf „Als Projektleiter“ oder „Als Projektmanager“.
3. System setzt den aktuellen Benutzer im `SessionContext`.
4. Projektübersicht wird geöffnet.

---

## UC-02 Projektübersicht anzeigen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Anzeige aller vorhandenen Projekte.

**Ablauf:**

1. System lädt alle Projekte aus der Datenbank.
2. Anzeige im `DataGridView` mit:

   * Projektname
   * Kunde
   * Projektleiter
   * Erstellungsdatum

---

## UC-03 Projekt öffnen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Benutzer öffnet ein Projekt aus der Liste.

**Ablauf:**

1. Benutzer doppelklickt ein Projekt.
2. System öffnet `ProjectDetailsForm`.
3. System zeigt Projektdetails und Informationsliste.

---

## UC-04 Projekt erstellen

**Akteure:** Projektleiter
**Beschreibung:** Neuer Projekt-Eintrag wird erstellt.

**Ablauf:**

1. Projektleiter klickt „Neues Projekt“.
2. Benutzer gibt ein:

   * Projektname
   * Kunde
   * Projektbeschreibung
3. System speichert das Projekt.

**Regeln:**

* Nur Projektleiter dürfen Projekte erstellen.
* Projekte sind nach Erstellung nicht editierbar.

---

## UC-05 Projektinformationen anzeigen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Anzeige der Projektdetails.

**Anzeige:**

* Projektname
* Kunde
* Projektleiter
* Projektbeschreibung (readonly)

---

## UC-06 Information erstellen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Neue Information zu einem Projekt hinzufügen.

**Ablauf:**

1. Benutzer klickt „Neue Information“.
2. Benutzer gibt Informationstext ein.
3. System speichert Information.

---

## UC-07 Informationsliste anzeigen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Anzeige aller Informationen eines Projekts.

**Anzeigeformat:**

```
Informationstext (Datum) [Tags]
```

---

## UC-08 Informationen nach Tag filtern

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Filterung der Informationsliste.

**Ablauf:**

1. Benutzer gibt Tag in Suchfeld ein.
2. Klick auf „Filter anwenden“.
3. System zeigt nur Informationen mit diesem Tag.

---

## UC-09 Information bearbeiten

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Bestehende Information bearbeiten.

**Ablauf:**

1. Benutzer doppelklickt Information.
2. `InformationEditForm` öffnet sich.
3. Benutzer ändert Text.
4. System speichert Änderungen.

---

## UC-10 Tags verwalten

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Tags zu einer Information hinzufügen oder entfernen.

**Regeln:**

* Maximal 3 Tags pro Information.
* Keine Duplikate erlaubt.

---

## UC-11 Links hinzufügen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Links zu einer Information hinzufügen.

**Linktypen:**

* Image
* Document

**Anzeigeformat:**

```
Image: https://example.com
Document: https://example.com
```

---

## UC-12 Link öffnen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Öffnen eines Links im Browser.

**Ablauf:**

1. Benutzer doppelklickt Link.
2. System öffnet URL im Standardbrowser.

---

## UC-13 Kommentare erstellen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Kommentar zu einer Information hinzufügen.

**Ablauf:**

1. Benutzer schreibt Kommentar.
2. Klick auf „Kommentar hinzufügen“.
3. System speichert Kommentar.

**Regeln:**

* Kommentare sind nach Erstellung nicht editierbar.

---

## UC-14 Kommentare anzeigen

**Akteure:** Projektleiter, Projektmanager
**Beschreibung:** Anzeige aller Kommentare einer Information.

**Anzeigeformat:**

```
Datum - Kommentartext
```

---

## UC-15 Datenbankinitialisierung

**Beschreibung:** Automatische Initialisierung beim Start.

**Ablauf:**

1. System führt EF Core Migration aus.
2. Standardbenutzer werden erstellt:

   * Projektleiter
   * Projektmanager
