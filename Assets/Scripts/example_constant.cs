using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example_constant : MonoBehaviour
{
    /// <summary>
    ///  const tanımladık Pi sayısını ve burada yarıcapı public tanımmlayıp alan ve cevereyi fonksiypn içinde kullandım yoksa static tanımlama yapmam gerkir
    /// statik tanımlama yapacağım zamanda yeni birr circle sınıfı tanımlayıp bu crcle sınıfının içinde raidus objesi tanımlamalıyım
    /// Circle myCircle = new Circle();
    /// float myRadius = myCircle.radius;
    /// </summary>
    private const double PI = 3.14159;
    public double radius;

    private double perimeter;

    private double area;
    // Start is called before the first frame update
    void Start()
    { 
        perimeter = 2 * PI * radius; 
        area = PI * radius * radius;
        Debug.Log(perimeter + " " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
