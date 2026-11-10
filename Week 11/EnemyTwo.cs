using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Moves diagonally down and to the right (-1 down, 0.5 right)
        transform.Translate(new Vector3(0.5f, -1f, 0) * Time.deltaTime * 5f);

        // Destroy when off the bottom of the screen
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}