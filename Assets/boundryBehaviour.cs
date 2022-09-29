using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class boundryBehaviour : MonoBehaviour
{
    public GameObject binPrefab;

    // Start is called before the first frame update
    GameObject bin1;
    GameObject bin2;
    GameObject bin3;
    int lives = 3;
    void Start()
    {
        bin1 = Instantiate(binPrefab, transform);
        bin2 = Instantiate(binPrefab, transform);
        bin3 = Instantiate(binPrefab, transform);
        bin1.transform.Translate(0, -0.4f, 0);
        bin2.transform.Translate(0, -0.8f, 0);
        bin3.transform.Translate(0, -1.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            if (lives == 1)
            {
                Destroy(bin3.gameObject);
                lives--;
                Application.Quit();

            }
            if (lives == 2)
            {
                Destroy(bin2.gameObject);
                lives--;
            }
            if (lives == 3)
            {
                Destroy(bin1.gameObject);
                lives--;
            }

        }
            

    }
}
