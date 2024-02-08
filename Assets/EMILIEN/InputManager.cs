using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour{
    public Dictionary<int, KeyCode> keyCodeDictio = new Dictionary<int, KeyCode>();

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
        keyCodeDictio.Add(0,forwardKey);
        keyCodeDictio.Add(0,backKey);
        keyCodeDictio.Add(0,leftKey);
        keyCodeDictio.Add(0,rightkKey);
        keyCodeDictio.Add(0,runKey);
        keyCodeDictio.Add(0,croutchkKey);
        keyCodeDictio.Add(0,jumpKey);

        keyCodeDictio.Add(0,interactKey);
        keyCodeDictio.Add(0,throwKey);

        keyCodeDictio.Add(0,reloadKey);
        keyCodeDictio.Add(0,specialWeaponKey);
        keyCodeDictio.Add(0,shooKey);
        keyCodeDictio.Add(0,aimKey);

        keyCodeDictio.Add(0,abilityOneKey);
        keyCodeDictio.Add(0,abilityTwoKey);
        keyCodeDictio.Add(0,abilityThreeKey);

        keyCodeDictio.Add(0,mapKey);
        keyCodeDictio.Add(0,tchatKey);
        keyCodeDictio.Add(0,statKey);
    }
}




public class InputManager : MonoBehaviour
{
    private KeyManager keyManager = new KeyManager();
    private KeyCode selectedKey;

    private void Start(){
        UpdateTextKey();
    }
    private bool KeyIsAvailable(KeyCode key){

        return key != null;
    }

    public void UpdateKey(KeyCode newKey){
        if (KeyIsAvailable(newKey)){
            if (keyManager.keyCodeDictio.TryGetValue(1, out selectedKey)){

            }
        }
    }

    public void ChangeKey(){
        foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(key)){
                selectedKey = key;
                UpdateTextKey();
                UpdateKey(selectedKey);
                break;
            }
            
        }
    }

    void UpdateTextKey(){

    }
}
