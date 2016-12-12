using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class RebelCitizen : Citizen {
   private List<Array> behaviour = new List<Array>();

    public RebelCitizen(int numCitizen, string nameCitizen, string nickNameCitizen, string sexCitizen, string mailCitizen) : base(numCitizen, nameCitizen, nickNameCitizen, sexCitizen, mailCitizen)
    {
        this.numCitizen = numCitizen;
        this.nameCitizen = nameCitizen;
        this.nickNameCitizen = nickNameCitizen;
        this.sexCitizen = sexCitizen;
        this.mailCitizen = mailCitizen;
    }
    //gestion du comportement du citoyen (enchainement d'animation régler sur le temps d'une journée de surveillance ex: 8h = animationRéveil , 9h animationMarche puis travail)
    //gestion du portrait du citoyen , sauvegarder dans une variable
 
}

