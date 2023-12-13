using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retornar : MonoBehaviour
{
    // Método chamado quando o objeto é clicado
    private void OnMouseDown()
    {
        // Carrega a fase chamada "MenuPrincipal"
        CarregarMenuPrincipal();
    }

    // Método para carregar a fase "MenuPrincipal"
    private void CarregarMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
