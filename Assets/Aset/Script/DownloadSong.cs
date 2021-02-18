using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class DownloadSong : MonoBehaviour
{
    private string url;
   // public string songTitle; //ganti nama
    public AudioSource audioSource;
    public AudioClip audioClip;
    public SongDataReader songDataReader;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DownloadAudioClip()
    {
        using (UnityWebRequest webRequest = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
        {
            //Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log("Error: " + webRequest.error);
            }
            else
            {
                audioClip = DownloadHandlerAudioClip.GetContent(webRequest);
                audioSource.clip = audioClip;
                audioSource.Play();
                Debug.Log("Audio is Playing");
            }
        }
        
            
    }
    //Remove Soon
    public void ButtonClick()
    {
        url = "http://localhost/"+songDataReader.songTitle[0]+".mp3";
        StartCoroutine(DownloadAudioClip());
        Debug.Log("Starting to download the audio...");
    }
}
