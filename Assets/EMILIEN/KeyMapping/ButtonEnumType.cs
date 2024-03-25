using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEnumType : MonoBehaviour, IPointerEnterHandler{ 
    public EnumActionKey actionKey;
    public GameObject buttonObject => this.gameObject;
    public TextMeshProUGUI textActionKey;

    
    public void OnPointerEnter(PointerEventData eventData){
        if (eventData.pointerEnter != null){
            KeyMapping.selectedButton = buttonObject;
            Debug.Log("bouton selectionné");
        }
    }
}
