using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationdoor : MonoBehaviour
{

    public float speed;
    public Quaternion ouvre;
    Quaternion ferme;
    float step;

    public bool etat;
    // Start is called before the first frame update
    void Start()
    {
        ferme = this.transform.rotation;
        etat = true;
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime; // calculate distance to move

        if (etat)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, ferme, step);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, ouvre, step); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            etat = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            etat = true;
        }
    }
}



