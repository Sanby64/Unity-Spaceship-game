using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaVida : MonoBehaviour
{
    public float maxVida = 100.0f;
    public float actualVida;

    public bool inmortal = false;
    public float tiempoInmortal = 1.0f;

    public Text vidaText;

    private void Start()
    {
        actualVida = maxVida;
    }

    private void Update()
    {
        if (actualVida > maxVida)
            actualVida = maxVida;

        if (actualVida <= 0)
            Muerte();

        // UI
        
    }

    public void QuitarVida(float da�o)
    {
        if (inmortal) return;

        actualVida -= da�o;
        StartCoroutine(TiempoInmortal());
    }

    public void DarVida(float vida)
    {
        actualVida += vida;
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }

    IEnumerator TiempoInmortal()
    {
        inmortal = true;
        yield return new WaitForSeconds(tiempoInmortal);
        inmortal = false;
    }

}

