using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    /*---- Mejor� el c�digo  ----*/

    //Dato:no se que es,pero siento que algo no esta bien.


    int fuerza = 100;
    int agilidad = 50;

        @@ -12,18 +17,18 @@ private void Start()
    {

    }
    
    private void Update()
    {

    }

    private void EjecutarAtaqueEspecial()
    {
        if ((fuerza * 2) / 5 > -1 && (agilidad / 2 > 20))

        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
}