using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    private Vector3 startScale;

    public enum ScaleType
    {
        x,
        y,
        all
    }

    public ScaleType scaleType = ScaleType.all;


    void Start()
    {
        startScale = transform.localScale;

        FitToScreen();
        
    }

    void FitToScreen()
    {
        float height = Camera.main.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;

        float newWidth = (scaleType == ScaleType.all || scaleType == ScaleType.x) ? width : startScale.x;
        float newHeight = (scaleType == ScaleType.all || scaleType == ScaleType.y) ? height : startScale.y;

        transform.localScale = new Vector3(newWidth, newHeight, startScale.z);
    }


}
