using UnityEngine;

public class FollowP : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {   //----Ficava First person assim caso nao metesse vector3 offset
        transform.position = player.position + offset;
    }
}
