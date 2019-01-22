using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agrandar : MonoBehaviour
{
    int mas = 7;
    int menos = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new Vector3(1, 1, 1);

        if(Input.GetKey(KeyCode.G))
            transform.localScale += new Vector3(Time.deltaTime * mas, Time.deltaTime * mas, Time.deltaTime * mas);
        else if(Input.GetKey(KeyCode.P))
            transform.localScale += new Vector3(Time.deltaTime * menos, Time.deltaTime * menos, Time.deltaTime * menos);
    }
}
