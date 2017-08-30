using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoCanvas : MonoBehaviour
{

    public static IntoCanvas instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)
        {
            Destroy(this.gameObject);
        }
    }

}