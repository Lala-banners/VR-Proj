using UnityEngine;

public class LavaMove : MonoBehaviour
{
    private bool isOpening;
    [SerializeField] private GameObject lava;
    [SerializeField] private int maxPosition;

    // Update is called once per frame
    void Update()
    {
        LavaRise();
    }

    public void LavaRise() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOpening = true;
        }

        if (isOpening)
        {
            if (lava.transform.localPosition.y > maxPosition)
            {
                isOpening = false;
            }
            else
            {
                Vector3 lavaPos = lava.transform.localPosition;
                lavaPos += Vector3.up * (Time.deltaTime * 0.5f);
                lava.transform.localPosition = lavaPos;
            }
        }
    }
}
