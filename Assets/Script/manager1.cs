using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager1 : MonoBehaviour
{
    public GameObject screen1;
    public manager2 screen2;
    // Start is called before the first frame update
    void Start()
    {
       screen1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void go()
    {
        screen1.SetActive(false);
        screen2.enablescreen();

    }
    public void quit()
    {
        Application.Quit();
    }
}
