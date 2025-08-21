using System;

namespace CsharpPlayersGuide.Chapter13_Methods
{
    public static class Countdown
    {
        public static void Run()
        {
            // starte den Countdown bei 10
            Countdown(10);
        }
        
        static void Countdown(int number)
        {
            // base Case: Wenn die Zahl bei 0 ist, soll die Methode aufhören

            // Gibt die aktuelle Zahl auf der Konsole aus

            // Rekursiver Aufruf: Ruf Countdown nochmal mit (nummber -1) auf
        }
    }
}
