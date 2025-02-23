using UnityEngine;
using System.Collections.Generic;


public class TestingScript : MonoBehaviour
{
    [SerializeField] private int number = 5;
    [SerializeField] private int[] numbers;
    [SerializeField] private List<int> numbersList = new List<int>();
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
    //int[] numbers = {1,2,3,4,5};
    //public static List<int> numbersList = new List<int>();
    
    // int[] numbers = new int[3]; //3 tane eleman oluştur içlerini boş bırak
    void Start()
    {
       
        // score = 0;
        // Debug.Log("Start");
        // TestFunction();
        // //Debug.LogWarning("Warning Log!"); sarı, uyarı
        // //Debug.LogError("Error Log!"); kırmızı, hata
        // //Array
        
        // //Debug.Log(numbers[2]);
        // // numbers[0] = 2;
        // // numbers[1] = 3;
        // // numbers[2] = 4;
        // for(int i = 0; i < numbers.Length; i++)
        // {
        //     Debug.Log(numbers[i]);
        // }
        numbersList.Add(13);
        numbersList.Add(15);
        numbersList.Add(17);
        PrintList();
        numbersList.Remove(13);
        PrintList();
        numbersList.Clear();
        PrintList();
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
    void PrintList()
    {
        // for (int i = 0; i < numbersList.Count;i++)
        // {
        //     Debug.Log(numbersList[i]);
            
        // }
        foreach(int myNumber in numbersList)
        {
            Debug.Log(myNumber);
        }
        Debug.Log("-------------------");
    }
    public void myFunction()
    {
        Debug.Log("My function works!");
    }
}




