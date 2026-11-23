using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    public GameObject[] birds;
    public Transform player;
    public float interactionDistance = 5f;

    void Update()
    {
        for (int i = 0; i < birds.Length; i++)
        {
            float distance = Vector3.Distance(
                player.position,
                birds[i].transform.position
            );

            if (distance < interactionDistance)
            {
                birds[i].SetActive(true);
            }
        }
    }
}