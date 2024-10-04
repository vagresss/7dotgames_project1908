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

    GameManager gameManager,gameManager2; //GameManager Script dosyasýna ulaþmak için bu deðiþkeni oluþturduk.

    [SerializeField]
    public bool oyunBasla;



    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>(); //gameManager deðiþkenine GameManager script dosyasýný attýk. Böylece GameManager Script dosyasýndaki deðiþken ve fonksiyonlara ulaþabileceðiz.
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
