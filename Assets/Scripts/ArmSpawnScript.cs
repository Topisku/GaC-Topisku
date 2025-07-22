using UnityEngine;

public class ArmSpawnScript : MonoBehaviour
{
    public GameObject Arm;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnArm();
    }


    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnArm();
            timer = 0;
        }
    }
    void spawnArm()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Arm, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
