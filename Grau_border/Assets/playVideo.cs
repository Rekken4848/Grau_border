using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playVideo : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer v;
    public double jumpTime = 5.0; // Tiempo en segundos para avanzar o retroceder el video
    private float doubleTapTime = 0.3f; // Tiempo m�ximo entre toques para considerarlo un doble toque
    private float lastTapTime = 0f;
    private int tapCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        v = this.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleTouchInput();
    }

    void HandleTouchInput()
    {
        // Verifica si se est� tocando la interfaz gr�fica (UI)
        if (IsPointerOverUI())
        {
            return; // Si es as�, no proceses la entrada t�ctil
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {
                tapCount++;
                if (tapCount == 1)
                {
                    lastTapTime = Time.time;
                }
                else if (tapCount == 2)
                {
                    if (Time.time - lastTapTime < doubleTapTime)
                    {
                        // Es un doble toque, verifica la posici�n en la pantalla
                        if (touch.position.x < Screen.width / 2)
                        {
                            // Doble toque en el lado izquierdo - Retrocede el video
                            RewindVideo();
                        }
                        else
                        {
                            // Doble toque en el lado derecho - Avanza el video
                            AdvanceVideo();
                        }
                    }

                    // Reinicia el contador de toques
                    tapCount = 0;
                }
            }

            // Reinicia el contador de toques si pasa el tiempo m�ximo permitido
            if (Time.time - lastTapTime > doubleTapTime)
            {
                tapCount = 0;
            }

            // Si es un toque simple en cualquier parte de la pantalla, se pausa o reproduce el video
            if (tapCount == 1 && Time.time - lastTapTime > doubleTapTime)
            {
                StartCoroutine(playPauseVideo());
                tapCount = 0;
            }
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(playPauseVideo());
    }

    // M�todo para verificar si el toque est� sobre un elemento de UI
    bool IsPointerOverUI()
    {
        // Comprueba si hay un toque en la pantalla
        if (Input.touchCount > 0)
        {
            // Verifica si el primer toque est� sobre un elemento de UI
            return EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId);
        }
        return false;
    }

    IEnumerator playPauseVideo()
    {
        v.Prepare();
        while (!v.isPrepared)
        {
            yield return null;
        }
        if (v.isPlaying)
        {
            v.Pause();
        }
        else
        {
            v.Play();
        }
        yield return null;
    }

    // M�todo para avanzar el video
    void AdvanceVideo()
    {
        if (v.isPrepared)
        {
            // Avanza el video en "jumpTime" segundos
            v.time = Math.Min(v.time + jumpTime, v.length);
        }
    }

    // M�todo para retroceder el video
    void RewindVideo()
    {
        if (v.isPrepared)
        {
            // Retrocede el video en "jumpTime" segundos
            v.time = Math.Max(v.time - jumpTime, 0);
        }
    }
}
