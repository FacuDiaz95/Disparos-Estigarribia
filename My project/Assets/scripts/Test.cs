using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject objetoAInstanciar;

    public Transform lugar;

    public float playerSpedd = 2f;

    public float scaleSpeed = 2f;

    public Vector3 position;

    public Vector3 scale;


    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
    transform.position += position * playerSpedd;

    transform.localScale += scale * scaleSpeed;

    if (Input.GetKeyDown(KeyCode.K))
    {
            Shoot();
    }
    }

    void Shoot()
    {
        Instantiate(objetoAInstanciar,lugar.position,transform.rotation);
    }

}
