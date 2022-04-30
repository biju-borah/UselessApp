using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager2 : MonoBehaviour
{
    public GameObject screen;
    public string ch1;
    public string ch2;
    public string ma;
    public string yo;
    public string cs;
    public string me;
    public string ev;
    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enablescreen()
    {
        screen.SetActive(true);
    }
    public void open1()
    {
        Application.OpenURL(ch1);
    }
    public void open2()
    {
        Application.OpenURL(ma);
    }
    public void open3()
    {
        Application.OpenURL(yo);
    }
    public void open4()
    {
        Application.OpenURL(ch2);
    }
    public void open5()
    {
        Application.OpenURL(me);
    }
    public void open6()
    {
        Application.OpenURL(ev);
    }
    public void open7()
    {
        Application.OpenURL(cs);
    }
}
