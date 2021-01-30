using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public AnimationCurve curve;

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float y = curve.Evaluate(time);

        var pos =  Vector3.Lerp(start.position, end.position, y);
        transform.position = pos;
    }
}
