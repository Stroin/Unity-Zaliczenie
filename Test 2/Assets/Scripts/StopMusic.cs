using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class StopMusic : MonoBehaviour
{
    void Update()
    { 
        if (SceneManager.GetActiveScene().name == "Finish")
            BGmusic.instance.GetComponent<AudioSource>().Pause();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
 
    }
}
