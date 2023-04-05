using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptionPoint : MonoBehaviour
{
    public void addValue(){
        Perception.perceptionInt += 1;
    }

    public void getValue() {
        int value = Perception.perceptionInt;
    }
}
