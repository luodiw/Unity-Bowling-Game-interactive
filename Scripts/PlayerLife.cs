using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    // If the player moves off the edge of the ground, it dies
    private void Update()
    {
        if (transform.position.y < -1f)
        {
          Die();
        }
    }

    // Defining what it means to die
    void Die()
    {
      GetComponent<MeshRenderer>().enabled = false;
      GetComponent<Rigidbody>().isKinematic = true;
      GetComponent<PlayerMovement>().enabled = false;
      Invoke(nameof(ReloadLevel), 1.3f);
      Debug.Log("yaya");
    }

    void ReloadLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
