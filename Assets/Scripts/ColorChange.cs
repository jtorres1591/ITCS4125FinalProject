using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material colorMaterial;
    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Debug.Log("ColorChange Script Starts.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Activates ChangeColor once the mouse clicks on the object.
    void OnMouseDown() {
        //UnityEngine.Debug.Log("OnMouseDown Activated");
        ChangeColor();
    }
    // Change the object's color.
    void ChangeColor() {
        gameObject.GetComponent<MeshRenderer>().material = colorMaterial;
    }
}
