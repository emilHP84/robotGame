using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyManager {
    public EnumActionKey enumActionKey = new EnumActionKey();
    public Dictionary<Enum, KeyCode> keyCodeDictionary = new Dictionary<Enum, KeyCode>();

    private void Start(){
        DefaultKey();
    }
    private void DefaultKey() {
        keyCodeDictionary.Add(EnumActionKey.ActionKey.forward, KeyCode.Z);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.left, KeyCode.Q);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.backward, KeyCode.S);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.right, KeyCode.D);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.croutch, KeyCode.LeftControl);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.run, KeyCode.LeftShift);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.jump, KeyCode.Space);

        keyCodeDictionary.Add(EnumActionKey.ActionKey.interact, KeyCode.F);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.throwing, KeyCode.G);

        keyCodeDictionary.Add(EnumActionKey.ActionKey.reload, KeyCode.R);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.specialAttachment, KeyCode.V);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.shoot, KeyCode.Mouse1);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.aim, KeyCode.Mouse2);

        keyCodeDictionary.Add(EnumActionKey.ActionKey.abilityOne, KeyCode.E);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.abilityTwo, KeyCode.A);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.abilityThree, KeyCode.X);

        keyCodeDictionary.Add(EnumActionKey.ActionKey.map, KeyCode.M);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.tchat, KeyCode.T);
        keyCodeDictionary.Add(EnumActionKey.ActionKey.stat, KeyCode.Tab);
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
    public void ChangeKey(Enum actionKey){
        foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(key)){
                selectedKey = key;
                UpdateKey(actionKey, selectedKey);
                UpdateTextKey();
                break;
            }
            else continue;
        }
    }

    private void UpdateKey(Enum actionKey, KeyCode newKey){
        if (KeyIsAvailable(newKey)){

            keyManager.keyCodeDictionary[actionKey] = newKey;

            /*if (keyManager.keyCodeDictionary.TryGetValue(, out selectedKey)){

            }*/

        }
    }

    void UpdateTextKey(){

    }
}
