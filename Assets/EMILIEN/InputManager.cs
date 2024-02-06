using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
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
    public KeyCode SpecialWeaponKey = KeyCode.V;
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

    public void UpdateKey(KeyCode newKey){
        if (KeyIsAvailable(newKey)){

        }
    }

    private bool KeyIsAvailable(KeyCode key) {
        return key != null;
    }
}




public class InputManager : MonoBehaviour
{
    private KeyManager keyManager = new KeyManager();
    private KeyCode selectedKey;
    private bool waitChooseKey;


    private void Start(){
        UpdateTextKey();
    }

    void Update(){
        
    }


    public void ChangeKey(){
        foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(key)){
                selectedKey = key;
                UpdateTextKey();
                keyManager.UpdateKey(selectedKey);
                waitChooseKey = false;
                break;
            }
            
        }
    }

    void UpdateTextKey(){

    }
}
