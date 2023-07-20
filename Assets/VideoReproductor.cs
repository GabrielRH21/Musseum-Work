using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoReproductor : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraPlayer;
    [SerializeField]
    private GameObject cameraEsfera;
    [SerializeField]
    private GameObject esfera;
    [SerializeField]
    private VideoPlayer video;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        cameraPlayer.SetActive(true);
        cameraEsfera.SetActive(false);
        
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            cameraPlayer.SetActive(true);
            cameraEsfera.SetActive(false);
            video.Stop();
        }
    }

    private void OnTriggerEnter(Collider other){
        
        if (other.CompareTag("Player"))
        {
            cameraPlayer.SetActive(false);
            cameraEsfera.SetActive(true);
            if (video != null)
            {
                
                video.Play();   
            }
            

        }

    }
}
