using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager{
    public static KeyManager Instance = new KeyManager();
    public Dictionary<Enum, KeyCode> keyCodeDictionary = new Dictionary<Enum, KeyCode>();

    public KeyManager(){
        DefaultKey();
    }

    public void DefaultKey(){
        keyCodeDictionary.Add(EnumActionKey.forward, KeyCode.Z);
        keyCodeDictionary.Add(EnumActionKey.left, KeyCode.Q);
        keyCodeDictionary.Add(EnumActionKey.backward, KeyCode.S);
        keyCodeDictionary.Add(EnumActionKey.right, KeyCode.D);
        keyCodeDictionary.Add(EnumActionKey.croutch, KeyCode.LeftControl);
        keyCodeDictionary.Add(EnumActionKey.run, KeyCode.LeftShift);
        keyCodeDictionary.Add(EnumActionKey.jump, KeyCode.Space);

        keyCodeDictionary.Add(EnumActionKey.interact, KeyCode.F);
        keyCodeDictionary.Add(EnumActionKey.throwing, KeyCode.G);

        keyCodeDictionary.Add(EnumActionKey.reload, KeyCode.R);
        keyCodeDictionary.Add(EnumActionKey.specialAttachment, KeyCode.V);
        keyCodeDictionary.Add(EnumActionKey.shoot, KeyCode.Mouse1);
        keyCodeDictionary.Add(EnumActionKey.aim, KeyCode.Mouse2);

        keyCodeDictionary.Add(EnumActionKey.abilityOne, KeyCode.E);
        keyCodeDictionary.Add(EnumActionKey.abilityTwo, KeyCode.A);
        keyCodeDictionary.Add(EnumActionKey.abilityThree, KeyCode.X);

        keyCodeDictionary.Add(EnumActionKey.map, KeyCode.M);
        keyCodeDictionary.Add(EnumActionKey.tchat, KeyCode.T);
        keyCodeDictionary.Add(EnumActionKey.stat, KeyCode.Tab);
    }
}
