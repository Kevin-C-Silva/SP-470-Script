using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToDelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi pressionado
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    Scene.Quit();
                }
            }
        }
    }
}