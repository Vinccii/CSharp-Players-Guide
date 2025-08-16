# Chapter 12 – Arrays

Dieses Kapitel aus dem **C# Player’s Guide** behandelt die Grundlagen von Arrays in C#.  
Ich habe die enthaltenen Challenges eigenständig gelöst und dabei die Arbeit mit eindimensionalen, mehrdimensionalen und jagged Arrays geübt.  

---

## 📚 Inhalte des Kapitels
- Deklaration und Initialisierung von Arrays (`int[] numbers = new int[5];`)
- Zugriff auf Elemente per Index (`array[0]`, `array[^1]`)
- Standardwerte (0, `false`, `null`)
- Arbeiten mit `.Length`, um die Arraygröße dynamisch zu nutzen
- Ranges & Index from End (`array[1..3]`, `array[^1]`)
- Schleifen mit Arrays: `for` vs. `foreach`
- Jagged Arrays (`int[][]`) vs. rechteckige Arrays (`int[,]`)
- Iteration über mehrdimensionale Arrays mit `GetLength(dimension)`

---

## 🏹 Challenge 1 – The Replicator of D’To
Ein Programm, das den mythischen **Replikator von D’To** repariert:
- Erstellt ein Array der Länge 5.  
- Fragt den Benutzer nach 5 Zahlen und speichert sie im Array.  
- Erstellt ein zweites Array und kopiert die Werte per Schleife hinein.  
- Gibt beide Arrays aus, um die Replikation zu demonstrieren.

**Gelernte Konzepte:**  
- Benutzereingaben in Arrays speichern  
- Arrays mit einer Schleife kopieren  
- Strukturierte Konsolenausgabe mehrerer Arrays  

---

## 🔮 Challenge 2 – The Laws of Freach
Die Stadt **Freach** erlaubt nur noch `foreach`-Schleifen.  
Aufgabe: Bestehenden `for`-basierten Code so umschreiben, dass er mit `foreach` funktioniert.

- **Minimum-Wert** im Array finden mit `foreach`  
- **Durchschnittswert** im Array berechnen mit `foreach`  

**Gelernte Konzepte:**  
- Iteration über Arrays mit `foreach`  
- Minimum-Berechnung ohne Indexzugriff  
- Durchschnitt = Summe aller Werte ÷ Anzahl der Elemente  

---

## 💡 Beispielausgabe
Original array: 4, 51, -7, 13, -99, 15, -8, 45, 90
Minimum value: -99
Average value: 1.5

---

## 📈 Gelernt in diesem Kapitel
- Arrays sind Container für mehrere Werte eines Typs  
- Unterschied `for` vs. `foreach`  
- Umgang mit Index-Operatoren (`[i]`, `[^1]`, `[start..end]`)  
- Unterschied zwischen jagged Arrays und rechteckigen Arrays  
- Iteration über mehrdimensionale Arrays mit `GetLength()`  
