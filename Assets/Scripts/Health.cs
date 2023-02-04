using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField]
    private Image fillImage = null;
    [SerializeField]
    private FloatReference currentHealth = null;
    [SerializeField]
    private FloatReference maxHealth = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
        fillImage.fillAmount = currentHealth.Value / maxHealth.Value;
    }
}
