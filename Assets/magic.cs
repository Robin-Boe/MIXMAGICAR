using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    private ParticleSystem ps;
    public GameObject cube;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        Instantiate(cube, new Vector3(0f, 0f, 0f), Quaternion.identity);
        Instantiate(fire, new Vector3(0f, 0f, 0f), Quaternion.identity);
        cube.transform.localScale = Vector3.one * 0.1f;
        fire.transform.localScale = Vector3.one * 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        
        //if (transform.position.z < 0.19 &&  transform.position.z > -0.19){
            //Color color = new Color32(9, 255, 255, 255);
            //main.startColor = color;
        //}
        // Color change
        if (transform.position.y > 0){
            Color color = new Color32(255, 228, 107, 154);
            main.startColor = color;
        }
        if (transform.position.y < 0){
            Color color = new Color32(255, 181, 27, 228);
            main.startColor = color;
        }

        // Place object (cube) and move it
        if (transform.position.z > 0.10f){
            cube.transform.localScale = new Vector3(1f, 1f, 1f);
            cube.transform.position = transform.position + new Vector3(0f,0f,-2f);
        }
        else{
            cube.transform.localScale = Vector3.one * 0.1f;
        }

        // If palm is to the roof, show fire
        if (transform.rotation.x > 250f && transform.rotation.x < 280f){
            fire.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            fire.transform.position = transform.position + new Vector3(-0.25f,-0.25f,-0.25f);
        }
        else{
            fire.transform.localScale = Vector3.one * 0.1f;
        }
    }
}
