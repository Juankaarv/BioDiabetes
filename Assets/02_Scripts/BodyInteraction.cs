using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BodyInteraction : MonoBehaviour
{
    public Camera Camera;
    public GameObject infoPanel;
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI titleName;
    public Canvas infoCanvas;
    public Image bodyImage;

    public Sprite corazonSprite;
    public Sprite dientesSprite;
    public Sprite higadoSprite;
    public Sprite ojoSprite;
    public Sprite pancreaSprite;
    public Sprite venasSprite;
    public Sprite rinonSprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log("Objeto tocado: " + hit.collider.gameObject.name); // Verificar si se detecta el objeto
                    string bodyName = hit.collider.gameObject.name;
                    BodyInfo(bodyName);
                }
            }
        }
    }

    private void BodyInfo(string bodyName)
    {
        infoCanvas.gameObject.SetActive(true);
        infoPanel.gameObject.SetActive(true);
        titleName.gameObject.SetActive(true);
        bodyImage.gameObject.SetActive(true);

        switch (bodyName)
        {
            case "Corazon":
                titleName.text = "Coraz�n";
                infoText.text = "La diabetes aumenta el riesgo de enfermedades card�acas, \n como la enfermedad coronaria y los infartos, porque da�a las arterias.\n Los niveles altos de glucosa contribuyen a la acumulaci�n de placas en las arterias, lo que puede \n causar arterioesclerosis (endurecimiento de las arterias) y reducir el flujo de sangre al coraz�n.";
                bodyImage.sprite = corazonSprite;
                break;
            case "Dientes":
                titleName.text = "Dientes";
                infoText.text = "La diabetes incrementa el riesgo de infecciones bucales, especialmente\n la enfermedad periodontal (enfermedad de las enc�as), ya que \n el exceso de az�car en la saliva promueve el crecimiento de bacterias.\n Esto puede causar p�rdida de dientes, enc�as inflamadas \n y otros problemas de salud oral.";
                bodyImage.sprite = dientesSprite;
                break;
            case "Higado":
                titleName.text = "H�gado";
                infoText.text = "La diabetes puede llevar a la enfermedad del \n h�gado graso no alcoh�lico, donde el h�gado \n acumula grasa debido a problemas en el metabolismo\n de las grasas. Esto puede progresar a una condici�n\n grave llamada esteatohepatitis no alcoh�lica (NASH),\n que aumenta el riesgo de cirrosis y c�ncer de h�gado.";
                bodyImage.sprite = higadoSprite;
                break;
            case "Ojo":
                titleName.text = "Ojos";
                infoText.text = "La retinopat�a diab�tica es una complicaci�n com�n\n que afecta los vasos sangu�neos de la retina,\n y puede causar ceguera si no se controla.\n La diabetes tambi�n aumenta el riesgo de glaucoma\n y cataratas, lo que compromete la visi�n en general.";
                bodyImage.sprite = ojoSprite;
                break;
            case "Pancreas":
                titleName.text = "P�ncreas";
                infoText.text = "Aunque el p�ncreas es el �rgano afectado directamente\n en la diabetes (por producir insuficiente insulina en la diabetes tipo 1\n o por la resistencia a la insulina en la diabetes tipo 2),\n la propia diabetes cr�nica puede da�ar a�n m�s las\n c�lulas productoras de insulina, agravando la enfermedad y \naumentando la dificultad para controlar los niveles de glucosa en sangre.";
                bodyImage.sprite = pancreaSprite;
                break;
            case "Venas":
                titleName.text = "Sistema Circulatorio";
                infoText.text = "La nefropat�a diab�tica ocurre cuando los niveles\n elevados de az�car en sangre da�an los peque�os \nvasos sangu�neos de los ri�ones, afectando su capacidad\n para filtrar desechos de la sangre.\n Esto puede llevar a insuficiencia renal, necesitando\n di�lisis o trasplante de ri��n en casos avanzados.";
                bodyImage.sprite = venasSprite;
                break;
            case "Rinon":
                titleName.text = "Ri�ones";
                infoText.text = "La diabetes da�a los vasos sangu�neos y aumenta\n el riesgo de enfermedades vasculares \n perif�ricas, que afectan la circulaci�n en las extremidades,\n especialmente las piernas y los pies. \nEsto provoca una cicatrizaci�n m�s lenta, y en \ncasos graves, puede llevar a la necesidad de amputaci�n.";
                bodyImage.sprite = rinonSprite;
                break;
        }
    }

    public void CloseCanvas()
    {
        infoCanvas.gameObject.SetActive(false);
        infoPanel.gameObject.SetActive(false);
        bodyImage.gameObject.SetActive(false);
        titleName.gameObject.SetActive(false);
    }
}
