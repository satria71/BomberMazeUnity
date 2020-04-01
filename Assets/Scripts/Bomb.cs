using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource explosionSound;
    public GameObject gameOver;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detection");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
        explosionSound.Play();
        gameOver.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
