# MonPrimeur  
MonPrimeur est une application web créer avec ASP.NET Core Razor Pages et Entity Framework Core    
  
Visual studio 2022  
.NET 6  
Projet ASP.NET Core 6  
Razor pages
#
Razor Pages est basé sur le modèle de vue-contrôleur (MVC).    
Il repose sur le même principe que MVC, mais le flux de contrôle est centré sur les pages plutôt que sur les actions.    
Les pages sont des classes qui gèrent les requêtes HTTP et qui définissent le modèle d'affichage à utiliser pour afficher le résultat.    
Les pages sont associées à des vues qui définissent le modèle d'affichage à utiliser pour afficher le résultat.
#
Configurer pour HTTPS 
Gestion d'authentification : comptes individuels pour l'inscription et la connexion    

Connected Services : exemple de service : le cloud    
Les dépendances comprennent :    
- package qui va permettre de générer la base de données et d'exécuter des requêtes
  - EntityFrameworkCore.SqlServer
- packages concernant l'authentification :    
  - AspNetCore.Identity.EntityFrameworkCore (6.0.4)    
  - AspNetCore.Identity.UI (6.0.4)   

le fichier appsettings.json qui comporte des constantes pour l'application tel que :    
la constante ConnectionStrings qui permettra de gerer la configuration de connexion à la base de données.    
 "ConnectionStrings": {    
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=mon-primeur; ..."    
 
- le fichier Program.cs : il y a le Buider qui permet d'ajouter des services    
on retrouve :    
- connectionString    
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");    
- builder.Services.AddDbContext qu'on retrouve dans le dossier Data qui est le contexte de notre base de données    

- options.SignIn.RequireConfirmedAccount = false (mis à false pour ne pas à avoir à valider l'adresse mail du compte)    
-> Par défaut il est à true et permet d'envoyer un email de confirmation de compte
