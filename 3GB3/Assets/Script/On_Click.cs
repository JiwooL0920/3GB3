using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Click : MonoBehaviour
{
    public GameObject questionPop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click(){
        questionPop.SetActive(true);
    }

    public void UnClick(){
        questionPop.SetActive(false);
    }
}
