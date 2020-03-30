using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCount : MonoBehaviour
{
    public Text crystalText;
    public GameObject winStage;
    private int total = 0;
    private int totalChest = 0;
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
}
