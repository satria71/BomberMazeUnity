using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCount : MonoBehaviour
{
    public Text crystalText;
    private int total = 0;
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
    }

    private void UpdateCrystalText()
    {
        string msg = "" + total;
        crystalText.text = msg;
    }
}
