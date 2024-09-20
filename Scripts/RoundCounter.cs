using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // We need this line for uGUI to work
public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;
    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "Round " + round.ToString();
    }
}

