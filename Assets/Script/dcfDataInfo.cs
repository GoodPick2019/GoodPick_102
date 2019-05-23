using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using DatabaseControl;
using UnityEngine.SceneManagement;


public class dcfDataInfo : MonoBehaviour
{

    public InputField Login_UsernameField;
    public InputField Login_PasswordField;
    public InputField Register_UsernameField;
    public InputField Register_PasswordField;
    public InputField Register_Confirm_PasswordField;

    public Text Register_ErrorText;
    public Text Login_ErrorText;
    public Text LoggedIn_DisplayUsernameText;

    private string username = "";
    private string password = "";
    private string confirm_password = "";

    public RectTransform loginView, registerView, profileView;



    void Awake()
    {
        ResetAllUIElements();
        loginView.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    void Start()
    {
        

        /*FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://goodpick-2019.firebaseio.com/"); 
        reference = FirebaseDatabase.DefaultInstance.RootReference;

        string DebugMsg = saveDataToFirebase( username, password, confirm_password);
        Debug.Log(DebugMsg);*/

    }



    void ResetAllUIElements()
    {
        Login_UsernameField.text = "";
        Login_PasswordField.text = "";
        Register_UsernameField.text = "";
        Register_PasswordField.text = "";
        Register_Confirm_PasswordField.text = "";
        LoggedIn_DisplayUsernameText.text = "";
    }

    IEnumerator Login()
    {
        Login_ErrorText.gameObject.SetActive(true);

        IEnumerator e = DCF.Login(username, password);
        while (e.MoveNext())
        {
            yield return e.Current;
        }
        string returned = e.Current as string;
        if (returned == "Success")
        {
            //Username and Password were correct. Stop showing 'Loading...' and show the LoggedIn UI. And set the text to display the username.
            ResetAllUIElements();
            SceneManager.LoadScene("main");
            LoggedIn_DisplayUsernameText.text = "Logged In As: " + username;
        }
        else
        {
            //Something went wrong logging in. Stop showing 'Loading...' and go back to LoginUI
            if (returned == "UserError")
            {
                //The Username was wrong so display relevent error message
                Login_ErrorText.text = "Error: Username not Found";
            }
            else
            {
                if (returned == "PassError")
                {
                    //The Password was wrong so display relevent error message
                    Login_ErrorText.text = "Error: Password Incorrect";
                }
                else
                {
                    //There was another error. This error message should never appear, but is here just in case.
                    Login_ErrorText.text = "Error: Unknown Error. Please try again later.";
                }
            }
        }
    }
    IEnumerator Register()
    {
        IEnumerator e = DCF.RegisterUser(username, password, confirm_password);
        while (e.MoveNext())
        {
            yield return e.Current;
        }
        string returned = e.Current as string;
        if (returned == "Success")
        {
            //Username and Password were valid. Account has been created. Stop showing 'Loading...' and show the loggedIn UI and set text to display the username.
            ResetAllUIElements();
            Register_ErrorText.text = "Successfully Registered";

        }
        else
        {
            //Something went wrong logging in. Stop showing 'Loading...' and go back to RegisterUI
            if (returned == "UserError")
            {
                //The username has already been taken. Player needs to choose another. Shows error message.
                Register_ErrorText.text = "Error: Username Already Taken";
            }
            else
            {
                //There was another error. This error message should never appear, but is here just in case.
                Register_ErrorText.text = "Error: Unknown Error. Please try again later.";
            }
        }
    }

    public void loginToAccount()
    {
        username = Login_UsernameField.text;
        password = Login_PasswordField.text;

        if (username.Length > 3)
        {
            if (password.Length > 5)
            {
                //Username and password seem reasonable. Change UI to 'Loading...'. Start the Coroutine which tries to log the player in.
                StartCoroutine(Login());
            }
            else
            {
                //Password too short so it must be wrong
                Login_ErrorText.text = "Error: Password Incorrect";
            }
        }
        else
        {
            //Username too short so it must be wrong
            Login_ErrorText.text = "Error: Username Incorrect";
        }
    }
    public void Login_RegisterButtonPressed()
    {

        loginView.DOAnchorPos(new Vector2(1316, 0), 0.25f);
        registerView.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void Register_RegisterButtonPressed()
    {

        username = Register_UsernameField.text;
        password = Register_PasswordField.text;
        confirm_password = Register_Confirm_PasswordField.text;


        if (username.Length > 3)
        {
            Register_ErrorText.text = "Successfully Registered";
            if (password.Length > 5)
            {
                //Check the two passwords entered match
                if (password == confirm_password)
                {
                    //Username and passwords seem reasonable. Switch to 'Loading...' and start the coroutine to try and register an account on the server
                    StartCoroutine(Register());
                }
                else
                {
                    //Passwords don't match, show error
                    Register_ErrorText.text = "Error: Password's don't Match";
                }
            }
            else
            {
                //Password too short so show error
                Register_ErrorText.text = "Error: Password too Short";
            }
        }
        else
        {
            //Username too short so show error
            //Register_ErrorText.text = "Error: Username too Short";
        }
    }
    public void Register_BackButtonPressed()
    {
        loginView.DOAnchorPos(new Vector2(0, 0), 0.25f);
        registerView.DOAnchorPos(new Vector2(-1189, 0), 0.25f);

    }

}

