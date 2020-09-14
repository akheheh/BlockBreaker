using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceScript : MonoBehaviour
{
    [SerializeField] AudioClip soundSource;
    private void OnCollisionEnter2D(Collision2D obj) {
        GetComponent<AudioSource>().PlayOneShot(soundSource);
    }
}
