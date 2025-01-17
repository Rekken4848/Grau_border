using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrera : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] new GameObject collider;

    void Update()
    {
        // Opcional: otras lógicas que quieras manejar en Update
    }

    public void BajarAnimacion()
    {
        animator.SetBool("subir", false);
    }

    public void SubirAnimacion()
    {
        animator.SetBool("subir", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coche"))
        {
            StartCoroutine(SubirYEsperar());
        }
    }

    private IEnumerator SubirYEsperar()
    {
        SubirAnimacion();  
        yield return new WaitForSeconds(5f); 
        BajarAnimacion();
    }
}
