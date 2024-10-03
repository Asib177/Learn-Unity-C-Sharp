using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject);
        //Destroy(gameObject, 3f);
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }*/
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500);
        }*/
        //rb.velocity = Vector3.forward * 20f;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2");
        }
    }

    /*private void OnMouseDown()
    {
        Destroy(gameObject);
    }*/

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }*/
}
