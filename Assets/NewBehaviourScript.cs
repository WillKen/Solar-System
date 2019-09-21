using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform Sun, Moon, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune;

    void Start()
    {
 
    }

    void Update()
    {
        Sun.Rotate(Vector3.up * Time.deltaTime * 5);

        Mercury.RotateAround(Sun.position, new Vector3(0.1f, 1, 0), 60 * Time.deltaTime);
        Mercury.Rotate(Vector3.up * 10000 / 58 * Time.deltaTime);

        Venus.RotateAround(Sun.position, new Vector3(0, 1, -0.1f), 55 * Time.deltaTime);
        Venus.Rotate(Vector3.up * 10000 / 243 * Time.deltaTime);

        Earth.RotateAround(Sun.position, Vector3.up, 50 * Time.deltaTime);
        Earth.Rotate(Vector3.up * 10000 * Time.deltaTime);
        Moon.RotateAround(Earth.position, Vector3.up, 5 * Time.deltaTime);
        Moon.Rotate(Vector3.up * 10000 / 27 * Time.deltaTime);

        Mars.RotateAround(Sun.position, new Vector3(0.2f, 1, 0), 45 * Time.deltaTime);
        Mars.Rotate(Vector3.up * 10000 * Time.deltaTime);

        Jupiter.RotateAround(Sun.position, new Vector3(-0.1f, 2, 0), 38 * Time.deltaTime);
        Jupiter.Rotate(Vector3.up * 10000 / 0.3f * Time.deltaTime);

        Saturn.RotateAround(Sun.position, new Vector3(0, 1, 0.2f), 36 * Time.deltaTime);
        Saturn.Rotate(Vector3.up * 10000 / 0.4f * Time.deltaTime);

        Uranus.RotateAround(Sun.position, new Vector3(0, 2, 0.1f), 35 * Time.deltaTime);
        Uranus.Rotate(Vector3.up * 10000 / 0.6f * Time.deltaTime);

        Neptune.RotateAround(Sun.position, new Vector3(-0.1f, 1, -0.1f), 33 * Time.deltaTime);
        Neptune.Rotate(Vector3.up * 10000 / 0.7f * Time.deltaTime);
    }
}
