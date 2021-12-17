using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movbala : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;



    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector3.up * 6f * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("Death");
        }

        //Destruyo la bala, independientemente de con quién ha chocado
        Destroy(gameObject);
    }


}
