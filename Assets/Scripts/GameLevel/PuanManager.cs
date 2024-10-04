using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuanManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text puanText;

    public int puan;
    void Start()
    {
        puanText.text = puan.ToString();
    }

    

    
}
