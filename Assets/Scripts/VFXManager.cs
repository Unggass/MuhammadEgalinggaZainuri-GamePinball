using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{

    public GameObject vfxSource;
    public GameObject vfxSwitch;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
}
