using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class _360VideoBtn : MonoBehaviour
{
    private SelectVideo sVideo;
    private BtnVideoOutput btnOutput;

    private void Start()
    {
        sVideo = GameObject.FindGameObjectWithTag("Scene Manager").GetComponent<SelectVideo>();
        btnOutput = GameObject.FindGameObjectWithTag("Scene Manager").GetComponent<BtnVideoOutput>();
    }


    public void onClick_Btn360()
    {     
        var key = gameObject.GetComponentInChildren<Text>();
        btnOutput.btnIndex = int.Parse(key.text);
        sVideo.VideoStatus(1);

    }
}
