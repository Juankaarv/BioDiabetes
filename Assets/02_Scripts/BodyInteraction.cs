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
                titleName.text = "Corazón";
                infoText.text = "La diabetes aumenta el riesgo de enfermedades cardíacas, \n como la enfermedad coronaria y los infartos, porque daña las arterias.\n Los niveles altos de glucosa contribuyen a la acumulación de placas en las arterias, lo que puede \n causar arterioesclerosis (endurecimiento de las arterias) y reducir el flujo de sangre al corazón.";
                bodyImage.sprite = corazonSprite;
                break;
            case "Dientes":
                titleName.text = "Dientes";
                infoText.text = "La diabetes incrementa el riesgo de infecciones bucales, especialmente\n la enfermedad periodontal (enfermedad de las encías), ya que \n el exceso de azúcar en la saliva promueve el crecimiento de bacterias.\n Esto puede causar pérdida de dientes, encías inflamadas \n y otros problemas de salud oral.";
                bodyImage.sprite = dientesSprite;
                break;
            case "Higado":
                titleName.text = "Hígado";
                infoText.text = "La diabetes puede llevar a la enfermedad del \n hígado graso no alcohólico, donde el hígado \n acumula grasa debido a problemas en el metabolismo\n de las grasas. Esto puede progresar a una condición\n grave llamada esteatohepatitis no alcohólica (NASH),\n que aumenta el riesgo de cirrosis y cáncer de hígado.";
                bodyImage.sprite = higadoSprite;
                break;
            case "Ojo":
                titleName.text = "Ojos";
                infoText.text = "La retinopatía diabética es una complicación común\n que afecta los vasos sanguíneos de la retina,\n y puede causar ceguera si no se controla.\n La diabetes también aumenta el riesgo de glaucoma\n y cataratas, lo que compromete la visión en general.";
                bodyImage.sprite = ojoSprite;
                break;
            case "Pancreas":
                titleName.text = "Páncreas";
                infoText.text = "Aunque el páncreas es el órgano afectado directamente\n en la diabetes (por producir insuficiente insulina en la diabetes tipo 1\n o por la resistencia a la insulina en la diabetes tipo 2),\n la propia diabetes crónica puede dañar aún más las\n células productoras de insulina, agravando la enfermedad y \naumentando la dificultad para controlar los niveles de glucosa en sangre.";
                bodyImage.sprite = pancreaSprite;
                break;
            case "Venas":
                titleName.text = "Sistema Circulatorio";
                infoText.text = "La nefropatía diabética ocurre cuando los niveles\n elevados de azúcar en sangre dañan los pequeños \nvasos sanguíneos de los riñones, afectando su capacidad\n para filtrar desechos de la sangre.\n Esto puede llevar a insuficiencia renal, necesitando\n diálisis o trasplante de riñón en casos avanzados.";
                bodyImage.sprite = venasSprite;
                break;
            case "Rinon":
                titleName.text = "Riñones";
                infoText.text = "La diabetes daña los vasos sanguíneos y aumenta\n el riesgo de enfermedades vasculares \n periféricas, que afectan la circulación en las extremidades,\n especialmente las piernas y los pies. \nEsto provoca una cicatrización más lenta, y en \ncasos graves, puede llevar a la necesidad de amputación.";
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
