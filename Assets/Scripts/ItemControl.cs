using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    [SerializeField] float speed = 4;
    [SerializeField] bool isDynamite = false;

    Rigidbody2D myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        Spawn();
    }

    void Spawn()
    {
        transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        myRigidbody.velocity = Random.insideUnitCircle.normalized * speed;
    }

    private void OnMouseDown()
    {
        if(isDynamite)
        {
            //game over
        }
        else
        {
            //add points
            Spawn();
        }
    }
}
