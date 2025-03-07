using UnityEngine;

namespace CSharpTutorial
{
    #region Yapýlar 

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

        //3 TEMEL YAPI => DEÐÝÞKEN FONKSÝYON SINIF

        /*
        GÝZLÝLÝK
        public -> projedeki her class eriþebilir. (Inspectorda görünür)
        *boþ* -> default gizlilik.  (Inspectorda görünmez)
        private -> sadece tanýmlandýðý class eriþebilir, eriþilebilirlik limitli. (Inspectorda görünmez)

        [SerializeField] => variableler inspectorda görünür hale gelir
        [System.Serialize] => yapýlar instepctorda görünür hale gelir

        ANAHTAR KELÝMELER
        const => Sabit sayýlar veya variableler için kullanýlýr
        static => bir deðiþken, fonksiyon veya sýnýfýn tek bir örneði olduðunu belirtir

        DEÐÝÞKEN TANIMLAMA
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
        -KOÞULLULAR-

        TERÝMLER
        continue => þuan ki sorgulamayý atla, diðerine geç.
        break => sorguyu, herþeyi bitir ve bu bloktan çýk.
        return x => x denen variable'ý döndür, ata. Eðer sadece "return" yazýyorsa ki bu sadece void türü fonskiyonlarda görülür, void metodunu bitir demektir.

        IF & ELSE
        if ("Koþul")
        {
            --Ýþlem--
        }
        else if ("Diðer Koþul")
        {
            --Ýþlem--
        }
        else
        {
            --Ýþlem--
        }

        SWITCH
        switch("Hangi Variable'a göre Seçim Yapýlacak")
        {
            case "Variablenin Ýstenen Deðeri":
            --Ýþlem--
            break;
        }

        -LOOPLAR-

        FOR
        for ("Sayacý yapacak variable tanýmlanmasý"; "Kaça kadar saysýn"; "Sayaç ne kadar artsýn")
        {
            --Ýþlem--
        }

        FOREACH
        foreach ("Variablenin türü" "Variable ismi" in )
        {
            --Ýþlem--
        }

        WHILE
        while ("Koþul")
        {
            --Ýþlem--
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
