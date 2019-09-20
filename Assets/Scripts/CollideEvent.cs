using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CollideEvent : MonoBehaviour
{
    //public GameObject TextGUI;
    //public AudioClip coinSound;
    //public GameObject endingVideo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Flower")) // Set trigger event when Mario collide with Flower, get by name
        {
            Debug.Log("Mario health - 10");
        }
        if (collision.gameObject.tag.Equals("Land")) // Set trigger event when Mario collide with Land, get by tag name
        {
            Debug.Log("Mario is landed");
        }
        //if (collision.gameObject.tag.Equals("Coin")) // Set trigger event when Mario collide with the coin, get by tag name
        //{
        //    int t = int.Parse(TextGUI.GetComponent<Text>().text); // Get the current score in UI 
        //    t++; // Increase the score when collide with coin by 1
        //    TextGUI.GetComponent<Text>().text = t.ToString(); // Set the new score to UI
        //    GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().PlaySoundOneTime(coinSound); // Play coin sound when get collide with coin
        //    Destroy(collision.gameObject); // After Mario get the coin, destroy it
        //}
        //if (collision.gameObject.tag.Equals("Checkpoint")) // Set trigger event when Mario collide with the checkpoint, playing the ending video
        //{
        //    endingVideo.SetActive(true); // Active the gameobject which has video to play
        //    GameObject.Find("Background Sound").SetActive(false); // Turn off background music when play video
        //}
    }
}
