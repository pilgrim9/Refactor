using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public float fuerza = 100f;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        Vector2 velocidad = new Vector2(x, y);

        rb2d.AddForce(velocidad * fuerza * Time.deltaTime);
    }
}
