using UnityEngine;

public class wasding : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
    }
}
