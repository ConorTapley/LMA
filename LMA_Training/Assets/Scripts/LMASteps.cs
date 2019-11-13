﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LMASteps : MonoBehaviour
{
    public Button step1, step2, step3, step4, step5, step6, step7;
    public Button bottomButton1, bottomButton2, bottomButton3, bottomButton4, bottomButton5, bottomButton6, bottomButton7;
    private bool bottom1 = true, bottom2 = false, bottom3 = false, bottom4 = false, bottom5 = false, bottom6 = false, bottom7 = false;
    private bool correct1 = false, correct2 = false, correct3 = false, correct4 = false, correct5 = false, correct6 = false, correct7 = false;
    public Button currentBottomButton;
    public Sprite Blank;

    void Start()
    {
        bottomButton1.GetComponent<Image>().sprite = Blank;
        bottomButton2.GetComponent<Image>().sprite = Blank;
        bottomButton3.GetComponent<Image>().sprite = Blank;
        bottomButton4.GetComponent<Image>().sprite = Blank;
        bottomButton5.GetComponent<Image>().sprite = Blank;
        bottomButton6.GetComponent<Image>().sprite = Blank;
        bottomButton7.GetComponent<Image>().sprite = Blank;
    }

    void Update()
    {
        ChangeCurrentBottomButton();
        Win();
    }

    private void Win()
    {
        if(correct1 && correct2 && correct3 && correct4 && correct5 && correct6 && correct7)
        {
            //Debug.Log("You Win!!");
        }

        if(bottomButton1.GetComponent<Image>().sprite == step1.GetComponent<Image>().sprite)
            correct1 = true;
        else
            correct1 = false;

        if (bottomButton2.GetComponent<Image>().sprite == step2.GetComponent<Image>().sprite)
            correct2 = true;
        else
            correct2 = false;

        if (bottomButton3.GetComponent<Image>().sprite == step3.GetComponent<Image>().sprite)
            correct3 = true;
        else
            correct3 = false;

        if (bottomButton4.GetComponent<Image>().sprite == step4.GetComponent<Image>().sprite)
            correct4 = true;
        else
            correct4 = false;

        if (bottomButton5.GetComponent<Image>().sprite == step5.GetComponent<Image>().sprite)
            correct5 = true;
        else
            correct5 = false;

        if (bottomButton6.GetComponent<Image>().sprite == step6.GetComponent<Image>().sprite)
            correct6 = true;
        else
            correct6 = false;

        if (bottomButton7.GetComponent<Image>().sprite == step7.GetComponent<Image>().sprite)
            correct7 = true;
        else
            correct7 = false;
    }

    private void ChangeCurrentBottomButton()
    {
        //bottom2 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank) //<----------if the bottomButton 1 is not blank
        {
            bottom1 = false;
            bottom2 = true;
            bottom3 = false;
            bottom4 = false;
            bottom5 = false;
            bottom6 = false;
            bottom7 = false;
        }

        //bottom3 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank &&  //<----------if the bottomButton 1 + bottomButton2 are not blank
            bottomButton2.GetComponent<Image>().sprite != Blank)
        {
            bottom1 = false;
            bottom2 = false;
            bottom3 = true;
            bottom4 = false;
            bottom5 = false;
            bottom6 = false;
            bottom7 = false;
        }

        //bottom4 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank &&
            bottomButton2.GetComponent<Image>().sprite != Blank &&
            bottomButton3.GetComponent<Image>().sprite != Blank)
        {
            bottom1 = false;
            bottom2 = false;
            bottom3 = false;
            bottom4 = true;
            bottom5 = false;
            bottom6 = false;
            bottom7 = false;
        }

        //bottom5 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank &&
            bottomButton2.GetComponent<Image>().sprite != Blank &&
            bottomButton3.GetComponent<Image>().sprite != Blank &&
            bottomButton4.GetComponent<Image>().sprite != Blank)
        {
            bottom1 = false;
            bottom2 = false;
            bottom3 = false;
            bottom4 = false;
            bottom5 = true;
            bottom6 = false;
            bottom7 = false;
        }

        //bottom6 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank &&
            bottomButton2.GetComponent<Image>().sprite != Blank &&
            bottomButton3.GetComponent<Image>().sprite != Blank &&
            bottomButton4.GetComponent<Image>().sprite != Blank &&
            bottomButton5.GetComponent<Image>().sprite != Blank)
        {
            bottom1 = false;
            bottom2 = false;
            bottom3 = false;
            bottom4 = false;
            bottom5 = false;
            bottom6 = true;
            bottom7 = false;
        }

        //bottom7 = currentBottomButton
        if (bottomButton1.GetComponent<Image>().sprite != Blank &&
            bottomButton2.GetComponent<Image>().sprite != Blank &&
            bottomButton3.GetComponent<Image>().sprite != Blank &&
            bottomButton4.GetComponent<Image>().sprite != Blank &&
            bottomButton5.GetComponent<Image>().sprite != Blank &&
            bottomButton6.GetComponent<Image>().sprite != Blank)
        {
            bottom1 = false;
            bottom2 = false;
            bottom3 = false;
            bottom4 = false;
            bottom5 = false;
            bottom6 = false;
            bottom7 = true;
        }
    }

    public void OnClick1()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step1.GetComponent<Image>().sprite;
    }
    public void OnClick2()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step2.GetComponent<Image>().sprite;
    }
    public void OnClick3()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step3.GetComponent<Image>().sprite;
    }
    public void OnClick4()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step4.GetComponent<Image>().sprite;
    }
    public void OnClick5()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step5.GetComponent<Image>().sprite;
    }
    public void OnClick6()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step6.GetComponent<Image>().sprite;
    }
    public void OnClick7()
    {
        if (bottom1)
            bottomButton1.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom2)
            bottomButton2.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom3)
            bottomButton3.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom4)
            bottomButton4.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom5)
            bottomButton5.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom6)
            bottomButton6.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;

        if (bottom7)
            bottomButton7.GetComponent<Image>().sprite = step7.GetComponent<Image>().sprite;
    }

    public void OnBottomClick1()
    {
        bottomButton1.GetComponent<Image>().sprite = Blank;
        bottom1 = true;
        bottom2 = false;
        bottom3 = false;
        bottom4 = false;
        bottom5 = false;
        bottom6 = false;
        bottom7 = false;
    }
    public void OnBottomClick2()
    {
        bottomButton2.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = true;
        bottom3 = false;
        bottom4 = false;
        bottom5 = false;
        bottom6 = false;
        bottom7 = false;
    }
    public void OnBottomClick3()
    {
        bottomButton3.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = false;
        bottom3 = true;
        bottom4 = false;
        bottom5 = false;
        bottom6 = false;
        bottom7 = false;
    }
    public void OnBottomClick4()
    {
        bottomButton4.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = false;
        bottom3 = false;
        bottom4 = true;
        bottom5 = false;
        bottom6 = false;
        bottom7 = false;
    }
    public void OnBottomClick5()
    {
        bottomButton5.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = false;
        bottom3 = false;
        bottom4 = false;
        bottom5 = true;
        bottom6 = false;
        bottom7 = false;
    }
    public void OnBottomClick6()
    {
        bottomButton6.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = false;
        bottom3 = false;
        bottom4 = false;
        bottom5 = false;
        bottom6 = true;
        bottom7 = false;
    }
    public void OnBottomClick7()
    {
        bottomButton7.GetComponent<Image>().sprite = Blank;
        bottom1 = false;
        bottom2 = false;
        bottom3 = false;
        bottom4 = false;
        bottom5 = false;
        bottom6 = false;
        bottom7 = true;
    }
}
