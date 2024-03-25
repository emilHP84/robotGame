using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public bool personnalisedSetting = false;
    void Awake(){
        if (personnalisedSetting == false){
            // activer les setting par default via un event
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
