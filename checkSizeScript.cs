using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class checkSizeScript : MonoBehaviour
{
    public float height;
    public float width;
    public float lengh;
    public float mass;
    public float engine;

    GameObject sizer;


    public void Button_Press() {
        sizer = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        sizer.transform.position = transform.position;
        sizer.transform.localScale = new Vector3(width / 1000F, height / 1000F, lengh / 1000F);
        sizer.transform.parent = transform;
    }

    public void Button_Remove() {
        DestroyImmediate(sizer);
    }
}
