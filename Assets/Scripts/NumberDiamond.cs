using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberDiamond : MonoBehaviour
{
    private TextMeshProUGUI text;


    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetText()
    {
        text.text = "0";
    }
}
