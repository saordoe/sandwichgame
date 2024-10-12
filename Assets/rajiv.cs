using UnityEngine;

public class rajiv : MonoBehaviour
{
    private int timer;
    public bool facingClass = false;
    private int n;
    public float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        n = 200;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer % n == 1)
        {
            if (facingClass)
            {
                facingClass = false;
                transform.Rotate(0, 180, 0, Space.Self);
            } else
            {
                facingClass = true;
                transform.Rotate(0, 0, 0, Space.Self);
            }
        }

    }
}
