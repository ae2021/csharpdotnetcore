﻿using System;

/*
Mehrdimensionale Arrays: Aufgabe 3
Führen Sie im Main bitte zunächst das folgende 3-Dimensionale Array ein:

    string[,,] dim3 = new string[2, 3, 4]       
{
{
{"Tabelle","Datenbank","Spalte","Zwang"},
{"zuweisen","setzen","erhalten","Liste"},
{ "Puffer","Projekt","Organisation","Interessengruppe"}
},
{
{"table","database","column","constraint"},
{"assign","set","get","list"},
{"buffer","project","organization","stakeholder"}
}
};
     HINWEISE:
Die erste Dimension zählt die Sprache (0=Deutsch, 1=Englisch)
Die Zweite Dimension zählt das Fach (0=SQL, 1=C#, 2=PM)
Die Dritte Dimension zählt die Wortnummern [0 bis 3] (Für jede Sprache und jedes Fach jeweils 4 Wörter)  

Schreiben Sie bitte das folgende C#-Programm, um den Umgang mit diesem 3-dimensionalen Array zu testen:
Das Programm besteht aus einer Endlos-Schleife, in der pro Durchlauf
Die Sprache abgefragt wird (Deutsch=1 / Englisch=2) - Wiederholung der Abfrage bei Fehleingabe
Das Fach abgefragt wird (SQL=1 / C#=2 / PM=3) - Wiederholung der Abfrage bei Fehleingabe
Die Wortnummer abgefragt wird (ein Wert zwischen 1 und 4) - Wiederholung der Abfrage bei Fehleingabe
das gewählte Wort, des gewählten Fachs in der gewählten Sprache auf der Konsole ausgegeben wird

Beispiel:
Bei der Auswahl: 1 1 1 (Deutsch, SQL, 1.Wort) kommt es zur Ausgabe von dim3[0,0,0]="Tabelle"
 
*/

namespace tag06_mehrdimensionale_arrays_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
