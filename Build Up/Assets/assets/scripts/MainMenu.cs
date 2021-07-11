using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject modeSelector;
    public GameObject Play;
    void Start()
    {
        modeSelector.SetActive(false);
        Play.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModeSelector(){
         SceneManager.LoadScene(3);

    }

    public void Back(){
         modeSelector.SetActive(false);
        Play.SetActive(true);

    }

    public void easy(){
        SceneManager.LoadScene(2);
    }

    public void Hard(){
        SceneManager.LoadScene(1);
    }

}
