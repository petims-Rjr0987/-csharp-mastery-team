
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  string profession;
  string objectif;
  int nbprojectcreer;
  char reponse;
  char reponse2;

  Console.WriteLine("Entrez votre profession :");
    profession = Console.ReadLine();
    Console.WriteLine("Entrez votre objectif :");
    objectif = Console.ReadLine();
    Console.WriteLine("Entrez le nombre de projets que vous avez créés :"); 
    nbprojectcreer = int.Parse(Console.ReadLine()); 
    reponse = (nbprojectcreer > 5) ? 'O' : 'N';
    if (reponse == 'O')
    {
        Console.WriteLine("Félicitations ! Vous avez créé plus de 5 projets.");
        return;
    }
    else
    {
        Console.WriteLine("N ! Vous avez créé moins de projets.");
        return;
    }
    reponse2 = (profession == "Développeur" && objectif == "Maîtriser C#") ? 'O' : 'N';
    if (reponse2 == 'O')    
    {
        Console.WriteLine("Félicitations ! Vous êtes un développeur qui souhaite maîtriser C#.");
        return;
    }
    else
    {
        Console.WriteLine("N ! Votre profession ou votre objectif ne correspond pas aux critères.");
        return;
    }   


    
