using UnityEngine;

public class Game : MonoBehaviour {
	public GameObject Zombie;
	private uint PCounter;
	private ushort GFPS;
	private float TimeAux;
	// Use this for initialization
	private void Start () 
	{
		GFPS = 0;
		TimeAux = 0;
		PCounter = 1;
		Human.Initialize();
	}
	
	// Update is called once per frame
	private void Update () 
	{
		GFPS++;
		if((Time.realtimeSinceStartup - TimeAux) >= 1)
		{
			TimeAux = Time.realtimeSinceStartup;
			GameOptions.ShowFPS(GFPS);
			GFPS = 0;
		}
		if(Input.GetKeyDown(KeyCode.Escape))
			PCounter++;
		if((PCounter % 2) == 0 && !GameOptions.Showing)
			GameOptions.Show();
		else if((PCounter % 2) == 1 && !GameOptions.Showing)
			GameOptions.Hide();
	}
}
