//using System;

//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:




//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati
//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.

using System.Collections.Concurrent;

void StampaArray(int[] array)
{
    Console.Write("Array: [");
    foreach (var item in array)
    {
        Console.Write($" {item} ");
        if (item != array.Last())
        {
            Console.Write("-");
        }
    }
    Console.WriteLine("]");
}

int Quadrato(int num)
{
    return (int)Math.Pow(num, 2);
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] tempArray = (int[])array.Clone();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Quadrato(tempArray[i]);
    }
    return tempArray;
}

int sommaElementiArray(int[] array)
{
    int somma = 0;
    foreach (var item in array)
    {
        somma += item;
    }

    return somma;
}

int[] array = { 2, 6, 7, 5, 3, 9 };

StampaArray(array);
StampaArray(ElevaArrayAlQuadrato(array));
StampaArray(array);
Console.WriteLine(sommaElementiArray(array));
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(array)));
