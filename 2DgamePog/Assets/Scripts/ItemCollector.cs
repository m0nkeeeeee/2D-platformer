using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{

    private int bnan = 0;

    [SerializeField] private TMP_Text BnansText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bnan"))
        {
            Destroy(collision.gameObject);
            bnan++;
            BnansText.text = "bnans: " + bnan;
        }
    }
    
}
