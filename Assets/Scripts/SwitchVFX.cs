using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchVFX : MonoBehaviour
{
    public GameObject vfxSwitch;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
    }
}
