using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    IEnumerator Loading()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CubeScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loading());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
