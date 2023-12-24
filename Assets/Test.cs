using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float b = 0;

    private float c = 0;
    // Update is called once per frame
    void Update()
    {
        b += Time.deltaTime;
        c += Time.deltaTime;
        Debug.Log(c);
        this.transform.position = new Vector3(Mathf.Cos(b), 0, 0); 
    }
}
