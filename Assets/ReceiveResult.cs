using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour {

    public GameObject Lighton;
    public GameObject Lightoff;
    public AudioSource okaysound;
	// Use this for initialization
	void Start () {
        //GameObject.Find("Text").GetComponent<Text>().text = "You need to be connected to Internet";
	}
	
    void onActivityResult(string recognizedText){
        char[] delimiterChars = {'~'};
        string[] result = recognizedText.Split(delimiterChars);

        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
        GameObject.Find("Text").GetComponent<Text>().text = result[0];
        //string[] a="Alexa turn on the light"; 
        if(result[0]=="Alexa turn on the light")
        {
            okaysound.Play();
            Lighton.SetActive(true);
            Lightoff.SetActive(false);
        }
        else if(result[0]=="Alexa turn off the light")
        {
            okaysound.Play();
            Lighton.SetActive(false);
            Lightoff.SetActive(true);
        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
