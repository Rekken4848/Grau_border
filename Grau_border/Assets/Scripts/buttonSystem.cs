using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSystem : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string idleAnimation;
    [SerializeField] string hoverAnimation;
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public AudioClip hoverSound; // Agregado para usar en PlayHoverSound
    private bool isHoverSoundPlaying = false;

    public void OnHoverEnter(Material newMaterial)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer != null && meshRenderer.sharedMaterials.Length > 1)
        {
            Material[] materials = meshRenderer.sharedMaterials;
            materials[1] = newMaterial;
            meshRenderer.sharedMaterials = materials;


        }
        else
        {
            Debug.LogError("No material.");
        }

        animator.Play(hoverAnimation);
        if (!isHoverSoundPlaying)
        {
            audioSource.PlayOneShot(hoverSound);
            isHoverSoundPlaying = true; // Marcar que el sonido está sonando
        }
    }

    public void OnHoverExit(Material newMaterial)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer != null && meshRenderer.sharedMaterials.Length > 1)
        {
            Material[] materials = meshRenderer.sharedMaterials;
            materials[1] = newMaterial;
            meshRenderer.sharedMaterials = materials;
        }
        else
        {
            Debug.LogError("No material.");
        }
        animator.Play(idleAnimation);
        isHoverSoundPlaying = false;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                // Si estamos en el editor de Unity
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
