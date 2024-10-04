using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Transform beyin;
    [SerializeField]
    private Transform startBtn;
    void Start()
    {
        beyin.transform.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f);
        startBtn.transform.GetComponent<RectTransform>().DOLocalMoveY(-250f, 1f);
    }

    public void Basla()
    {
        SceneManager.LoadScene("GameLevel");
    }

}
