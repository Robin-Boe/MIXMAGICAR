using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    private ParticleSystem ps;
    public GameObject cubePrefab;
    public GameObject firePrefab;

    private GameObject cubeInstance;
    //private GameObject cubeInstance2;
    private GameObject fireInstance;
    //private GameObject robotRoot;
    //private GameObject robotFoot;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        cubeInstance = Instantiate(cubePrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        //cubeInstance2 = Instantiate(cubePrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        fireInstance = Instantiate(firePrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        //Instantiate(fire, new Vector3(0f, 0f, 0f), Quaternion.identity);
        cubeInstance.transform.position = gameObject.transform.position + new Vector3(0, 0.2f, 0);
        fireInstance.transform.position = gameObject.transform.position + new Vector3(0, 0.2f, 0);
        
        //cube.transform.parent = gameObject.transform;
        cubeInstance.transform.localScale = new Vector3(0f,0f,0f);
        fireInstance.transform.localScale = new Vector3(0f,0f,0f);
        //robotRoot = FindRoot();
        //robotFoot = FindFoot();
        //cubeInstance2.transform.position = robotFoot.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;

        cubeInstance.transform.position = gameObject.transform.position + new Vector3(0,0.1f,0f);
        fireInstance.transform.position = gameObject.transform.position + new Vector3(0,0.05f,0);
        
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
        if (transform.position.y > -0.4f && transform.position.y < -0.1f){
            cubeInstance.transform.localScale = new Vector3(0.12f, 0.12f, 0.12f);
            if (transform.position.x > -0.2f){
                cubeInstance.GetComponent<Renderer>().material.color = Color.red;
            }
            else{
                cubeInstance.GetComponent<Renderer>().material.color = Color.green;
            }   
        }
        else{
            cubeInstance.transform.localScale = new Vector3(0f,0f,0f);
        }

        // If palm is to the roof, show fire
        if (transform.position.y > 0.1f){
            fireInstance.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
        }
        else{
            fireInstance.transform.localScale = new Vector3(0f,0f,0f);
        }
    }

    /*public GameObject FindRoot()
    {
        GameObject root = gameObject.transform.parent.gameObject;
        bool found = false;
        while(found == false)
        {
            root = root.transform.parent.gameObject;
            if (root.name.ToLower().Equals("root"))
            {
                found = true;
            }
        }
        return root;
    }

    public GameObject FindFoot()
    {
        GameObject foot = null;
        var children = robotRoot.GetComponentsInChildren<Transform>();
        foreach(var trans in children)
        {
            if (trans.gameObject.name.ToLower().Equals("rightfoot"))
            {
                foot = trans.gameObject;
                break;
            }
        }
        
        return foot;
    }*/
}
