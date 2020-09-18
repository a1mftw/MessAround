using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDungeon : MonoBehaviour
{
    public float movSpeed = 0.3f;
    public float rotSpeed = 0.3f;

    float angle = 0;
    float oldAngle = 0;
    bool controlActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && controlActive)
        {
            controlActive = false;
            StartCoroutine(smooth_move(movSpeed));
        }

        if (Input.GetKeyDown(KeyCode.D) && controlActive)
        {
            oldAngle = angle;
            angle = oldAngle + 90;
            StopAllCoroutines();
            controlActive = false;
            StartCoroutine(smooth_rotate(angle, rotSpeed));
        }

        if (Input.GetKeyDown(KeyCode.A) && controlActive)
        {
            oldAngle = angle;
            angle = oldAngle - 90;
            StopAllCoroutines();
            controlActive = false;
            StartCoroutine(smooth_rotate(angle, rotSpeed));
            
        }
    }

    IEnumerator smooth_rotate(float targetAngle,float speed) 
    {
        float time = 0;

        while (transform.rotation.y != targetAngle && time<1f)
        {
            time += Time.deltaTime / speed;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, targetAngle, 0f), time);
            yield return null;
        }
       // transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
       // yield return null;
        controlActive = true;
    
    }

    IEnumerator smooth_move(float speed)
    {

        float time = 0;
        Vector3 start_pos = transform.position; //Starting position.
        Vector3 end_pos = transform.position + transform.forward * 10; //Ending position.
       
        while (start_pos != end_pos && time < 1f)
        {
            time += Time.deltaTime / speed;

            transform.position = Vector3.Lerp(start_pos, end_pos, time);
            yield return null;
        }

        controlActive = true;
    }
}