using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/
    

    public List<string> enemigos = new List<string>() { "Orc","Spider","Golem","Goblin"};
    string enemigo = "Spider";

    string FindEnemy()
    {
        return enemigos.Contains(enemigo) ? "Se encontro " + enemigo : "No se encontro";
    }
}