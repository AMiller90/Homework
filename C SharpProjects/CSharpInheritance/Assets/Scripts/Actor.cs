using UnityEngine;
using System.Collections;

[SerializeField]
public struct Vector3<T>
{

   public T X, Y, Z;
}



public class Actor : MonoBehaviour
{
    [SerializeField]
    public string output;
    [SerializeField]
    public int Health;
    [SerializeField]
    public int Damage;
    [SerializeField]
    public string Name;
    [SerializeField]
    public Vector3<float> pos;



    public void Start()
    {
        move();
    }

    public void Update()
    {
       
        
    }

    public virtual void move()
    {
        output = "Default Move!";
    }

    public void attack()
    {

    }


}
