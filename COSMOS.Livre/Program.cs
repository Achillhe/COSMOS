// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

string[] TabAccueil = new string[] { "1.Gestion des adhérents", "2.Gestion des livres", "3.Gestion des emprunts", "4.Quitter le programme" };
void AfficheTab(string[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.WriteLine(tab[i]);
    }

}

void AfficheTabWithCondition(string[] tab, string condition, string choix)
{
    for (int i = 0; i < tab.Length; i++)
    {
        if (choix == condition)
        {
            Console.WriteLine(tab[i]);
        }
    }

}

string DemandeChoix(string message)
{
    Console.WriteLine(message);
    string rep = Console.ReadLine();
    return rep;
}

void ExecuteMenu(string[] tab1)
{
    AfficheTab(tab1);
    var rep2 = DemandeChoix("Faites votre choix dans ce menu.");
    AfficheTabWithCondition(TabAccueil, "d", rep2);
}

AfficheTab(TabAccueil);

string rep = Console.ReadLine();

string[] StringTable = new string[] { "a.Ajouter, modifier ou supprimer un adhérent", "b.Afficher la liste des adhérents par ordre alphabétique", "c.Rechercher un adhérent par son nom et affiche l'enregistrement correspond", "d.Retour menu principal" };
string[] StringTable2 = new string[] { "a.Ajouter, modifier ou supprimer un livre", "b.Afficher la liste des livres par ordre alphabétique", "c.Rechercher le titre d'un livre et affiche l'enregistrement correspond", "d.Retour menu principal" };
string[] StringTable3 = new string[] { "a.Emprunter un livre", "b.Afficher la liste des livres empruntés", "c.Rendre un livre", "d.Afficher la liste des emprunts", "e.Retour menu principal" };

while (rep != "1" || rep != "2" || rep != "3" || rep != "4")
{
    switch (rep)
    {
        case "1":
            ExecuteMenu(StringTable);
            break;
        case "2":
            ExecuteMenu(StringTable2);
            break;
        case "3":
            ExecuteMenu(StringTable3);
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Rentrez une valeur valide !");
            break;
    }
    rep = Console.ReadLine();
}
