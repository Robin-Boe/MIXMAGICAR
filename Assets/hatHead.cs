using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatHead : MonoBehaviour
{
    public GameObject hatPrefab;

    private GameObject hatInstance;

    // Start is called before the first frame update
    void Start()
    {
        hatInstance = Instantiate(hatPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        hatInstance.transform.localScale = new Vector3(0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        hatInstance.transform.position = gameObject.transform.position + new Vector3(0,0.1f,0f);
    }
}
