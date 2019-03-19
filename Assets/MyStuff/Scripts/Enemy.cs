using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.name == "CharacterRobotBoy")
        {
            Destroy(other.gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }

}
