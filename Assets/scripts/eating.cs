using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating : MonoBehaviour
{
    public AudioSource SwallowSource;
    void Start()
    {
       SwallowSource=GetComponent<AudioSource>();  
    }

     void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("playerc"))
        {
            SwallowSource.Play();
            
            
            

        }
    }
    void Update()
    {
        
    }
}
