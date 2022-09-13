using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    int endurance;
    int life;

    int minEndurance = 5;
    int damageReduction = 2;

    void TakeDamage(int damage)
    {
        if (endurance > minEndurance)
        {
            damage -= damageReduction;
        }
        life -= damage;
    }
}
