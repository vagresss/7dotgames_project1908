using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel, ustDikdortgen, altDikdortgen;

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }
    private void OnDisable()
    {
        Time.timeScale = 1.0f;
    }
   

    public void DevamEt()
    {
        pausePanel.SetActive(false);
        ustDikdortgen.SetActive(true);
        altDikdortgen.SetActive(true);
    }

    public void AnaMenuDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void OyundanCik()
    {
        Application.Quit();
    }

}
