using UnityEngine;
using UnityEngine.SceneManagement;

public class AvancarParaOutraFase : MonoBehaviour
{
    // Nome da próxima fase (certifique-se de configurar corretamente no Editor do Unity)
    public string proximaFase = "SampleScene";

    void OnMouseDown()
    {
        // Carrega a próxima fase quando o objeto é clicado
        CarregarProximaFase();
    }

    void CarregarProximaFase()
    {
        // Carrega a próxima cena
        SceneManager.LoadScene(proximaFase);
    }
}