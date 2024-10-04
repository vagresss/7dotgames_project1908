using System.Collections;
using System.Collections.Generic;
using DG.Tweening.Core.Easing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerManager : MonoBehaviour
{

    [SerializeField]
    public int kalanSure;

    [SerializeField]
    private TMP_Text sureText;

    [SerializeField]
    private bool sureBuyukSifir;

    GameManager gameManager;


    void Start()
    {
        kalanSure = 90;
        sureBuyukSifir = true;
        gameManager = Object.FindObjectOfType<GameManager>();


    }

    public void SureyiBaslat()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {

        
            sureText.text = kalanSure.ToString();
            while (sureBuyukSifir)
            {
                yield return new WaitForSeconds(1f);

                if (kalanSure < 10)
                {
                    sureText.text = "0" + kalanSure.ToString();
                }
                else
                {
                    sureText.text = kalanSure.ToString();
                }

                if (kalanSure <= 0)
                {
                    sureText.text = "00";
                    sureBuyukSifir = false;
                    gameManager.SureBitis();
                }

                kalanSure -= 1;


            }
        

    }
    
}
