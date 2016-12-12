using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    class NormalCitizen : Citizen
    {
    private List<Array> behaviour = new List<Array>();

    public NormalCitizen(int numCitizen, string nameCitizen, string nickNameCitizen, string sexCitizen, string mailCitizen) : base(numCitizen, nameCitizen, nickNameCitizen, sexCitizen, mailCitizen)
    {
        this.numCitizen = numCitizen;
        this.nameCitizen = nameCitizen;
        this.nickNameCitizen = nickNameCitizen;
        this.sexCitizen = sexCitizen;
        this.mailCitizen = mailCitizen;
    }
}

