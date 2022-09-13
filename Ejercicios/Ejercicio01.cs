using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    /*---- Busca la inconcistencia del codigo ----*/
    private Rigidbody2D rb2d;

    public float speed; 

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movimiento del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb2d.velocity = new Vector2(x, y) * speed;
    }
}