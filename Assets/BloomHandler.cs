using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloomHandler : MonoBehaviour
{

    [SerializeField] Bloom bloom;

    //[SerializeField] Toggle bloomToggle;
    [SerializeField][Range(1, 16)] int bloomIterations = 2;
    //[SerializeField][Range(0, 10)] float bloomThreshold = 2.1f;
    //[SerializeField][Range(0, 10)] float bloomIntensity = 1.4f;

    [SerializeField] Slider bloomIterationsSlider;
    //[SerializeField] Slider bloomThresholdSlider;
    //[SerializeField] Slider bloomIntensitySlider;


    void Awake()
    {
        bloomIterationsSlider.maxValue = 16;
        bloomIterationsSlider.value = bloom.iterations;
        //bloomThresholdSlider.maxValue = 10;
        //bloomThresholdSlider.value = bloom.threshold;
        //bloomIntensitySlider.maxValue = 10;
        //bloomIntensitySlider.value = bloom.intensity;

    }

    public void ChangeBloom()
    {
        //bloom.intensity = bloomIntensitySlider.value;
        //bloom.threshold = bloomThresholdSlider.value;
        bloom.iterations = (int)bloomIterationsSlider.value;
    }

}
