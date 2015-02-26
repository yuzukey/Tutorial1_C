using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleMenu : MonoBehaviour {

    public void OnClick() {
        Application.LoadLevel("TheGame");
    }
}
