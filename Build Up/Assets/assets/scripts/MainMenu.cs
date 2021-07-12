using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource theme;
     public GameObject BlackScreen;
    public GameObject modeSelector;
    public GameObject Play;
    void Start()
    {
        theme = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        BlackScreen.SetActive(false);
        modeSelector.SetActive(false);
        Play.SetActive(true);
        theme.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModeSelector(){
        BlackScreen.SetActive(true);
        StartCoroutine(PlayScene());

    }

    IEnumerator PlayScene(){
        yield return new WaitForSeconds(2);
         SceneManager.LoadScene(3);
    }

    public void GameQuit(){
        Application.Quit();
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
