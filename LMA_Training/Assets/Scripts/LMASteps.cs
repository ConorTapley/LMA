using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LMASteps : MonoBehaviour
{
    public Button step1, step2, step3, step4, step5, step6, step7;
    public Button bottomButton1, bottomButton2, bottomButton3, bottomButton4, bottomButton5, bottomButton6, bottomButton7;
    [SerializeField] private bool bottom1 = true, bottom2 = false, bottom3 = false, bottom4 = false, bottom5 = false, bottom6 = false, bottom7 = false;
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
        //CurrentBottomButton();
        ChangeCurrentBottomButton();
    }

    private void CurrentBottomButton()
    {
        if (bottom1)
            currentBottomButton = bottomButton1;

        if (bottom2)
            currentBottomButton = bottomButton2;

        if (bottom3)
            currentBottomButton = bottomButton3;

        if (bottom4)
            currentBottomButton = bottomButton4;

        if (bottom5)
            currentBottomButton = bottomButton5;

        if (bottom6)
            currentBottomButton = bottomButton6;

        if (bottom7)
            currentBottomButton = bottomButton7;
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
        if(bottom1)
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
}
