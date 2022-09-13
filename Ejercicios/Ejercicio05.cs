using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    [Range(1, 20)]
    [SerializeField]
    int critChance;

    [Range(1, 20)]
    [SerializeField]
    int critThreshold = 15;

    public bool CalculateCrit()
    {
        int result = Random.Range(0, critChance);
        return result >= critThreshold;
    }
}
