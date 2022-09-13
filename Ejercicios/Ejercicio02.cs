using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    /*---- Mejorar el c�digo  ----*/
    
    int strength = 100;
    int agility = 50;
    public float strengthMultiplier = 2 / 5f;
    public float strengthThreshold = -1;
    public float agilityMultiplier = 1 / 2f;
    public float agilityThreshold = 20;
    
    private void ExecuteSpecialAttack()
    {
        if (strength * strengthMultiplier > strengthThreshold && agility * agilityMultiplier > agilityThreshold)
        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
    
}