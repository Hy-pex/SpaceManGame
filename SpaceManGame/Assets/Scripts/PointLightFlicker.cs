using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering.HighDefinition;
using Random = UnityEngine.Random;


public class PointLightFlicker : MonoBehaviour
{
    [SerializeField]
    private PointLight pLight;

    public float FlickerTime;
    public float MinBrightness;
    public float MaxBrightness;
    public GameObject lgt;
    public int smoothing = 5;
    private float Timer = 0.0f;

    private Queue<float> smoothQueue;
    private float lastSum = 0f;

    private HDAdditionalLightData lightData;
    
    // Start is called before the first frame update
    public void Reset()
    {
         smoothQueue.Clear();
         lastSum = 0;
    }
    void Start()
    {
        smoothQueue = new Queue<float>(smoothing);
        lightData = lgt.GetComponent<HDAdditionalLightData>();
        
    }

    // Update is called once per frame
    void Update()
    {
        while (smoothQueue.Count >= smoothing)
        {
            lastSum -= smoothQueue.Dequeue();
        }

        float newVal = Random.Range(MinBrightness, MaxBrightness);
        smoothQueue.Enqueue(newVal);
        lastSum += newVal;
        lightData.intensity = lastSum / (float)smoothQueue.Count;
        //UpdateTimer();
        //float NewIntensity = Mathf.Lerp(MinBrightness, MaxBrightness, (Timer/FlickerTime));
        //lightData.intensity = NewIntensity;
        //Debug.LogError(NewIntensity);
    }

    float UpdateTimer()
    {
        Timer += Time.deltaTime;
        if (Timer >= FlickerTime)
            Timer = 0.0f;

        return Timer;
    }
}
