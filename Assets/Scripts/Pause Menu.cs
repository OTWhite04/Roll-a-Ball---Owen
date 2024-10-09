using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject[] pauseUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseUI[0].SetActive(false);
        pauseUI[1].SetActive(true);
    }


    public void UnPause()
    {
        Time.timeScale = 1;
        pauseUI[0].SetActive(true);
        pauseUI[1].SetActive(false);

    }


}
