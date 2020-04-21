using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class theplayer : MonoBehaviour
{
    public Text countText;
    public Text winText;
  public AudioClip chewing;
  public AudioClip swallow;
AudioSource audioSource;

    private                     Rigidbody rb;
    private int count;
    private int applesLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        count=0;
        applesLeft=11;
        SetCountText();
        winText.text = "";
    }

    

IEnumerator OnTriggerEnter (Collider other) {
        
            if (other.gameObject.CompareTag ("apple"))
        {
            
            applesLeft=applesLeft-1;
            other.gameObject.SetActive (false);
            audioSource.PlayOneShot(chewing, 0.7F);
            count = count + 1;
                SetCountText(); 
        yield return new WaitForSeconds(1);

        audioSource.PlayOneShot(swallow, 0.7F);
        }



    }

void SetCountText()
    {
        countText.text ="Score:" + count.ToString()+"/"+applesLeft.ToString();
        if (count >=11){
            winText.text="Game Over";


        }

}

}
