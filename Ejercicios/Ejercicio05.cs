using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string Acci�n = "Attack";
    int Habilidad = 1;

    void EjecutarAcci�n()
    {
        switch (Habilidad)
        {
            case 1:
                if(Acci�n == "Heal")
                    Debug.Log("Me cur�");
                break;
            case 2:
                if (Acci�n == "Attack")
                    Debug.Log("Hago da�o");
                break;
            case 3:
                if (Acci�n == "Special Attack")
                    Debug.Log("Empiezo a girar como trompo");
                break;

        }
    }
}
}