using UnityEngine;

public class Collectible : MonoBehaviour
{
    float range = 0.4f;
    Vector3 m_startPosition;
    // all the way through the board would be 0.54 but avoid the edge
    void Start()
    {
        m_startPosition = transform.position;
    }

    // alt methods are onTriggerEnter, onTriggerExit
    // We do not want to spawn inside the players, that's why stay instead of enter
    void OnTriggerStay(Collider other)
    {
        // If the other GameObject has a Score component, increment it
        other.gameObject.GetComponent<Score>().IncrementScore();

        // Move the position to a new random position within the board bounds
        transform.position = new Vector3(Random.Range(-range, range), transform.position.y, Random.Range(-range, range));
    }

    public void ResetPosition()
    {
        transform.position = m_startPosition;
    }
}
