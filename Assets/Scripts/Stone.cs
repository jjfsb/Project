using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    private GameObject tearsGo;
    // Start is called before the first frame update
    void Start()
    {
        tearsGo = Resources.Load<GameObject>("Prefabs/Tear");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
