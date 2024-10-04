using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.Audio;

public class GeriSayimManager : MonoBehaviour
{
    [SerializeField]
    private GameObject GeriSayimObje;

    [SerializeField]
    private TMP_Text GeriSayimText;

    GameManager gameManager,gameManager2; //GameManager Script dosyas�na ula�mak i�in bu de�i�keni olu�turduk.

    [SerializeField]
    public bool oyunBasla;



    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>(); //gameManager de�i�kenine GameManager script dosyas�n� att�k. B�ylece GameManager Script dosyas�ndaki de�i�ken ve fonksiyonlara ula�abilece�iz.
        oyunBasla = false;
        gameManager2 = GetComponent<GameManager>();
    }

    void Start()
    {
        StartCoroutine(GeriSayimRoutine());
    }


    IEnumerator GeriSayimRoutine()
    {
        GeriSayimText.text = "3";
       // gameManager2.audioSource.PlayOneShot(gameManager2.geriSayimSesi);
        yield return new WaitForSeconds(0.5f);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(1f, 0.5f);
        yield return new WaitForSeconds(0.7f);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);

       
        
        GeriSayimText.text = "2";
        //gameManager2.audioSource.PlayOneShot(gameManager2.geriSayimSesi);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(1f, 0.5f);
        yield return new WaitForSeconds(0.7f);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);

        
        
        GeriSayimText.text = "1";
       // gameManager2.audioSource.PlayOneShot(gameManager2.geriSayimSesi);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(1f, 0.5f);
        yield return new WaitForSeconds(0.7f);
        GeriSayimObje.GetComponent<RectTransform>().DOScale(0f, 0.5f);

        StopAllCoroutines();
        oyunBasla = true;
        gameManager.OyunaBasla();




    }
    
}
