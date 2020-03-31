using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrystalCount : MonoBehaviour
{
    public Text crystalText;
    public GameObject winStage;
    private int total = 0;
    private int totalChest = 0;
    public AudioSource coinSound;
    void Start()
    {
        UpdateCrystalText();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Crystal"))
        {
            total++;
            UpdateCrystalText();
            Destroy(hit.gameObject);
            coinSound.Play();
        }
        else if (hit.CompareTag("Chest"))
        {
            winStage.SetActive(true);
            Destroy(hit.gameObject);
            gameObject.SetActive(false);
        }
    }

    private void UpdateCrystalText()
    {
        string msg = "" + total;
        crystalText.text = msg;

        if (total == 1)
        {
            winStage.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void stage2(){
        SceneManager.LoadScene("Stage2");
    }
}
