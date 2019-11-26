﻿using System;
/*
Aufgabe Struktur 2
Führen Sie bitte zunächst ein Enum namens "Sonderfall" mit den Konstanten
personExistiertNicht(=-2) und
personHatKeinAuto ein

Führen Sie bitte ferner die beiden folgenden Strukturen ein:
       a) Person
            Strukturkomponenten:
                - id
                - vorname
                - nachname
       b) Auto
            Strukturkomponenten:
                - marke
                - kennzeichen
                - baujahr
                - besitzer (Typ Person)

 Definieren Sie bitte im Main eine Liste vom Typ Person und eine Liste vom Typ Auto

 Führen Sie bitte des weiteren die drei folgenden Methoden ein:
        a) Methodenname:  FüllePerson
           Übergabewerte: 1 Referenz auf eine Strukturvariable vom Typ Person, Integer id, 
Strings vorname und nachname
           Funktion:      Füllt alle Strukturkomponenten der referenzierten Strukturvariable
           Rückgabewert:  Keiner
        b) Methodenname:  FülleAuto
           Übergabewerte: 1 Referenz auf eine Strukturvariable vom Typ Auto, Strings marke 
und kennzeichen, int baujahr, Person besitzer
           Funktion:      Füllt alle Strukturkomponenten der referenzierten Strukturvariable
           Rückgabewert:  Keiner
        c) Methodenname: 
     SELECT_minBaujahr_FROM_Auto_JOIN_Person_WHERE_besitzerID_EQUAL_x
           Übergabewerte: Liste vom Typ Person, Liste vom Typ Auto, int x
           Funktion:      Ermittelt das älteste Baujahr aller Autos der Person mit ID x
           Rückgabewert:  Falls Person mit ID x existiert und ein Auto besitzt: ältestes Baujahr
                    Falls Person mit ID x NICHT existiert: die erste Konstante aus dem 
Enum Sonderfall
                          Falls Person mit ID x existiert ABER KEIN Auto besitzt: die zweite 
Konstante aus dem Enum Sonderfall
 
Test im Main:

Zunächst werden folgende Personen und Autos eingeführt (und zu den entsprechenden Listen hinzugefügt)
            Person mit ID 1: "Hans", "Müller"
                seine Autos: "Renault", "W-Te 21", 1975
                             "Skoda", "W-LK 1937", 2015
            Person mit ID 2: "Klaus", "Schmidt"
                  sein Auto: "Volkswagen", "W-PA 1966", 2000
            Person mit ID 3: "Peter", "Mayer"
                  KEIN Auto
                  
Lassen Sie anschließend bitte eine for Schleife für die Zähler-Werte x=0 bis x=3 durchlaufen:
Pro Durchlauf soll die Methode "SELECT_minBaujahr_FROM_Auto_JOIN_Person_WHERE_besitzerID_EQUAL_x" mit geeigneten übergabewerten aufgerufen werden
Deren Rückgabewert soll in einer switch-case-Verzeigung mit Hilfe der  Enum-Konstanten ausgewertet werden.
           Insbesondere sollen die drei folgenden Fälle unterschieden werden:
Person mit ID=x nicht gefunden
Person mit ID=x besitzt kein Auto
Ausgabe des ältesten Baujahrs aller Autos der Person mit ID=x

HINWEIS:
Wenn Sie überprüfen wollen, ob zwei Strukturvariablen identisch sind, können Sie NICHT auf den ==-Operator zurückgreifen
stattdessen müssen Sie die Methode Equals() verwenden - hierzu ein Beispiel:
     p1 und p2 seien 2 Strukturvariablen vom Typ Person, dann können Sie mit
p1.Equals(p2) deren Identität überprüfen

*/

namespace tag10_struct_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
