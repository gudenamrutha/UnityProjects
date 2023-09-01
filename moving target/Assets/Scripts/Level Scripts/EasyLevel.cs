using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EasyLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TextMeshProUGUI scoreValueText;
    [SerializeField]    
    TextMeshProUGUI livesText;
    void Start()
    {
        livesText.text = "3";
    }
    void Awake()
    {
        livesText.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        scoreValueText.text = ArrowController.score.ToString();
        livesText.text = ArrowController.lives.ToString();
    }
}
