# Chapter 13 – Methods

Dieses Kapitel aus dem **C# Player’s Guide** behandelt die Grundlagen von **Methoden** in C#.  
Ich habe die enthaltenen Konzepte und Challenges eigenständig erarbeitet und dabei rekursive und wiederverwendbare Methoden implementiert.

---

## 📚 Inhalte des Kapitels
- Definition von Methoden (`void`, Rückgabetypen, Parameter)
- Lokale Funktionen innerhalb von `Main`
- Methodenaufrufe & Scope (eigene Variablen pro Methode)
- Parameter & Argumente (Daten in eine Methode geben)
- Rückgabewerte (Daten aus einer Methode zurückgeben)
- Mehrere Parameter & Kopieren von Werten
- Method Overloading (Überladen von Methoden mit unterschiedlichen Parametern)
- Expression-Bodied Methods (`=>`-Syntax für kurze Methoden)
- XML-Dokumentationskommentare (`/// <summary> ... </summary>`)
- Rekursion (Methoden, die sich selbst aufrufen)

---

## 🏹 Challenges

### 🎯 Taking a Number (100 XP)
- Ziel: Eine Methode `AskForNumber(string text)` schreiben, die Eingabe vom Benutzer liest, konvertiert und zurückgibt.  
- Erweiterung: `AskForNumberInRange(string text, int min, int max)` mit Eingabevalidierung.  
- Anwendung in einem kleinen Ratespiel (User 1 denkt sich eine Zahl, User 2 rät).

### 🎯 Countdown (100 XP)
- Ziel: Eine Schleife durch Rekursion ersetzen.  
- Rekursive Methode, die von 10 bis 1 herunterzählt.  
- Einführung in **Base Case** und rekursiven Aufruf.

---

## ✅ Gelerntes
- Methoden helfen, Code **aufzuräumen**, **wiederzuverwenden** und besser zu strukturieren.  
- Parameter und Rückgabewerte machen Methoden flexibel.  
- Methoden können überladen werden (gleicher Name, andere Parameterliste).  
- Expression-Bodied Methods sind eine elegante Kurzschreibweise.  
- Mit XML-Dokumentation lassen sich Methoden direkt im Code dokumentieren.  
- Rekursion ist mächtig, aber erfordert einen **Base Case** und Vorsicht.

---

## 🖥 Beispielcode: Countdown (rekursiv)
```csharp
static void DoCountdown(int number)
{
    if (number == 0) return;      // Base Case
    Console.WriteLine(number);    // Ausgabe
    DoCountdown(number - 1);      // Rekursiver Schritt
}
