using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    int fuerza = 100;
    int agilidad = 50;

    int fuerzaMinima = -1;
    int agilidadMinima = 20;

    float multiplicadorDeFuerza = 2 / 5f;
    float multiplicadorDeAgilidad = 1 / 2f; 
    private void AtaqueEspecial()
    {
        bool fuerzaSuficiente = fuerza * multiplicadorDeFuerza> fuerzaMinima;
        bool agilidadSuficiente = agilidad * multiplicadorDeAgilidad > agilidadMinima;
        
        if (fuerzaSuficiente && agilidadSuficiente)
        {
            Debug.Log("Ataque especial");
        }
    }
}
