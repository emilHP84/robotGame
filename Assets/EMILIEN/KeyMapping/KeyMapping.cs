using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class KeyMapping : MonoBehaviour{
    private KeyManager keyManager = new KeyManager();
    public static GameObject selectedButton;
    private KeyCode selectedKey;

    private void OnEnable(){
        FindKey();
    }

    private void Update(){
        if (Input.anyKeyDown == true){
            ChangeKey();
        }
    }

    private bool KeyIsAvailable(KeyCode key){
        //if (selectedKey != key) return true;
        //else return false;
        return true;
    }

    private void FindKey(){
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.forward){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.forward];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.left){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.left];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.right){ 
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.right];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.backward){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.backward];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.croutch){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.croutch];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.run){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.run];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.jump){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.jump];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.interact){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.interact];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.throwing){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.throwing];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.run){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.run];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.specialAttachment){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.specialAttachment];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.shoot){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.shoot];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.aim){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.aim];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.abilityOne){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.abilityOne];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.abilityTwo){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.abilityTwo];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.abilityThree){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.abilityThree];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.map){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.map];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.tchat){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.tchat];
        }
        if (selectedButton.GetComponent<ButtonEnumType>().actionKey == EnumActionKey.stat){
            selectedKey = keyManager.keyCodeDictionary[EnumActionKey.stat];
        }


    }
    public void ChangeKey(){
        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(key)){
                UpdateKey(key);
                
                UpdateTextKey(key);
                break;
            }
        }
    }
    private void UpdateKey(KeyCode newKey){
        if (KeyIsAvailable(newKey)){
            keyManager.keyCodeDictionary[selectedKey] = newKey;
            selectedKey = newKey;
            gameObject.SetActive(false);
        }
    }
    void UpdateTextKey(KeyCode key){
        selectedButton.GetComponent<ButtonEnumType>().textActionKey.text = "" + key;
        Debug.Log(selectedKey.ToString());
    }
}
