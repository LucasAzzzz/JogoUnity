                source code Gamux2

var skin: GUISkin;
        function Update() {
}
        function On GUI(){
    GUi.skin = Skin;
        if (GUI.Button(Rect(Screen.width / 2, Screen.height / 2, 90, 90) "COME�AR")) {
        Application.LoadLevel("Jogo1");
    }
                            
        if (GUI.Button(Rect(Screen.width / 2, Screen.height / 2 + 90, 90, 90,), "CONFIGURA��ES")) {
        Application.LoadLevel("Configura��esAudio1");
    }
         if (GUI.Button(Rect(Screen.width / 2, Screen.height / 2 + 90, 90, 90, 90), "SAIR")) {
    Application.Quit();
}
       
}