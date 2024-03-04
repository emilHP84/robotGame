using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyManager{
    public Dictionary<Enum, KeyCode> keyCodeDictionary = new Dictionary<Enum, KeyCode>();

    // ["forwardKey" ; KeyCode.Z], ["leftKey" ; KeyCode.Q]


    [Header("mouvement")]
    public KeyCode forwardKey = KeyCode.Z;
    public KeyCode backKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.Q;
    public KeyCode rightkKey = KeyCode.D;
    public KeyCode runKey = KeyCode.LeftShift;
    public KeyCode croutchkKey = KeyCode.LeftControl;
    public KeyCode jumpKey = KeyCode.Space;


    [Header("interaction")]
    public KeyCode interactKey = KeyCode.F;
    public KeyCode throwKey = KeyCode.G;

    [Header("Attack")]
    public KeyCode reloadKey = KeyCode.R;
    public KeyCode specialWeaponKey = KeyCode.V;
    public KeyCode shooKey = KeyCode.Mouse0;
    public KeyCode aimKey = KeyCode.Mouse1;

    [Header("Capacity")]
    public KeyCode abilityOneKey = KeyCode.E;
    public KeyCode abilityTwoKey = KeyCode.A;
    public KeyCode abilityThreeKey = KeyCode.X;

    [Header("orientation & multiplayer")]
    public KeyCode mapKey = KeyCode.M;
    public KeyCode tchatKey = KeyCode.T;
    public KeyCode statKey = KeyCode.Tab;

    
    void Start(){
        keyCodeDictionary.Add(0,forwardKey);
        keyCodeDictionary.Add(0,backKey);
        keyCodeDictionary.Add(0,leftKey);
        keyCodeDictionary.Add(0,rightkKey);
        keyCodeDictionary.Add(0,runKey);
        keyCodeDictionary.Add(0,croutchkKey);
        keyCodeDictionary.Add(0,jumpKey);

        keyCodeDictionary.Add(0,interactKey);
        keyCodeDictionary.Add(0,throwKey);

        keyCodeDictionary.Add(0,reloadKey);
        keyCodeDictionary.Add(0,specialWeaponKey);
        keyCodeDictionary.Add(0,shooKey);
        keyCodeDictionary.Add(0,aimKey);

        keyCodeDictionary.Add(0,abilityOneKey);
        keyCodeDictionary.Add(0,abilityTwoKey);
        keyCodeDictionary.Add(0,abilityThreeKey);

        keyCodeDictionary.Add(0,mapKey);
        keyCodeDictionary.Add(0,tchatKey);
        keyCodeDictionary.Add(0,statKey);
    }
}



[RequireComponent(typeof(KeyManager))]
public class InputManager : MonoBehaviour
{
    private KeyManager keyManager = new KeyManager();
    private KeyCode selectedKey;
    
    private bool KeyIsAvailable(KeyCode key){
        if (key != selectedKey) return true;
        else return false;
    }

    public void ChangeKey(string nameKey){
        foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(key)){
                selectedKey = key;
                UpdateKey(nameKey, selectedKey);
                UpdateTextKey();
                break;
            }
            
        }
    }

    private void UpdateKey(string keyName, KeyCode newKey){
        if (KeyIsAvailable(newKey)){

            keyManager.keyCodeDictionary[keyName] = newKey;

            /*if (keyManager.keyCodeDictio.TryGetValue(1, out selectedKey)){

            }*/

        }
    }

    void UpdateTextKey(){

    }
}
