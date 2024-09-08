using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controladorDePuntos : MonoBehaviour
{
    TMP_Text texto;
    float puntos = 0;
    private void Awake()
    {
        texto = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        ImprimirPuntos();
    }
    private void AumentarPuntos()
    {
        puntos = puntos + 5;
        ImprimirPuntos();
    }
    private void OnEnable()
    {
        player.actualizarPuntos += AumentarPuntos;
    }
    private void OnDisable()
    {
        player.actualizarPuntos -= AumentarPuntos;
    }
    private void ImprimirPuntos()
    {
        texto.text = "Tus puntos son: " + puntos;
    }

}
