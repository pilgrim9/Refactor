using System;
using UnityEngine;
using System.Linq;

public class Ejercicio04 : MonoBehaviour
{
    string[] tiposDeEnemigo = new string[] {
        "Araña",
        "Lobo",
        "Orco"
    };
    string BuscarEnemigos(string[] enemigos)
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (this.tiposDeEnemigo.Contains<string>(enemigos[i]))
            {
                return enemigos[i];
            }
        }
        return String.Empty;
    }
}
