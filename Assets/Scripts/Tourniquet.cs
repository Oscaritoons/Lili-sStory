using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoSon : MonoBehaviour
{

    public bool etat;
    public Quaternion ouvre;
    Quaternion ferme;
    float step;
    AudioSource MyAudioSource;
    public AudioClip SoundOpen;

    public BoxCollider ColliderTourniquet;

    // Start is called before the first frame update
    void Start()
    {
        ferme = this.transform.rotation;
        etat = true;
        ColliderTourniquet = true;
        MyAudioSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update()
    {
        if (etat)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, ferme, step);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, ouvre, step);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                etat = !etat;
                MyAudioSource.clip = SoundOpen;
                MyAudioSource.Play();

                ColliderTourniquet = false;
            }

        }
    }
}
