using Pixelplacement;
using UnityEngine;

public class SplineStick : MonoBehaviour
{
    private Transform player;

    [HideInInspector]
    public Spline mySpline;
    
    void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
        mySpline = GetComponent<Spline>();
    }
    
    
    void UpdateSpline()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
