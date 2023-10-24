using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEditor.UI;
using UnityEngine.UI;


public class ChangeDepthOfField : MonoBehaviour
{

    [SerializeField]
    private VolumeProfile profile;
    private DepthOfField dof;

    [Range(0.0f, 300.0f)] public float nearStart;    
    [Range(0.0f, 300.0f)] public float nearEnd;
    [Range(0.0f, 300.0f)] public float farStart;
    [Range(0.0f, 300.0f)] public float farEnd;
    
    
    //public Slider depthSlider;
    // Start is called before the first frame update
    void Start()
    {
        profile = GetComponent<Volume>().profile;
        profile.TryGet<DepthOfField>(out dof);
    }

    // Update is called once per frame
    void Update()
    {
        dof.farFocusStart.value = farStart;
        dof.farFocusEnd.value = farEnd;
        dof.nearFocusStart.value = nearStart;
        dof.nearFocusEnd.value = nearEnd;
        
    }
}
