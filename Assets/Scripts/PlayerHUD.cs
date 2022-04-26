using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    public  GameObject Eyeopen;
    public Timer Mytimer;
    public GameObject overlay;
    private int Timeleft = 10;
    public TMP_Text countDown;
    // Start is called before the first frame update
    void Start()
    {
        overlay.SetActive(false);
        Mytimer.StartTimer(1.0f);
        Eyeopen.SetActive(false);
        overlay.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updatecountDown()
    {
        if (Timeleft > 0)
        {
            Timeleft = Timeleft - 1;
            countDown.text = Timeleft + "s";
            if (Timeleft == 0)
            {


            }
            else
            {
                Mytimer.StartTimer(1.0f);
            }
        }
    }
    public void Eyeopens()
    {
        Eyeopen.SetActive(true);
        
    }
    public void Eyeclosed()
    {
        Eyeopen.SetActive(false);
    }

}
