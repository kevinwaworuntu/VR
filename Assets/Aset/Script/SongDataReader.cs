using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongDataReader : MonoBehaviour
{
    public TextAsset textJSON;
    public string[] songTitle;

    [System.Serializable]
    public class Song
    {
        public string title;
    }

    [System.Serializable]
    public class SongList
    {
        public Song[] song;
    }

    public SongList songList = new SongList();


    void Start()
    {
        songList = JsonUtility.FromJson<SongList>(textJSON.text);
        int i;
     
        i = songList.song.Length;
        songTitle = new string[i];
        
        for (i = 0; i < songList.song.Length; i++)
        {
            Song song = songList.song[i];
            songTitle[i] = song.title;

        }
        
    }
}

//Gak dipake
//foreach (Song song in songList.song)
//{
//    Debug.Log(song.title);
//}