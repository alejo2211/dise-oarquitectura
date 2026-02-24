using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class CalculadoraUI : MonoBehaviour
{
    public enum Operador
    {
        Suma,
        Resta,
        Multiplicacion,
        Division 
    }


    [SerializeField] private TMP_InputField _inputA;
    [SerializeField] private TMP_InputField _inputB;
    [SerializeField] private TMP_Text _resultado;
    private Operador _operador;
    
    public void SeleccionarOperador(Operador operador)
    {
        _operador = operador;
    }
    public void OperadorSuma() => _operador = Operador.Suma;
    public void OperadorResta()
    {
        _operador = Operador.Resta;
    }
    public void OperadorMultiplicacion()
    {
        _operador = Operador.Multiplicacion;
    }
    public void OperadorDividir()
    {
        _operador = Operador.Division;
    }
    public void Calcular()
    {
        float.TryParse(_inputA.text, out float a); 
        float.TryParse(_inputB.text, out float b);
        
        switch (_operador)
        {
            case Operador.Suma:
                _resultado.text= (a + b).ToString();
                    break;
            case Operador.Resta:
                _resultado.text = (a - b).ToString();
                break;
            case Operador.Multiplicacion:
                _resultado.text = (a * b).ToString();
                break;
            case Operador.Division:
                    _resultado.text = (a / b).ToString();
                break;
            default:
                _resultado.text=("Oprime un operador valido");
                
                break;
            
        }
    }
}
