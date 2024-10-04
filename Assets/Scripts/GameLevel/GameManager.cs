using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject ustPanel;
    [SerializeField]
    private GameObject altYazi;

    [SerializeField]
    private GameObject ustDikdortgen;

    [SerializeField]
    private GameObject altDikdortgen;

    [SerializeField]
    private TMP_Text ustText, altText;

    [SerializeField]
    TimerManager timerManager;
    DaireManager daireManager;
    TimerManager timerManager2;
    GeriSayimManager geriSayimManager;
    TrueFalseManager trueFalseManager;

    [SerializeField]
    private GameObject SureyiBaslatPuanlariKapText;

    [SerializeField]
   public int zorlukSeviyeBelirleme, zorlukSeviye, kacinciSoru;

    [SerializeField]
    int ustDeger, altDeger, buyukDeger, butonDeger;

    [SerializeField]
    private TMP_Text cezaSureText;

    [SerializeField]
    int cezaSure;

    [SerializeField]
    private int buyukDegerBelirleme;

    [SerializeField]
    private TMP_Text puanText;
    [SerializeField]
    private int puan;

    [SerializeField]
    private TMP_Text sonucText;

    [SerializeField]
    private GameObject sonucPanel;

    [SerializeField]
    private GameObject ustCevapPanel, altCevapPanel;

    [SerializeField]
    private GameObject buyukOlanýSec;

    public AudioSource audioSource;

    public AudioClip dogruSesi, geriSayimSesi, yanlisSesi, baslangicSesi, bitisSesi;

    [SerializeField]
    private GameObject pausePanel;



    private void Awake()
    {
        timerManager = Object.FindObjectOfType<TimerManager>();
        daireManager = Object.FindObjectOfType<DaireManager>();
        timerManager2 = GetComponent<TimerManager>();
        geriSayimManager = GetComponent<GeriSayimManager>();
        trueFalseManager = Object.FindObjectOfType<TrueFalseManager>();
        audioSource = GetComponent<AudioSource>();


    }

    void Start()
    {
        ustText.text = "";
        altText.text = "";
        zorlukSeviyeBelirleme = 0;
        zorlukSeviye = 0;
        kacinciSoru = 0;

        

        gameScreen();
    }

    void gameScreen()
    {
        ustPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altYazi.GetComponent<CanvasGroup>().DOFade(1, 1f);
        ustDikdortgen.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f);
        altDikdortgen.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f);
    }

    public void OyunaBasla()
    {
        audioSource.PlayOneShot(baslangicSesi);

        timerManager.SureyiBaslat();
        SureyiBaslatPuanlariKapText.SetActive(false);
        buyukOlanýSec.SetActive(true);
        SoruZorluk();
        
    }

    void SoruZorluk()
    {
        if (zorlukSeviyeBelirleme == 0)
        {
            zorlukSeviye = 1;
        } else if(zorlukSeviyeBelirleme == 1)
        {
            zorlukSeviye = 2;
        }
        else if (zorlukSeviyeBelirleme == 2)
        {
            zorlukSeviye = 3;
        }
        else if (zorlukSeviyeBelirleme == 3)
        {
            zorlukSeviye = 4;
        }else if(zorlukSeviyeBelirleme == 4)
        {
            zorlukSeviye = 5;
        }
        else if (zorlukSeviyeBelirleme == 5)
        {
            zorlukSeviye = 6;
        }
        else if (zorlukSeviyeBelirleme == 6)
        {
            zorlukSeviye = 7;
        }
        else if (zorlukSeviyeBelirleme == 7)
        {
            zorlukSeviye = 8;
        }
        else
        {
            zorlukSeviye = Random.Range(5, 9);
        }
        switch (zorlukSeviye)
        {
            case 1: 
                BirinciSeviye();
            break;
            case 2:
                ÝkinciSeviye();
                break;
            case 3:
                UcuncuSeviye();
                break;
            case 4:
                DorduncuSeviye();
                break;
            case 5:
                BesinciSeviye();
                break;
            case 6:
                AltinciSeviye();
                break;
            case 7:
                YedinciSeviye();
                break;
            case 8:
                SekizinciSeviye();
                break;
        }
    }

    void BirinciSeviye()
    {
        buyukDegerBelirleme = Random.Range(0, 2);
        if (buyukDegerBelirleme == 0)
        {
            ustDeger = Random.Range(0, 50);
            altDeger = ustDeger - Random.Range(2, 25);
            if (altDeger < 0)
            {
                altDeger = altDeger * -1;
            }
            if (altDeger > ustDeger)
            {
                buyukDeger = altDeger;
            }
            else if (ustDeger > altDeger)
            {
                buyukDeger = ustDeger;
            }
            else if (ustDeger == altDeger)
            {
                altDeger--;
                buyukDeger = ustDeger;
            }

        }
        else
        {
            ustDeger = Random.Range(0, 50);
            altDeger = ustDeger + Random.Range(1, 25);
            buyukDeger = altDeger;
        }

        ustText.text = ustDeger.ToString();
        altText.text = altDeger.ToString();
    }

    void ÝkinciSeviye()
    {

        buyukDegerBelirleme = Random.Range(0, 2);
        if (buyukDegerBelirleme == 0)
        {
            ustDeger = Random.Range(0, 100);
            altDeger = ustDeger - Random.Range(2, 50);
            if (altDeger < 0)
            {
                altDeger = altDeger * -1;
            }
            if (altDeger > ustDeger)
            {
                buyukDeger = altDeger;
            }
            else if (ustDeger > altDeger)
            {
                buyukDeger = ustDeger;
            }
            else if (ustDeger == altDeger)
            {
                altDeger--;
                buyukDeger = ustDeger;
            }

        }
        else
        {
            ustDeger = Random.Range(0, 100);
            altDeger = ustDeger + Random.Range(1, 50);
            buyukDeger = altDeger;
        }

        ustText.text = ustDeger.ToString();
        altText.text = altDeger.ToString();
    }

    void UcuncuSeviye()
    {

        buyukDegerBelirleme = Random.Range(0, 2);
        if (buyukDegerBelirleme == 0)
        {
            ustDeger = Random.Range(0, 250);
            altDeger = ustDeger - Random.Range(2, 100);
            if (altDeger < 0)
            {
                altDeger = altDeger * -1;
            }
            if (altDeger > ustDeger)
            {
                buyukDeger = altDeger;
            }
            else if (ustDeger > altDeger)
            {
                buyukDeger = ustDeger;
            }
            else if (ustDeger == altDeger)
            {
                altDeger--;
                buyukDeger = ustDeger;
            }

        }
        else
        {
            ustDeger = Random.Range(0, 250);
            altDeger = ustDeger + Random.Range(1, 100);
            buyukDeger = altDeger;
        }

        ustText.text = ustDeger.ToString();
        altText.text = altDeger.ToString();
    }

    void DorduncuSeviye()
    {
        
        buyukDegerBelirleme = Random.Range(0, 2);
        if (buyukDegerBelirleme == 0)
        {
            ustDeger = Random.Range(0, 1000);
            altDeger = ustDeger - Random.Range(2, 400);
            if (altDeger < 0)
            {
                altDeger = altDeger * -1;
            }
            if(altDeger > ustDeger)
            {
                buyukDeger = altDeger;
            }else if(ustDeger > altDeger)
            {
                buyukDeger = ustDeger;
            }else if(ustDeger == altDeger)
            {
                altDeger--;
                buyukDeger = ustDeger;
            }
            
        }
        else
        {
            ustDeger = Random.Range(0, 1000);
            altDeger = ustDeger + Random.Range(1, 400);
            buyukDeger = altDeger;
        }

        ustText.text = ustDeger.ToString();
        altText.text = altDeger.ToString();
    }

    void BesinciSeviye()
    {
        
        int x, y, z, a;
        x = Random.Range(0, 50);
        y = Random.Range(0, 50);
        z = Random.Range(0, 50);
        a = Random.Range(0, 50);

        ustText.text = x.ToString() + " + " + y.ToString();
        altText.text = z.ToString() + " + " + a.ToString();

        ustDeger = x + y;
        altDeger = z + a;


        if (ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }else if(altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }else if(ustDeger == altDeger)
        {
            BesinciSeviye();
            return;
        }

        
    }
    void AltinciSeviye()
    {

        int x, y, z, a;
        x = Random.Range(0, 150);
        y = Random.Range(0, 100);
        z = Random.Range(0, 150);
        a = Random.Range(0, 100);

        ustText.text = x.ToString() + " + " + y.ToString();
        altText.text = z.ToString() + " + " + a.ToString();

        ustDeger = x + y;
        altDeger = z + a;


        if (ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if (altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }
        else if (ustDeger == altDeger)
        {
            AltinciSeviye();
            return;
        }


    }
    void YedinciSeviye()
    {

        int x, y, z, a;
        x = Random.Range(100, 500);
        y = Random.Range(0, 350);
        z = Random.Range(100, 500);
        a = Random.Range(0, 350);

        ustText.text = x.ToString() + " + " + y.ToString();
        altText.text = z.ToString() + " + " + a.ToString();

        ustDeger = x + y;
        altDeger = z + a;


        if (ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if (altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }
        else if (ustDeger == altDeger)
        {
            YedinciSeviye();
            return;
        }


    }

    void SekizinciSeviye()
    {

        int x, y, z, a;
        x = Random.Range(1, 100);
        y = Random.Range(10, 20);
        z = Random.Range(1, 100);
        a = Random.Range(10, 20);

        ustText.text = x.ToString() + " x " + y.ToString();
        altText.text = z.ToString() + " x " + a.ToString();

        ustDeger = x * y;
        altDeger = z * a;


        if (ustDeger > altDeger)
        {
            buyukDeger = ustDeger;
        }
        else if (altDeger > ustDeger)
        {
            buyukDeger = altDeger;
        }
        else if (ustDeger == altDeger)
        {
            SekizinciSeviye();
            return;
        }


    }

    void DokuzuncuSeviye()
    {

        /*   int x, y, z, a, hangiÝslem;
           x = Random.Range(100, 1000);
           y = Random.Range(10, 50);
           z = Random.Range(100, 1000);
           a = Random.Range(10, 50);
           hangiÝslem = Random.Range(0, 3);



           if(hangiÝslem == 0)
           {
               ustText.text = x.ToString() + " + " + y.ToString();
               altText.text = z.ToString() + " + " + a.ToString();
               ustDeger = x + y;
               altDeger = z + a;
           }else if(hangiÝslem == 1)
           {
               ustText.text = x.ToString() + " * " + y.ToString();
               altText.text = z.ToString() + " * " + a.ToString();
               ustDeger = x * y;
               altDeger = z * a;
           }
           else if (hangiÝslem == 2)
           {
               ustText.text = x.ToString() + " / " + y.ToString();
               altText.text = z.ToString() + " / " + a.ToString();
               ustDeger = x / y;
               altDeger = z / a;
           }



           if (ustDeger > altDeger)
           {
               buyukDeger = ustDeger;
           }
           else if (altDeger > ustDeger)
           {
               buyukDeger = altDeger;
           }
           else if (ustDeger == altDeger)
           {
               DokuzuncuSeviye();
               return;
           }*/

       /* zorlukSeviyeBelirleme = Random.Range(4, 9);
        SoruZorluk(); */


    }

    public void SonucKontrol(string butonAdi)
    {

        if (geriSayimManager.oyunBasla)
        {

            if (butonAdi == "ustButon")
            {
                butonDeger = ustDeger;
            }
            else if (butonAdi == "altButon")
            {
                butonDeger = altDeger;
            }

            if (butonDeger == buyukDeger)
            {
                audioSource.PlayOneShot(dogruSesi);

                trueFalseManager.TrueFalse(true);

                switch (zorlukSeviye)
                {
                    case 1:
                        puan += 10;
                        puanText.text = puan.ToString();
                        break;
                    case 2:
                        puan += 15;
                        puanText.text = puan.ToString();
                        break;
                    case 3:
                        puan += 20;
                        puanText.text = puan.ToString();
                        break;
                    case 4:
                        puan += 25;
                        puanText.text = puan.ToString();
                        break;
                    case 5:
                        puan += 30;
                        puanText.text = puan.ToString();
                        break;
                    case 6:
                        puan += 35;
                        puanText.text = puan.ToString();
                        break;
                    case 7:
                        puan += 40;
                        puanText.text = puan.ToString();
                        break;
                    case 8:
                        puan += 45;
                        puanText.text = puan.ToString();
                        break;
                    case 9:
                        puan += 50;
                        puanText.text = puan.ToString();
                        break;
                    case 10:
                        puan += 50;
                        puanText.text = puan.ToString();
                        break;
                }

                

                daireManager.DaireleriAc(kacinciSoru);
                kacinciSoru++;
                if (kacinciSoru > 4)
                {
                    zorlukSeviyeBelirleme++;
                    kacinciSoru = 0;
                    daireManager.DaireleriKapat();
                    SoruZorluk();

                }
                SoruZorluk();
            }
            else
            {
                audioSource.PlayOneShot(yanlisSesi);
                trueFalseManager.TrueFalse(false);
                puan -= 10;
                puanText.text = puan.ToString();
            }


        }

        
    }


   public  void SureBitis()
    {
        audioSource.PlayOneShot(bitisSesi);
        ustCevapPanel.SetActive(false);
        altCevapPanel.SetActive(false);
        geriSayimManager.oyunBasla = false;
            sonucPanel.SetActive(true);
            sonucPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
            sonucText.text = puan.ToString();
    }

    public void TekrarBasla()
    {
        SceneManager.LoadScene("GameLevel");
    }


    public void PausePanelAc()
    {
        if (geriSayimManager.oyunBasla)
        {
            ustDikdortgen.SetActive(false);
            altDikdortgen.SetActive(false);
            pausePanel.SetActive(true);
        }

    }




}
