using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        
        //if (transform.position.z < 0.19 &&  transform.position.z > -0.19){
            //Color color = new Color32(9, 255, 255, 255);
            //main.startColor = color;
        //}
        if (transform.position.y > 0.0){
            Color color = new Color32(255, 228, 107, 154);
            main.startColor = color;
        }
        if (transform.position.y < 0.0){
            Color color = new Color32(255, 181, 27, 228);
            main.startColor = color;
        }
    }
}
