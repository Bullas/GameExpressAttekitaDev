using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTextureAnimator : MonoBehaviour
{
    private Material mat;
    private Vector2 offset;

    public float factor = 40f;

    public GameConfiguration config;

    void Start()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x = offset.x + ((config.speed / factor) * Time.deltaTime);
        mat.SetTextureOffset("_MainTex", offset);
    }
}
