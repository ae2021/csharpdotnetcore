﻿using System;
/*
Arrays: Aufgabe 3
AUFGABENSTELLUNG ("große Straße" beim Kniffel-Spiel)

Führen Sie bitte zunächst im Main ein Integer-Array der Länge 5 ein  
Schreiben Sie anschließend bitte die beiden folgenden Methoden:
Funktionsname: fülleWürfelArray
Übergabewerte: 1 Referenz auf ein Integer-Array 'arr'
        2 Integer 'min' und 'max'
Funktion:      Die Methode füllt das Array arr mit Zufallszahlen zwischen 
    (beiderseits einschließlich) min und max
    (HINWEIS: Länge des Arrays = arr.Length)
Rückgabewert:  Keiner
Funktionsname: ausgabeWürfelArray
Übergabewerte: 1 Integer-Array 'arr' (Value KEINE Referenz!)
Funktion:      Ausgabe aller Arrayfeld-Werte (also für alle Indices zwischen 0 und arr.Length) auf der Konsole          
Rückgabewert:  Keiner
Verwenden Sie bitte die beiden obigen Methoden in folgendem C#-Programm - für dieses Programm soll gelten:
Das Programm startet eine Schleife, pro Durchlauf
wird ein Array der Länge 5 mit Zufalls-Würfelzahlen gefüllt
wird das gefüllte Array (numerisch) sortiert
wird überprüft, ob es sich um eine "große Straße" handelt (1,2,3,4,5) oder (2,3,4,5,6)
Die Schleife endet, falls eine "große Straße" gewürfelt wurde
Das Programm endet mit der Ausgabe der Anzahl der Schleifen-Durchläufe, die nötig waren, um die "große Straße" zu erreichen

*/

namespace tag06_arrays_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
