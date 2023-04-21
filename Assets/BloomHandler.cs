using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloomHandler : MonoBehaviour
{

    [SerializeField] Bloom bloom;

    [SerializeField][Range(1, 16)] int bloomIterations = 2;


    [SerializeField] Slider bloomIterationsSlider;



    void Awake()
    {
        bloomIterationsSlider.maxValue = 16;
        bloomIterationsSlider.value = bloom.iterations;


    }

    public void ChangeBloom()
    {

        bloom.iterations = (int)bloomIterationsSlider.value;
    }

}
