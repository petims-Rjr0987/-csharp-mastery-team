string ?name;
int ?age;
string ?origin;
 string ?profession; 
  string?objectif;
  int ?  nbprojectcreer;
  char reponse;
  char reponse2;





















  Console.Write("Entrez votre profession :");
    profession = Console.ReadLine();
    Console.WriteLine("Entrez votre objectif :");
    objectif = Console.ReadLine();
    Console.Write("Entrez le nombre de projets que vous avez créés :"); 
    nbprojectcreer = Convert.ToInt32(Console.ReadLine());   
    reponse = (nbprojectcreer > 5) ? 'O' : 'N';
    if (reponse == 'O')
    {
        Console.Write("Félicitations ! Vous avez créé plus de 5 projets.");
        ;
    }
    else
    {
        Console.Write("N ! Vous avez créé moins de projets.");
        ;
    }
    reponse2 = (profession == "" && objectif == "") ? '0' : 'n';
    if (reponse2 == '0')    
    {
        Console.Write("Félicitations ! Vous êtes un développeur qui souhaite maîtriser C#.");
        return;
    }
    else
    {
        Console.Write("N ! Vous n'avez pas rempli les champs de profession et d'objectif.");
        return;
    }


    
