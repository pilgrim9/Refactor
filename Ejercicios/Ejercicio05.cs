using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    public enum Actions
    {
        Heal,
        Attack,
        SpecialAttack
    }

    public Actions action;
    void ExecuteAction()
    {
        if (action == Actions.Heal) Debug.Log("Me cur�");
        if (action == Actions.Attack) Debug.Log("Hago da�o");
        if (action == Actions.SpecialAttack) Debug.Log("Empiezo a girar como trompo");
    }
}