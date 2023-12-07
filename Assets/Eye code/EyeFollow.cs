using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour
{
    public GameObject Target;

    //Ref To UI
    private UIScript ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = FindObjectOfType<UIScript>();

        if (ui)
        {
            Debug.Log(this.gameObject.name + " has a UI");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ui.gameOver == false)
        {
            Vector3 Look = transform.InverseTransformPoint(Target.transform.position);
            float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg - 90;

            transform.Rotate(0, 0, Angle);
        }
    }
}
