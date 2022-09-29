using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float moveSpeed = 10;
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(mousePosition.x - transform.position.x, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple")
            Destroy(collision.gameObject);
    }
}
