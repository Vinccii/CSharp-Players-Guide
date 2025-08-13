# Chapter 11 – Looping

Dieses Kapitel aus dem **C# Player’s Guide** behandelt die Grundlagen von Schleifen in C#.  
Ich habe die enthaltenen Challenges eigenständig gelöst und dabei verschiedene Schleifentypen, Bedingungen und Konsolenausgaben geübt.

---

## 📚 Inhalte des Kapitels
- `while`-Schleifen (Bedingung am Anfang, kann auch 0-mal laufen)
- `do/while`-Schleifen (Bedingung am Ende, läuft immer mindestens 1-mal)
- `for`-Schleifen (Zähler, Start/Ende/Aktualisierung in einer Zeile)
- Verschachtelte Bedingungen in Schleifen (`if`, `else if`, `else`)
- Verwendung von `break` und `continue`
- Erkennung wiederkehrender Ereignisse mit dem Modulo-Operator `%`
- Farbige Konsolenausgabe mit `Console.ForegroundColor`

---

## 🏹 Challenge 1 – The Prototype
Ein Zahlenratespiel zwischen zwei Spielern:
- **Pilot** wählt eine Zahl zwischen 0 und 100.  
  → Eingabe wird mit einer `do/while`-Schleife validiert.  
- **Hunter** rät die Zahl, bis er richtig liegt.  
  → Implementiert mit einer `while (true)`-Schleife und `break` bei Treffer.  
- Ausgabe gibt Feedback „zu hoch“ / „zu niedrig“ / „richtig“.

**Gelernte Konzepte:**  
- Unterschied zwischen `do/while` und `while (true)`  
- Schleifensteuerung mit `break`  
- Eingabevalidierung über Bereichsprüfung

---

## 🔮 Challenge 2 – The Magic Cannon
Simuliert eine magische Kanone mit zwei Energiequellen:
- **Feuer-Edelstein**: aktiviert alle 3 Runden (`i % 3 == 0`)
- **Elektro-Edelstein**: aktiviert alle 5 Runden (`i % 5 == 0`)
- **Combined Blast**: wenn beide gleichzeitig aktiv sind (`i % 3 == 0 && i % 5 == 0`)
- Normale Runden werden als „Normal“ angezeigt.

**Zusatz:**  
- Farbige Konsolenausgabe:
  - 🔴 Rot für Fire
  - 🟡 Gelb für Electric
  - 🔵 Blau für Combined
- Schleife: `for (int i = 1; i <= 100; i++)`
- Nach jeder farbigen Ausgabe wird mit `Console.ResetColor()` zurückgesetzt.

---

## 💡 Beispielausgabe
1: Normal
2: Normal
3: Fire gem activated!
4: Normal
5: Electric gem activated!
6: Fire gem activated!
...
15: Combined blast activated!!


---

## 📈 Gelernt in diesem Kapitel
- Wahl der passenden Schleifenart für das Problem
- Strukturieren von `if/else if/else`-Blöcken
- Anwendung des Modulo-Operators für periodische Ereignisse
- Grundlegendes Arbeiten mit Konsolenfarben
- Lesbare und wartbare Code-Struktur für einfache Spiele/Simulationen

---
