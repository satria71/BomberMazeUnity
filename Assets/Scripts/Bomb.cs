using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource explosionSound;
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit detection");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
        explosionSound.Play();
    }
}
