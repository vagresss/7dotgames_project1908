using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaireManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dairelerDizisi;
    void Start()
    {
        DaireleriKapat();
    }

    public void DaireleriKapat()
    {
        foreach(GameObject daire in dairelerDizisi)
        {
            daire.transform.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void DaireleriAc(int kacinciDaire)
    {
        dairelerDizisi[kacinciDaire].transform.GetComponent<RectTransform>().localScale = Vector3.one;
    }


    
}
