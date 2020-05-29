using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class ButtonScript : MonoBehaviour
{

    public KeyCode _Key;

    private Button _button;
    
    void Awake()
    {
        _button = GetComponent<Button>();
    }
        
        
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(_Key))
        {
            FadeToColor(_button.colors.pressedColor);
            _button.onClick.Invoke();
            CameraShaker.Instance.ShakeOnce(3f, 4f, .1f, 1f);

        }
        else if(Input.GetKeyUp(_Key))
        {
            FadeToColor(_button.colors.normalColor);
        }
    }

    void FadeToColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
    }
}
