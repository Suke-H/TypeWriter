using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextGenerator : MonoBehaviour
{

    [SerializeField] string inputText;

    TextMeshProUGUI consoleText;
    int characterNum;

    void Start()
    {
        consoleText = GameObject.Find("ConsoleText").GetComponent<TextMeshProUGUI>();
        consoleText.text = "";

        characterNum = inputText.Length;

        StartCoroutine(Generate());
    }

    // public IEnumerator generate()
    // {
        
    // }

    // public void write(int i){
    //     consoleText = consoleText + inputText[i];
    // }

    // void Update(){
    //     for (int i=0; i<characterNum; i++){
    //         consoleText = consoleText + inputText[i];

    //     }
    // }

    private IEnumerator Generate(){
        for (int i=0; i<characterNum; i++){
            yield return new WaitForSeconds(0.1f);
            consoleText.text += inputText[i];
        }
    }

}
