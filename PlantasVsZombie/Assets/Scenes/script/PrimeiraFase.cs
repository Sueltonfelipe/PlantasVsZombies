using UnityEngine;
using UnityEngine.SceneManagement;

public class PrimeiraFase : MonoBehaviour
{
    // Nome da cena a ser carregada
    public string nomeDaCena = "Fase1";

    // Método chamado quando o objeto é clicado
    private void OnMouseDown()
    {
        // Carrega a cena quando o objeto é clicado
        CarregarCenaDesejada();
    }

    // Método para carregar a cena desejada
    private void CarregarCenaDesejada()
    {
        SceneManager.LoadScene("Fase1");
    }
}