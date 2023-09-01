using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBlinking : MonoBehaviour
{
    TMP_Text lbl;
    public float _fadeInTime =0.05f ;
    public float _fadeOutTime = 0.07f;
    public float _blinkStayTime = 0.08f;
    public float _timeChecker = 0f;
    public Color _color;
    // Start is called before the first frame update
    void Start()
    {
        lbl = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _timeChecker += Time.deltaTime;
        if(_timeChecker<_fadeInTime){
            lbl.color = new Color(255,_color.g,_color.r,_timeChecker/_fadeInTime);
        }
        else if(_timeChecker < _fadeInTime + _blinkStayTime){
            lbl.color = new Color(_color.r,255,_color.b,1);
        }
        else if(_timeChecker < _fadeInTime + _blinkStayTime + _fadeOutTime){
            lbl.color = new Color(_color.r, _color.g,_color.b, 1 - (_timeChecker - (_fadeInTime + _blinkStayTime))/_fadeOutTime );
        }
        else{
            _timeChecker = 0;
            lbl.color = new Color(0,0,255);
        }
    }
}
