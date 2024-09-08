using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cronometro : MonoBehaviour
{
    TMP_Text textito;
    public TMP_Text text;
    public TMP_Text texto;
    float tiempo = 0;
    float Minutos = 0;
    float Segundos = 0;
    private void Awake()
    {
        textito = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        
        tiempo += Time.deltaTime;
        text.text = "Tu tiempo de vida fue: " + tiempo + " segundos";
        texto.text = "Tu tiempo de vida fue: " + tiempo + " segundos";
        MostrarTiempo(tiempo);
    }

    private void MostrarTiempo(float tiempoRestante)
    {
        Minutos = Mathf.Floor(tiempoRestante / 60);
        Segundos = Mathf.Floor(tiempoRestante % 60);
        textito.text = Minutos + ":" + Segundos;
    }
}
