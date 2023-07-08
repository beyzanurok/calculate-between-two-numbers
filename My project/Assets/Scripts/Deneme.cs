using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //start anında bilgi olarak terminale yazar
        int sayi1 = -36;
        int sayi2 = 85;
        //kalabalık olmasın diye secim aldigimizi varsayalim
        int secim = 5;


        if (secim == 1)
        {
            ButunDeger(sayi1, sayi2);
        }
        else if (secim == 2)
        {
            IkiyeBolum(sayi1, sayi2);
        }
        else if (secim == 3)
        {
            UceBolum(sayi1, sayi2);
        }

        else if (secim == 4)
        {
            DordeBolum(sayi1, sayi2);
        }
        else if (secim == 5)
        {
            BeseBolum(sayi1, sayi2);
        }


    }
    void ButunDeger(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            print(i);
        }
    }
    void IkiyeBolum(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 2 == 0)
            {
                print(i);
            }
        }
    }
    void UceBolum(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 3 == 0)
            {
                print(i);
            }
        }
    }
    void DordeBolum(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 4 == 0)
            {
                print(i);
            }
        }
    }
    void BeseBolum(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 5 == 0)
            {
                print(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ilave olarak bilgilendirici açıklamalar
    }
}
