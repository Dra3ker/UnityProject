using UnityEngine;
using System.Collections;

public class ProjController : MonoBehaviour
{
    public int amount = 500;
    public GameObject prefab;
    float time = 0.5f;
    float timer;

    // Use this for initialization
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(1) && timer > time)
        {
            timer = 0;
            //Debug.Log("mouse pressed");
            Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = (Input.mousePosition - sp).normalized;

            GameObject proj = Instantiate(prefab,gameObject.transform);
            proj.GetComponent<Rigidbody2D>().velocity = dir * amount;
            //proj.GetComponent<Rigidbody2D>().AddForce(dir * amount);
        }
    }
}