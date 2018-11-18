using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateMenu : MonoBehaviour {

    // Use this for initialization
    private InputField input_Field;
    private Button btNext;
    private Button btPrev;
    private Image imageUi;
    private ListEggs eggs;
    

    private void Start()
    {
        btNext = transform.Find("btNext").GetComponent<Button>();
        btPrev = transform.Find("btPrev").GetComponent<Button>();
        input_Field = transform.Find("UiInput").GetComponent<InputField>();
        imageUi = transform.Find("eggCreate").GetComponent<Image>();
        eggs = new ListEggs();
    }

    void GetInputFieldText()
    {
        if (input_Field.text != "")
        {

        }
    }

    public void OnClickNext()
    {
        imageUi.sprite =  eggs.Next();
    }

    public void OnClickPrev()
    {
        imageUi.sprite = eggs.Previous();
    }
}
