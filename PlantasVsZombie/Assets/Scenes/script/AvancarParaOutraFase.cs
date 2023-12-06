using UnityEngine;
using UnityEngine.SceneManagement;

public class AvancarParaOutraFase : MonoBehaviour
{
    // Nome da próxima fase (certifique-se de configurar corretamente no Editor do Unity)
    public string proximaFase = "SampleScene";

    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))  // 0 representa o botão esquerdo do mouse
        {
            // Carrega a próxima fase
            CarregarProximaFase();
        }
    }

    void CarregarProximaFase()
    {
        // Carrega a próxima cena
        SceneManager.LoadScene(proximaFase);
    }
}