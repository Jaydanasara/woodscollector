using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime= 300f;
    
    
    public Text timerText;
    public Text timeOutText;
    public AudioClip buzzer;
 
AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        currentTime=startingTime;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       currentTime-=1 *Time.deltaTime;
    timerText.text= currentTime.ToString("0");
    
    if(currentTime<=0){
    currentTime=0;
    audioSource.PlayOneShot(buzzer, 0.7F);
    timeOutText.text=" 0ut of time Game Over";
    enabled = false;
    }
    }
}
