using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{

    public float treeSpeed = 2.0f;

    public GameObject applePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AppleDrop", 1.0f);
 
    }

    void AppleDrop()
    {
        GameObject apple = Instantiate(applePrefab, transform);
        apple.transform.Translate(1, 0, 0);

        Invoke("AppleDrop", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(treeSpeed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "gameBox")
            treeSpeed *= -1.0f;
    }
}
