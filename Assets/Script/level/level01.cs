using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

namespace Level
{

    public class level01 : MonoBehaviour
    {
        public GameObject one, two, three, four, five, blackone, blacktwo, blackthree, blackfour, blackfive;
        public GameObject redheart1, redheart2, redheart3, failed, success;
        Vector2 oneInitialPos, twoInitialPos, threeInitialPos, fourInitialPos, fiveInitialPos;
        public static bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect;

        public int score = 0;
        public int previousscore = 0;
        public Text sscore;
        public Text Ssscore;
        public static string HScore;


        public float life = 3;
        public float previouslife = 3;
        public Text llife;

        private int time = 0;
        public Text timer;
        public Text Ttimer;

        public AudioSource source;
        public AudioClip[] correct;
        public AudioClip incorrect;


        void Start()
        {
           

            oneInitialPos = one.transform.position;
            twoInitialPos = two.transform.position;
            threeInitialPos = three.transform.position;
            fourInitialPos = four.transform.position;
            fiveInitialPos = five.transform.position;

            StartTimer();
        }

        void IncrimentTime()
        {
            time += 1;
            timer.text = time + "s";
            Ttimer.text = time.ToString();
        }

        public void StartTimer()
        {
            time = 0;
            InvokeRepeating("IncrimentTime", 1, 1);
        }

        public void StopTimer()
        {
            CancelInvoke();

        }

        public void Score()
        {
            score = previousscore + 10;
            previousscore = score;
            sscore.text = score.ToString();
            Ssscore.text = score.ToString();
            HScore = Ssscore.text;
        }
        public void Life()
        {
            life = previouslife - 1;
            previouslife = life;
            llife.text = life.ToString();
        }

        public static string score01
        {
            get
            {
                return HScore;
            }
            set
            {
                HScore = value;
            }
        }


        public void DragOne()
        {
            one.transform.position = Input.mousePosition;
        }
        public void DragTwo()
        {
            two.transform.position = Input.mousePosition;
        }
        public void DragThree()
        {
            three.transform.position = Input.mousePosition;
        }
        public void DragFour()
        {
            four.transform.position = Input.mousePosition;
        }
        public void DragFive()
        {
            five.transform.position = Input.mousePosition;
        }

        public void DropOne()
        {
            float Distance = Vector3.Distance(one.transform.position, blackone.transform.position);
            if (Distance < 50)
            {
                one.transform.position = blackone.transform.position;
                oneCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                one.transform.position = oneInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }


        }
        public void DropTwo()
        {
            float Distance = Vector3.Distance(two.transform.position, blacktwo.transform.position);
            if (Distance < 50)
            {
                two.transform.position = blacktwo.transform.position;
                twoCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                two.transform.position = twoInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropThree()
        {
            float Distance = Vector3.Distance(three.transform.position, blackthree.transform.position);
            if (Distance < 50)
            {
                three.transform.position = blackthree.transform.position;
                threeCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                three.transform.position = threeInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropFour()
        {
            float Distance = Vector3.Distance(four.transform.position, blackfour.transform.position);
            if (Distance < 50)
            {
                four.transform.position = blackfour.transform.position;
                fourCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                four.transform.position = fourInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropFive()
        {
            float Distance = Vector3.Distance(five.transform.position, blackfive.transform.position);
            if (Distance < 50)
            {
                five.transform.position = blackfive.transform.position;
                fiveCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                five.transform.position = fiveInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }




        void Update()
        {
            if (oneCorrect)
            {

                one.transform.position = blackone.transform.position;
                oneCorrect = true;

            }
            if (twoCorrect)
            {

                two.transform.position = blacktwo.transform.position;
                twoCorrect = true;
            }
            if (threeCorrect)
            {
                three.transform.position = blackthree.transform.position;
                threeCorrect = true;
            }
            if (fourCorrect)
            {
                four.transform.position = blackfour.transform.position;
                fourCorrect = true;
            }
            if (fiveCorrect)
            {

                five.transform.position = blackfive.transform.position;
                fiveCorrect = true;
            }

            if (life == 3)
            {
                redheart1.SetActive(true);
                redheart2.SetActive(true);
                redheart3.SetActive(true);
            }
            if (life == 2)
            {
                redheart1.SetActive(true);
                redheart2.SetActive(true);
                redheart3.SetActive(false);
            }
            if (life == 1)
            {
                redheart1.SetActive(true);
                redheart2.SetActive(false);
                redheart3.SetActive(false);
            }
            if (life == 0)
            {
                redheart1.SetActive(false);
                redheart2.SetActive(false);
                redheart3.SetActive(false);
                failed.SetActive(true);
            }

            if (oneCorrect && twoCorrect && threeCorrect && fourCorrect && fiveCorrect)
            {
                PlayerPrefs.SetInt("Level1_score", score);
                PlayerPrefs.SetInt("Level2", 1);
                success.SetActive(true);
                StopTimer();
            }

        }

    }

}

