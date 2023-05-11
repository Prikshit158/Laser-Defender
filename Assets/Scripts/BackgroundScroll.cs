using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.3f;
    Material myMaterial;
    Vector2 offset;
    
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0f, scrollSpeed);
    }

    
    void Update()
    {
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
