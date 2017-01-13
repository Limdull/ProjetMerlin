using UnityEngine;

public abstract class Citizen : MonoBehaviour {
    private int numCitizen;
    private string nameCitizen;
    private string nickNameCitizen;
    private string sexCitizen;
    private string mailCitizen;
    // image needed.

    public  Citizen(int numCitizen, string nameCitizen, string nickNameCitizen, string sexCitizen, string mailCitizen)
    {
        this.numCitizen = numCitizen;
        this.nameCitizen = nameCitizen;
        this.nickNameCitizen = nickNameCitizen;
        this.sexCitizen = sexCitizen;
        this.mailCitizen = mailCitizen;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
