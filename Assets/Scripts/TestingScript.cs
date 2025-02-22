using UnityEngine;

public class TestingScript : MonoBehaviour
{
/*     int number = 5;
    int number2 = 10;
    float anotherNumber = 5.5f;
    string text = "Hello World";
    bool isTrue = false;

/*     void TestFunction()
    {
        number = 8;
        anotherNumber = 9.5f;
        text = "Selam";
        isTrue = true;
    } */
/*     int TestFunction()
    {
        return number + number2;
    }  */
    int score;
    //Awake fonksiyonu, oyun başlamadan hemen önce çalışan, 1 kere çalışan bir fonksiyondur.
    void Awake() {
        score = 0;
        Debug.Log("Awake");
    }
    //Start fonksiyonu, oyun başlarken çalışan, 1 kere çalışan bir fonksiyondur.
    void Start()
    {
        score = 0;
        Debug.Log("Start");
        TestFunction();
        //Debug.LogWarning("Warning Log!"); sarı, uyarı
        //Debug.LogError("Error Log!"); kırmızı, hata
    }
    void Update()
    {
        //Debug.Log("Update");
    }
    void FixedUpdate() {
        
    }
    void LateUpdate() {
        
    }
    void TestFunction()
    {
        Debug.Log("Test Function");
    }
}


