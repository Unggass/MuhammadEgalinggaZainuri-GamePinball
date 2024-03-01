using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{

    private enum SwitchState
    {
        On,
        Off,
        Blink
    }

    public Collider bola;
    public Material onMaterial;
    public Material offMaterial;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private SwitchState state;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        SetSwitch(false);

        StartCoroutine(BlinkStartTimer(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void SetSwitch(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;

            //play SFX
            audioManager.PlaySFX(gameObject.transform.position);

            //play VFX
            vfxManager.PlaySwitchVFX(gameObject.transform.position);

            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkStartTimer(5));
        }

        // -- If Statement lebih singkat --
        // renderer.material = isOn ? onMaterial : offMaterial;
    }

    private void Toggle()
    {
        if(state == SwitchState.On)
        {
            SetSwitch(false);

            
        }
        else
        {
            SetSwitch(true);
        }

        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times)
    {

        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkStartTimer(5));
    }

    private IEnumerator BlinkStartTimer(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(3));
    }
}
