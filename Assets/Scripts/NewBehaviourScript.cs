using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour


{
   
    [SerializeField]
    private FloatReference currentHealth = null;
    [SerializeField]
    private FloatReference maxHealth = null;

    [SerializeField]
    private GameObjectCollection collection;


    private List<GameObject> list = new List<GameObject>(); 

    private void Awake()
    {
        currentHealth.Value = maxHealth.Value;
    }
    private void Update()
    {
        HealthChanged();
       // ClickRightMouse();
    }
    public void HealthChanged()
    {
        if (currentHealth.Value <= 0)
        {
            Destroy(this.gameObject);

        }
    }

    private void OnEnable()
    {
        collection.Add(this.gameObject);
         //list.Add(Instantiate(this.gameObject, pos, Quaternion.identity));
        

    }
    private void OnDisable()
    {
        collection.Remove(this.gameObject);
    }

    public void ClickRightMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {

           // OnEnable(Input.mousePosition);
        }
        else if(Input.GetMouseButtonDown(1))
        {
           // OnDisable();
        }

    }
}