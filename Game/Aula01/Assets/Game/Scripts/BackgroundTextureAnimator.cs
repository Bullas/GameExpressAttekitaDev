using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTextureAnimator : MonoBehaviour
{

    private Material mat;
    private Vector2 offset;


    void Start()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");

    }

    void Update()
    {
        offset.x = offset.x + (0.2f * Time.deltaTime);
        mat.SetTextureOffset("_MainTex", offset);
    }
}
