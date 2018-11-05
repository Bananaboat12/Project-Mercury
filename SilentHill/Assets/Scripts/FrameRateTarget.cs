using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateTarget : MonoBehaviour {

    [SerializeField]
    int frameRate = 30;


    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameRate;

    }

    private void Update()
    {
        if(Application.targetFrameRate != frameRate)
        {
            Application.targetFrameRate = frameRate;
        }
    }
}
