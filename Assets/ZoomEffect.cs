using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine;

public class ZoomEffect : MonoBehaviour
{
    [SerializeField] public bool isZooming;
    private Vignette vInt;
    public Volume volume;

    private void Start()
    {
        volume = gameObject.GetComponent<Volume>();
    }

    public void Zooming()
    {
        isZooming = true;
        if (isZooming == true)
        {
            VolumeProfile proflile = volume.sharedProfile;

            volume.profile.TryGet(out vInt);
            vInt.intensity.value = 1f;

            if (vInt.intensity == 0)
            {
                vInt.active = false;
            }
            else
            {
                vInt.active = true;
                vInt.intensity.value -= 0.01f;
            }
        }
    }
}
