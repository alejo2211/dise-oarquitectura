using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class CalculadoraUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputA;
    [SerializeField] private TMP_InputField inputB;

    public float ConvertirStringAFloat(string input)
    {
         return float.Parse(input);
    }
    public string Calcular(string operador,float inputA , float inputB)
    {
        switch (operador)
        {
            case "+":
                return (inputA + inputB).ToString();
                    break;
            case "-":
                return (inputA - inputB).ToString();
                break;
            case "*":
                return (inputA * inputB).ToString();
                break;
            
        }
    }
}
