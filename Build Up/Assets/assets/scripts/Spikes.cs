using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spikes : MonoBehaviour
{
    public int InitialTimeCount = 80;
    public int TimeCount = 50;

    public float Timer = 80;

    public int size;

    public GameObject GameOver;

    public GameObject Movable;
    GameManager gameManager;

    public TextMeshProUGUI TimerText;
    public GameObject RedScreen;

    private Camera cam;

    

    void Start()
    {
        gameManager = GameObject.Find("game manager").GetComponent<GameManager>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        GameOver.SetActive(false);
        RedScreen.SetActive(false);
        StartCoroutine(IncreaseSpikeOne());
    }

    // Update is called once per frame
    void Update()
    {
           Timer -=  Time.deltaTime;
           TimerText.text = Timer.ToString("0");

           if(Timer <= 10){
              RedScreen.SetActive(true);
           }
            if(Timer <= 8){
               RedScreen.SetActive(false);
           }
            if(Timer <= 6){
              RedScreen.SetActive(true);
           }
            if(Timer <= 4){
               RedScreen.SetActive(false);
           }
            if(Timer <= 2){
              RedScreen.SetActive(true);
           }
            if(Timer <= 0){
                cam.orthographicSize = size;
               RedScreen.SetActive(false);
           }


           if(Timer <= 0){
               Timer = 60;
           }
    }

    IEnumerator IncreaseSpikeOne(){
        yield return new WaitForSeconds(InitialTimeCount);
        
        Debug.Log("did");
         //transform.Translate(Vector3.up * Time.deltaTime * 600, Space.World);
         transform.position += Vector3.up * 5;
        StartCoroutine(IncreaseSpikeTwo());
    }

    IEnumerator IncreaseSpikeTwo(){
         yield return new WaitForSeconds(TimeCount);

         //transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
          transform.position += Vector3.up * 5;
         StartCoroutine(IncreaseSpikeThree());
    }
     IEnumerator IncreaseSpikeThree(){
         yield return new WaitForSeconds(TimeCount);

         //transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 5;
         StartCoroutine(IncreaseSpikeFour());
    }
     IEnumerator IncreaseSpikeFour(){
         yield return new WaitForSeconds(TimeCount);

        // transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 5;
         StartCoroutine(IncreaseSpikeFive());
    }
     IEnumerator IncreaseSpikeFive(){
         yield return new WaitForSeconds(TimeCount);

        // transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 5;
         StartCoroutine(IncreaseSpikeSix());
    }

      IEnumerator IncreaseSpikeSix(){
         yield return new WaitForSeconds(TimeCount );

        // transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 2;
         StartCoroutine(IncreaseSpikeSeven());
    }
     IEnumerator IncreaseSpikeSeven(){
         yield return new WaitForSeconds(TimeCount );

         //transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 2;
         StartCoroutine(IncreaseSpikeEight());
    }
     IEnumerator IncreaseSpikeEight(){
         yield return new WaitForSeconds(TimeCount );

        // transform.Translate(Vector3.up * Time.deltaTime * 400, Space.World);
        transform.position += Vector3.up * 5;
        // StartCoroutine(IncreaseSpikeNine());
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            gameManager.Pause = true;
            Debug.Log("game over");
            GameOver.SetActive(true);
        }
    }

}
