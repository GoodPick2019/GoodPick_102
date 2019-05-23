using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


namespace Level
{


    public class level03 : MonoBehaviour
    {
        public GameObject one, two, three, four, five, six, seven, eight, nine, ten, oneblack, twoblack, threeblack, fourblack, fiveblack, sixblack, sevenblack, eightblack, nineblack, tenblack;
        public GameObject redheart1, redheart2, redheart3, failed, success;
        Vector2 oneInitialPos, twoInitialPos, threeInitialPos, fourInitialPos, fiveInitialPos, sixInitialPos, sevenInitialPos, eightInitialPos, nineInitialPos, tenInitialPos;
        public static bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect, sixCorrect, sevenCorrect, eightCorrect, nineCorrect, tenCorrect;

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
            sixInitialPos = six.transform.position;
            sevenInitialPos = seven.transform.position;
            eightInitialPos = eight.transform.position;
            nineInitialPos = nine.transform.position;
            tenInitialPos = ten.transform.position;

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

        public static string score03
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
        public void DragSix()
        {
            six.transform.position = Input.mousePosition;
        }
        public void DragSeven()
        {
            seven.transform.position = Input.mousePosition;
        }
        public void DragEight()
        {
            eight.transform.position = Input.mousePosition;
        }
        public void DragNine()
        {
            nine.transform.position = Input.mousePosition;
        }
        public void DragTen()
        {
            ten.transform.position = Input.mousePosition;
        }

        public void DropOne()
        {
            float Distance = Vector3.Distance(one.transform.position, oneblack.transform.position);
            if (Distance < 50)
            {
                one.transform.position = oneblack.transform.position;
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
            float Distance = Vector3.Distance(two.transform.position, twoblack.transform.position);
            if (Distance < 50)
            {
                two.transform.position = twoblack.transform.position;
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
            float Distance = Vector3.Distance(three.transform.position, threeblack.transform.position);
            if (Distance < 50)
            {
                three.transform.position = threeblack.transform.position;
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
            float Distance = Vector3.Distance(four.transform.position, fourblack.transform.position);
            if (Distance < 50)
            {
                four.transform.position = fourblack.transform.position;
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
            float Distance = Vector3.Distance(five.transform.position, fiveblack.transform.position);
            if (Distance < 50)
            {
                five.transform.position = fiveblack.transform.position;
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
        public void DropSix()
        {
            float Distance = Vector3.Distance(six.transform.position, sixblack.transform.position);
            if (Distance < 50)
            {
                six.transform.position = sixblack.transform.position;
                sixCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                six.transform.position = sixInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropSeven()
        {
            float Distance = Vector3.Distance(seven.transform.position, sevenblack.transform.position);
            if (Distance < 50)
            {
                seven.transform.position = sevenblack.transform.position;
                sevenCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                seven.transform.position = sevenInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropEight()
        {
            float Distance = Vector3.Distance(eight.transform.position, eightblack.transform.position);
            if (Distance < 50)
            {
                eight.transform.position = eightblack.transform.position;
                eightCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                eight.transform.position = eightInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropNine()
        {
            float Distance = Vector3.Distance(nine.transform.position, nineblack.transform.position);
            if (Distance < 50)
            {
                nine.transform.position = nineblack.transform.position;
                nineCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                nine.transform.position = nineInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }
        public void DropTen()
        {
            float Distance = Vector3.Distance(ten.transform.position, tenblack.transform.position);
            if (Distance < 50)
            {
                ten.transform.position = tenblack.transform.position;
                tenCorrect = true;
                Score();
                source.clip = correct[UnityEngine.Random.Range(0, correct.Length)];
                source.Play();
            }
            else
            {
                ten.transform.position = tenInitialPos;
                Life();
                source.clip = incorrect;
                source.Play();
            }
        }

        void Update()
        {
            if (oneCorrect)
            {
                one.transform.position = oneblack.transform.position;
                oneCorrect = true;
            }
            if (twoCorrect)
            {
                two.transform.position = twoblack.transform.position;
                twoCorrect = true;
            }
            if (threeCorrect)
            {
                three.transform.position = threeblack.transform.position;
                threeCorrect = true;
            }
            if (fourCorrect)
            {
                four.transform.position = fourblack.transform.position;
                fourCorrect = true;
            }
            if (fiveCorrect)
            {
                five.transform.position = fiveblack.transform.position;
                fiveCorrect = true;
            }
            if (sixCorrect)
            {
                six.transform.position = sixblack.transform.position;
                sixCorrect = true;
            }
            if (sevenCorrect)
            {
                seven.transform.position = sevenblack.transform.position;
                sevenCorrect = true;
            }
            if (eightCorrect)
            {
                eight.transform.position = eightblack.transform.position;
                eightCorrect = true;
            }
            if (nineCorrect)
            {
                nine.transform.position = nineblack.transform.position;
                nineCorrect = true;
            }
            if (tenCorrect)
            {
                ten.transform.position = tenblack.transform.position;
                tenCorrect = true;
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

            if (oneCorrect && twoCorrect && threeCorrect && twoCorrect && fourCorrect && twoCorrect && fiveCorrect && sixCorrect && sevenCorrect && eightCorrect && nineCorrect && tenCorrect)
            {
                PlayerPrefs.SetInt("Level3_score", score);
                PlayerPrefs.SetInt("Level4", 1);
                success.SetActive(true);
                StopTimer();
            }
        }


    }


}



