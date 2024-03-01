using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{

    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    private Renderer renderer;
    private Animator animator;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
           Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.linearVelocity *= multiplier;
             
            // Animasi
            animator.SetTrigger("Bumper Hit");

            // SFX
            audioManager.PlaySFX(collision.transform.position);

            // VFX
            vfxManager.PlayVFX(collision.transform.position);

            // Add Score
            scoreManager.AddScore(10);
        }
    }
}
