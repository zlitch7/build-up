using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MainLoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MainLoadScene(){
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(0);
    }
}
