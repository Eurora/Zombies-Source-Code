using UnityEngine;

public static class Human 
{
	private static GameObject GOH;
	public static byte Life;
	
	public static void Initialize()
	{
		Life = 255;
		GOH = GameObject.FindGameObjectWithTag("Player");
		GameObject mc = GameObject.FindGameObjectWithTag("MainCamera");
		mc.transform.parent = GOH.transform;
	}
}