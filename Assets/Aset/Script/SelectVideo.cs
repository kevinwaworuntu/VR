using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class SelectVideo : MonoBehaviour
{
    private VideoPlayer vPlayer;
    private GameObject vGameObject;
    private BtnVideoOutput btnOutput;
    [SerializeField] private VideoClip[] vClip;


    // Start is called before the first frame update
    void Start()
    {
        vGameObject = GameObject.FindGameObjectWithTag("360 Player");
        vPlayer = GameObject.FindGameObjectWithTag("360 Player").GetComponent<VideoPlayer>();
        btnOutput = GameObject.FindGameObjectWithTag("Scene Manager").GetComponent<BtnVideoOutput>();

    }

    public void VideoStatus(int vStatus)
    {
        if (vStatus == 0)
        {
            return;
        }
        else if (vStatus == 1)
        {
            vGameObject.SetActive(false);
            ChangeVideo();
            vStatus++;
            if (vStatus == 2)
            {
                vGameObject.SetActive(true);
            }
        }
    }

    public void ChangeVideo()
    {
        switch (btnOutput.btnIndex)
        {
            case 1:
                vPlayer.clip = vClip[0];
                break;
            case 2:
                vPlayer.clip = vClip[1];
                break;
            case 3:
                vPlayer.clip = vClip[2];
                break;
            case 4:
                vPlayer.clip = vClip[3];
                break;
        }
    }
}
