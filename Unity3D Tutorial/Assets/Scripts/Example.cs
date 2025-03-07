using UnityEngine;

namespace CSharpTutorial
{
    #region Yap�lar 

    public class Class
    {
        public Class()
        {

        }
    }

    public abstract class AbstractClass
    {

    }

    public interface IClass
    {

    }

    public struct Struct
    {

    }

    public enum Select
    {

    }

    #endregion

    #region Class'lar

    public class A
    {

    }

    public class B
    {

    }

    #endregion

    public class Example : MonoBehaviour
    {
        #region Temeller

        //3 TEMEL YAPI => DE���KEN FONKS�YON SINIF

        /*
        G�ZL�L�K
        public -> projedeki her class eri�ebilir. (Inspectorda g�r�n�r)
        *bo�* -> default gizlilik.  (Inspectorda g�r�nmez)
        private -> sadece tan�mland��� class eri�ebilir, eri�ilebilirlik limitli. (Inspectorda g�r�nmez)

        [SerializeField] => variableler inspectorda g�r�n�r hale gelir
        [System.Serialize] => yap�lar instepctorda g�r�n�r hale gelir

        ANAHTAR KEL�MELER
        const => Sabit say�lar veya variableler i�in kullan�l�r
        static => bir de�i�ken, fonksiyon veya s�n�f�n tek bir �rne�i oldu�unu belirtir

        DE���KEN TANIMLAMA
        short _short;
        int _integer;
        long _long;
        float _float;
        double _double;

        string _string;

        bool _bool;

        bool[] boolArray;
        float[] floatArray = new float[3];

        /*
        -KO�ULLULAR-

        TER�MLER
        continue => �uan ki sorgulamay� atla, di�erine ge�.
        break => sorguyu, her�eyi bitir ve bu bloktan ��k.
        return x => x denen variable'� d�nd�r, ata. E�er sadece "return" yaz�yorsa ki bu sadece void t�r� fonskiyonlarda g�r�l�r, void metodunu bitir demektir.

        IF & ELSE
        if ("Ko�ul")
        {
            --��lem--
        }
        else if ("Di�er Ko�ul")
        {
            --��lem--
        }
        else
        {
            --��lem--
        }

        SWITCH
        switch("Hangi Variable'a g�re Se�im Yap�lacak")
        {
            case "Variablenin �stenen De�eri":
            --��lem--
            break;
        }

        -LOOPLAR-

        FOR
        for ("Sayac� yapacak variable tan�mlanmas�"; "Ka�a kadar says�n"; "Saya� ne kadar arts�n")
        {
            --��lem--
        }

        FOREACH
        foreach ("Variablenin t�r�" "Variable ismi" in )
        {
            --��lem--
        }

        WHILE
        while ("Ko�ul")
        {
            --��lem--
        }
        */

        #endregion

        // Start is called before the first frame update
        void Awake()
        {
            
        }
        void OnEnable()
        {
            
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void FixedUpdate()
        {
            
        }
        void LateUpdate()
        {
            
        }

        void OnDisable()
        {
            
        }
        void OnDestroy()
        {

        }

        /* unityi sevmiyorum */
    }
}
