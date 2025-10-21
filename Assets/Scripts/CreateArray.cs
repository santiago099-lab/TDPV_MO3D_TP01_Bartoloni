using UnityEngine;

public class CreateArray : MonoBehaviour
{
    [Header("Configuracion del Muro")]
    [Tooltip("Prefab que se usara para construir el muro")]
    public GameObject prefabObject;

    [Tooltip("Numero de objetos en el eje X (ancho)")]
    public int N = 3;

    [Tooltip("Numero de objetos en el eje Y (alto)")]
    public int M = 4;

    [Header("Espaciado")]
    [Tooltip("Distancia entre objetos en X")]
    public float spacingX = 1.5f;

    [Tooltip("Distancia entre objetos en Y")]
    public float spacingY = 1.5f;

    void Start()
    {
        if (prefabObject == null)
        {
            Debug.LogError("No se ha asignado ningun prefab en CreateArray");
            return;
        }

        CreateWall();
    }

    void CreateWall()
    {
        Renderer prefabRenderer = prefabObject.GetComponentInChildren<Renderer>(true);

        if (prefabRenderer == null)
        {
            Bounds bounds = prefabRenderer.bounds;
            spacingX = bounds.size.x;
            spacingY = bounds.size.y;
        }

        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                Vector3 position = new Vector3(
                   x * spacingX,
                   y * spacingY,
                   0
                );

              GameObject newBlock =Instantiate(prefabObject, position, Quaternion.identity);
              
              newBlock.name = $"Block_{x}_{y}";
              
              newBlock.transform.SetParent(this.transform);
            }
        }
        Debug.Log($"Muro creado: {N} X {M} = {N * M} onjetos");
        Debug.Log($"Espaciado automatico: X={spacingX}, Y={spacingY}");
    }
}
