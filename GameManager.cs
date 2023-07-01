using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PC1, PC2, PC3, PC4, PC5, PC6;
    public GameObject PC7, PC8, PC9, PC10, PC11, PC12;

    public GameObject PC1_fundo, PC2_fundo, PC3_fundo, PC4_fundo, PC5_fundo, PC6_fundo;
    public GameObject PC7_fundo, PC8_fundo, PC9_fundo, PC10_fundo, PC11_fundo, PC12_fundo;


    private Vector3 PosInit_PC1, PosInit_PC2, PosInit_PC3, PosInit_PC4, PosInit_PC5, PosInit_PC6;
    private Vector3 PosInit_PC7, PosInit_PC8, PosInit_PC9, PosInit_PC10, PosInit_PC11, PosInit_PC12;

    // Start is called before the first frame update
    void Start()
    {
        PosInit_PC1 = PC1.transform.position;
        PosInit_PC2 = PC2.transform.position;
        PosInit_PC3 = PC3.transform.position;
        PosInit_PC4 = PC4.transform.position;
        PosInit_PC5 = PC5.transform.position;
        PosInit_PC6 = PC6.transform.position;
        PosInit_PC7 = PC7.transform.position;
        PosInit_PC8 = PC8.transform.position;
        PosInit_PC9 = PC9.transform.position;
        PosInit_PC10 = PC10.transform.position;
        PosInit_PC11 = PC11.transform.position;
        PosInit_PC12 = PC12.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //PC1
    public void DropPC1()
    {
        float distance = Vector3.Distance(PC1.transform.position, PC1_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            PC1.transform.position = PC1_fundo.transform.position;
            PC1.transform.localScale = PC1_fundo.transform.localScale;
        }
        else
        {
            PC1.transform.position = PosInit_PC1;
        }
    }
        public void DragPC1()
        {
            PC1.transform.position = Input.mousePosition;
        }

    //PC2
    public void DropPC2()
    {
        float distance = Vector3.Distance(PC2.transform.position, PC2_fundo.transform.position);
        if (distance < 10)
        {
            PC2.transform.position = PC2_fundo.transform.position;
            PC2.transform.localScale = PC2_fundo.transform.localScale;
        }
        else
        {
            PC2.transform.position = PosInit_PC2;
        }
    }
            public void DragPC2()
            {
                PC2.transform.position = Input.mousePosition;
            }

    //PC3
    public void DropPC3()
    {
        float distance = Vector3.Distance(PC3.transform.position, PC3_fundo.transform.position);
        if (distance < 10)
        {
            PC3.transform.position = PC3_fundo.transform.position;
            PC3.transform.localScale = PC3_fundo.transform.localScale;
        }
        else
        {
            PC3.transform.position = PosInit_PC3;
        }
    }
                public void DragPC3()
                {
                    PC3.transform.position = Input.mousePosition;
                }

    //PC4
    public void DropPC4()
    {
        float distance = Vector3.Distance(PC4.transform.position, PC4_fundo.transform.position);
        if (distance < 10)
        {
            PC4.transform.position = PC4_fundo.transform.position;
            PC4.transform.localScale = PC4_fundo.transform.localScale;
        }
        else
        {
            PC4.transform.position = PosInit_PC4;
        }
    }
                    public void DragPC4()
                    {
                        PC4.transform.position = Input.mousePosition;
                    }

    //PC5
    public void DropPC5()
    {
        float distance = Vector3.Distance(PC5.transform.position, PC5_fundo.transform.position);
        if (distance < 10)
        {
            PC5.transform.position = PC5_fundo.transform.position;
            PC5.transform.localScale = PC5_fundo.transform.localScale;
        }
        else
        {
            PC5.transform.position = PosInit_PC5;
        }
    }
                        public void DragPC5()
                        {
                            PC5.transform.position = Input.mousePosition;
                        }

    //PC6
    public void DropPC6()
    {
        float distance = Vector3.Distance(PC6.transform.position, PC6_fundo.transform.position);
        if (distance < 10)
        {
            PC6.transform.position = PC6_fundo.transform.position;
            PC6.transform.localScale = PC6_fundo.transform.localScale;
        }
        else
        {
            PC6.transform.position = PosInit_PC6;
        }
    }
                            public void DragPC6()
                            {
                                PC6.transform.position = Input.mousePosition;
                            }

    //PC7
    public void DropPC7()
    {
        float distance = Vector3.Distance(PC7.transform.position, PC7_fundo.transform.position);
        if (distance < 10)
        {
            PC7.transform.position = PC7_fundo.transform.position;
            PC7.transform.localScale = PC7_fundo.transform.localScale;
        }
        else
        {
            PC7.transform.position = PosInit_PC7;
        }
    }
                            public void DragPC7()
                            {
                                PC7.transform.position = Input.mousePosition;
                            }

    //PC8
    public void DropPC8()
    {
        float distance = Vector3.Distance(PC8.transform.position, PC8_fundo.transform.position);
        if (distance < 10)
        {
            PC8.transform.position = PC8_fundo.transform.position;
            PC8.transform.localScale = PC8_fundo.transform.localScale;
        }
        else
        {
            PC8.transform.position = PosInit_PC8;
        }
    }
                            public void DragPC8()
                            {
                                PC8.transform.position = Input.mousePosition;
                            }

    //PC9
    public void DropPC9()
    {
        float distance = Vector3.Distance(PC9.transform.position, PC9_fundo.transform.position);
        if (distance < 10)
        {
            PC9.transform.position = PC9_fundo.transform.position;
            PC9.transform.localScale = PC9_fundo.transform.localScale;
        }
        else
        {
            PC9.transform.position = PosInit_PC9;
        }
    }
                            public void DragPC9()
                            {
                                PC9.transform.position = Input.mousePosition;
                            }

    //PC10
    public void DropPC10()
    {
        float distance = Vector3.Distance(PC10.transform.position, PC10_fundo.transform.position);
        if (distance < 10)
        {
            PC10.transform.position = PC10_fundo.transform.position;
            PC10.transform.localScale = PC10_fundo.transform.localScale;
        }
        else
        {
            PC10.transform.position = PosInit_PC10;
        }
    }
                            public void DragPC10()
                            {
                                PC10.transform.position = Input.mousePosition;
                            }

    //PC11
    public void DropPC11()
    {
        float distance = Vector3.Distance(PC11.transform.position, PC11_fundo.transform.position);
        if (distance < 10)
        {
            PC11.transform.position = PC11_fundo.transform.position;
            PC11.transform.localScale = PC11_fundo.transform.localScale;
        }
        else
        {
            PC11.transform.position = PosInit_PC11;
        }
    }
                            public void DragPC11()
                            {
                                PC11.transform.position = Input.mousePosition;
                            }

    //PC12
    public void DropPC12()
    {
        float distance = Vector3.Distance(PC12.transform.position, PC12_fundo.transform.position);
        if (distance < 10)
        {
            PC12.transform.position = PC12_fundo.transform.position;
            PC12.transform.localScale = PC12_fundo.transform.localScale;
        }
        else
        {
            PC12.transform.position = PosInit_PC12;
        }
    }
                            public void DragPC12()
                            {
                                PC12.transform.position = Input.mousePosition;
                            }
                        }
       
