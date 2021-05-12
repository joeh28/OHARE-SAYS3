using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Advertiser : MonoBehaviour
{
    //[SerializeField]
    //private GameObject[] backImages;



    private float currentTime = 0f;
    private float startingTime = 1f;
    private float speed = .2f;
    private int imageIndex = 0;



    [SerializeField]
    private GameObject[] images;



    private void Start()
    {
        currentTime = startingTime;
    }



    private void Update()
    {
        SlideShow();
        #region Junk
        //FillHorizontalRight(0, 1);
        //FillVerticalTop(1, 2);
        //FillRadial180Left(2, 3);
        //FillRadius360Right(3, 4);
        //FillRadius90BottomRight(4, 5);
        //FillRadius90BottomLeft(5, 6);
        //FillHorizontalLeft(6, 7);
        //FillRadial180Bottom(7, 8);
        //FillVerticalBottom(8, 9);
        //FillRadius360Bottom(9, 10);
        //FillRadius90TopLeft(10, 11);
        //FillRadius360Top(11, 12);
        //FillRadius90TopRight(12, 13);
        //FillRadial180Right(13, 14);
        //FillHorizontalRight2(14, 15);
        //FillRadius360Left(15, 16);
        //FillRadius90BottomLeft2(16, 17);
        //FillRadial180Top(17, 0); 
        #endregion
    }



    private void SlideShow()
    {
        if (imageIndex == 0)
        {
            images[17].SetActive(false);
            images[0].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 1)
        {
            images[0].SetActive(false);
            images[1].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 2)
        {
            images[1].SetActive(false);
            images[2].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 3)
        {
            images[2].SetActive(false);
            images[3].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 4)
        {
            images[3].SetActive(false);
            images[4].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 5)
        {
            images[4].SetActive(false);
            images[5].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 6)
        {
            images[5].SetActive(false);
            images[6].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 7)
        {
            images[6].SetActive(false);
            images[7].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 8)
        {
            images[7].SetActive(false);
            images[8].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 9)
        {
            images[8].SetActive(false);
            images[9].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 10)
        {
            images[9].SetActive(false);
            images[10].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 11)
        {
            images[10].SetActive(false);
            images[11].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }



        if (imageIndex == 12)
        {
            images[11].SetActive(false);
            images[12].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 13)
        {
            images[12].SetActive(false);
            images[13].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 14)
        {
            images[13].SetActive(false);
            images[14].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 15)
        {
            images[14].SetActive(false);
            images[15].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 16)
        {
            images[15].SetActive(false);
            images[16].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex++;
                currentTime = startingTime;
            }
        }
        if (imageIndex == 17)
        {
            images[16].SetActive(false);
            images[17].SetActive(true);
            currentTime -= speed * Time.deltaTime;



            if (currentTime <= 0)
            {
                imageIndex = 0;
                currentTime = startingTime;
            }
        }
    }
}