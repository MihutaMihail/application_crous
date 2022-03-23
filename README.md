# **Application-CROUS**

# (Problèmes)
Lors du clônage si l'application ne marche pas, il existe quelques solutions a mettre en place <br>
**•** Il faut définir **VIEW** comme projet de démarrage <br>
→ Clique-droit sur le projet **VIEW** et on clique sur **Set as Startup Project**<br>
**•** Dans le dossier **DAO** → **Bin** → **Debug** il faut mettre **MySql.Data.dll** <br>
→ Lors du clônage ce fichier n'est pas présent<br>
**•** Générer les **dll** pour **DAO** et **MODEL** <br>
→ Lors du clônage, ces dll ne fonctionne plus (même s'il sont présent). Il faut générer les dll et aller dans les **References** des classes **DAO** et **VIEW** pour bien vérifier qu'il fonctionne.<br>
**•** Installer le nugget **Renci.SshNet.Async**<br>
→ Des fois on peut avoir une problème comme si un nugget **Renci** n'existe pas. Pour résoudre ce problème il faut <br>
Clique-droit sur **VIEW** → **Manage NuGet Packages** → Chercher **Renci.SshNet.Async** → Installer

# Contexte
Le C.R.O.U.S (Centre Régional de Oeuvres Universitaires et Scolaires) est un établissement public placé sous la tutelle du Ministère de l'Enseignement supérieur. Il a pour mission d'améliorer les conditions de vie et de travail des étudiants de l'académie de Créteil.

L'une des missions principales est le logement des étudiants. Il propose aux éleves habitant en colocation une application mieux organiser leur dépenses et donc leur budget.

# Outils mis en oeuvre
Pour réaliser ce projet on a mis en oeuvre plusiers outils :
1. Visual Studio 2017 (Windows Form, C#, ado.net)
2. Visual Studio Code (PlantUML)
3. Git 
4. MySQL (pour la base de données)

# Composants logiciels à développer

## 1. Gérer les colocataires
### Objectif 
**•** L'objectif est de tenir en compte toutes les colocataires qui utilisent l'application ainsi que modifier ou supprimer un colocataire si besoin.
### Cas Utilisation - Gérer les colocataires
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c
package GerezLesColocataires{
    usecase "Ajouter un colocataire" as UC1
    usecase "Modifier un colocataire" as UC2
    usecase "Supprimer un colocataire" as UC3
}
c --> UC1
c --> UC2
c --> UC3
@enduml
```
### Maquette - Gérer les colocataires
![Menu.JPG](./View/Images_Maquettes/Menu.JPG)
![GestionColocataires.JPG](./View/Images_Maquettes/GestionColocataires.JPG)
![AjouterColocataire.JPG](./View/Images_Maquettes/AjouterColocataire.JPG)
![ModifierColocataire.JPG](./View/Images_Maquettes/ModifierColocataire.JPG)
![creationCompte.JPG](./View/Images_Maquettes/creationCompte.JPG)

### Enchaînement Textuel - Gérer les colocataires
**•** <i> **Consulter la liste des colocataires** </i> <br>
    1. On clique sur le bouton **Gestion des Colocataires** pour consulter les colocataires existant. <br>
<br>
**•** <i> **Ajouter un colocataire** </i> <br>
    1. On clique sur le bouton **Gestion des Colocataires** pour accéder au gestion des colocataires. <br>
    2. On clique sur le bouton **AJOUTER** pour ajouter un nouveau colocataire. <br>
    3. On complète les champs (nom, prénom, age, adresse mail, n° tel , n° appartement).<br>
    4. On cliquer sur le bouton **Valider** pour ajouter le nouveau colocataire dans la liste <br>
    5. Une fenêtre va apparaître qui va nous demander de saisir un identifiant et un mot de passe pour le colocataire ajouté pour lui créer un compte et donc pouvoir se connecter. <br>
<br>
**•** <i> **Modifier un colocataire** </i> <br>
    1. On clique sur le colocataire qu'on veut modifier. <br>
    2. On clique sur le bouton **MODIFIER**.<br> 
    3. On modifie les données qu'on a besoin de modifier <br>
    4. On clique sur le bouton **Valider** pour valider les modifications. <br>
<br>
**•** <i> **Supprimer un colocataire** </i> <br>
    1. On clique sur le colocataire qu'on veut supprimer. <br>
    2. On clique sur le bouton **SUPPRIMER**.<br>
<br>

## 2. Enregistrer les dépenses
### Objectif
→ L'objectif est d'enregistrer toutes les dépenses faite par chaque colocataire ainsi que les modifier en cas de besoin.

### Cas Utilisation - Enregistrer les dépenses
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c

package EnregistrerLesDépenses {
    usecase "Saisir une dépense" as UC1
    usecase "Modifier une dépense" as UC2 
    usecase "Supprimer une dépense" as UC3
    usecase "Justifier une dépense" as JD
}
c --> UC1
c --> UC2
c --> UC3
JD .> UC1 : <<extends>>
JD .> UC2 : <<extends>>
@enduml
```
### Maquette - Enregistrer les dépenses
![Menu.JPG](./View/Images_Maquettes/Menu.JPG)
![GestionDepenses.JPG](./View/Images_Maquettes/GestionDepenses.JPG)
![AjouterDepense.JPG](./View/Images_Maquettes/AjouterDepense.JPG)
![ModifierDepense.JPG](./View/Images_Maquettes/ModifierDepense.JPG)
![justificatif.JPG](./View/Images_Maquettes/justificatif.JPG)
![reparti.JPG](./View/Images_Maquettes/reparti.JPG)
### Enchaînement Textuel - Enregistrer les dépenses
**•** <i> **Consulter la liste des dépenses** </i> <br>
    1. On clique sur le bouton **Gestion des Dépenses** pour consulter les dépenses existantes. <br>
<br>
**•** <i> **Ajouter une dépense** </i> <br>
    1. On clique sur le bouton **Gestion des Dépenses** pour accéder au gestion des dépenses. <br>
    2. On clique sur le bouton **AJOUTER** pour ajouter une nouvelle dépense. <br>
    3. On complète les champs (date,titre,justificatif,montant,colocataire) ("justificatif" nous permet de choisir un fichier image (jpg,png,etc))<br>
    3a. Le bouton "Afficher" permet de visualer l'image qui a été ajouté par le bouton "Select". <br>
    4. On clique sur le bouton **Valider** pour ajouter la nouvelle dépense dans la liste. <br>

**•** <i> **Modifier une dépense** </i> <br>
    1. On clique sur la dépense qu'on veut modifier. <br>
    2. On clique sur le bouton **MODIFIER**.<br>
    3. On modifie les données qu'on a besoin de modifier. <br>
    4. On clique sur le bouton **Valider** pour valider les modifications. <br>
    *. (les dépenses réparti ne sont plus modifiables) <br>
    **ATTENTION. Quand on clique sur "MODIFIER" pour une dépense, le colocataire ne s'affiche plus. Pour être capable de modifier la dépenses, il faut rechoisir le colocataire** <br>

**•** <i> **Supprimer une dépense** </i> <br>
    1. On clique sur la dépense qu'on veut supprimer <br>
    2. On clique sur le bouton **SUPPRIMER** <br>

**•** <i> **Répartir une dépense** </i> <br>
    → Quand on solde une période, depuis la mise en répartition, toutes les dépenses vont être réparti. Les dépenses qui ont été réparti, elles ne sont plus modifiables. Le seul chose qu'on peut faire c'est de visualiser l'image choisi au moment de la création de la dépense. (ces dépenses la ne sont plus prises en compte pour le calcul pour la mise en répartition)<br>

## 3. Mise en répartition
### Objectif
→ L'objectif de la mise en répartition est de calculer le montant que chaque personne a payé, aurait du payer et les soldes à régler sur une certaine période (c'est les colocataires qui choisissent quand ils veulent lancer la répartition). Une fois calculé, ces données vont être afficher dans un tableau pour que la personne soit capable de le visualer.
### Cas Utilisation - Mise en répartition
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c

package MiseEnRépartition{
    usecase "Lancer la répartition" as UC1
    usecase "Visualiser la répartition" as UC2
    usecase "Calculer la répartition" as UC3
}
c --> UC1
UC1 --> UC2
UC3 <. UC1 : <<include>>
@enduml
```
### Maquette - Mise en répartition
![Menu.JPG](./View/Images_Maquettes/Menu.JPG)
![CalculerRepartition.JPG](./View/Images_Maquettes/CalculerRepartition.JPG)
### Enchaînement Textuel - Mise en répartition
**•** <i> **Mise en répartition** </i> <br>
    1. On clique sur le bouton **Mise en répartition** pour lancer la mise en répartition. <br>
    2. Ceci va calculer le montant payé par chaque colocataire, le montant qu'ils aurait dû payer et les soldes à régler.<br>
    **ATTENTION. Pour le moment les dépenses affiche la mise en répartition de tous les colocataires. Normalement c'est censé afficher la mise en répartiion que pour les colocataires dans la même appartement. De cette façon les colocataires qui n'habitent dans le même appartement ne peuvent pas voir les dépenses des autres colocataires.**<br>

## 4. Solder une période
### Objectif
→ L'objectif de solder une période est de répartir les dépenses pour qu'ils ne sont pris plus en compte lors de la prochaine répartition.
### Cas Utilisation - Solder une période
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c

package SolderUnePériode {
    usecase "Solder une période" as UC1
    usecase "Lancer la répartition" as UC2
    usecase "Répartir les dépenses" as UC3
}
c --> UC1
UC1 .> UC2 : <<include>>
UC1 --> UC3

@enduml
```
### Maquette - Solder une période
![CalculerRepartition.JPG](./View/Images_Maquettes/CalculerRepartition.JPG)
![SolderPeriodeAttention.JPG](./View/Images_Maquettes/SolderPeriodeAttention.JPG)
![PeriodeSolder.JPG](./View/Images_Maquettes/PeriodeSolder.JPG)
![SolderUnePeriode.JPG](./View/Images_Maquettes/SolderUnePeriode.JPG)
### Enchaînement Textuel - Solder une période
**•** <i> **Solder une période** </i> <br>
    1. Une fois que la mise en répartition est fini, on clique sur le bouton **Solder une Période**. <br>
    2. Une fenêtre va apparaître en disant si on est sûr de solder cette période. Dans le cas où on a cliqué sur le bouton **Solder une Période** sans faire exprès, on peut répondre **non** et le soldage de la période va être annuler. Si on veut continuer on clique sur **oui**.<br>
    3. Un message disant que la période a été soldé va apparaître. <br>
    4. La mise en répartition va être lancer et si tout s'est bien passé, toutes les valeurs dans le tableau vont être 0€ puisqu'on prend plus en compte ces dépenses. <br>

## 5. Connexion
### Objectif
→ L'objectif est de pouvoir se connecter en tant que admin ou un colocataire pour prévenir les colocataires d'ajouter de nouveaux colocataires ou d'ajouter/modifier/supprimer des dépenses qui ne leur appartient pas
### Cas Utilisation - Connexion
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c
actor Admin as a

package Connexion {
    usecase "Connecter" as UC1
    usecase "Accèder à la gestion des dépenses (chaque colocataire voit que ses propres dépenses)" as UC2
    usecase "Accèder à la mise en répartition (Colocataire : que dans son appartement)" as UC3
    usecase "Accèder à la gestion des colocataires" as UC4
}
c --> UC1
UC1 --> UC2 : peut
UC1 --> UC3 : peut
a --|> c
a --> UC4 : peut

@enduml
```
### Maquette - Connexion
![Menu.JPG](./View/Images_Maquettes/Menu.JPG)
![connexion.JPG](./View/Images_Maquettes/connexion.JPG)
![MenuConnecterAdmin.JPG](./View/Images_Maquettes/MenuConnecterAdmin.JPG)
![MenuConnecterColocataire.JPG](./View/Images_Maquettes/MenuConnecterColocataire.JPG)

### Enchaînement Textuel - Connexion
**•** <i> **Connexion** </i> <br>
    1. On clique sur le bouton **Connexion** pour se connecter. <br>
    2. Une fenêtre va apparaître qui va nous permettre a mettre nos identifiants pour se connecter en tant que admin ou colocataire. <br>
    2a. Pour se connecter en tant que colocataire, il faut que l'admin créer un compte pour ce colocataire. (identifiant : siojjr / password : siojjr) <br> 
    3. Une fois connecté, on peut accèder à la gestion des colocataires (admin) ou à la gestion des dépenses/mise en répartition (admin,colocataire) <br>
    **ATTENTION. Pour le moment, l'admin n'a pas l'accès aux dépenses des colocataires. Il y a que les colotaires qu'ils peuvent voir leur propres dépenses.** <br>

## 6. Gérer les logs
### Objectif
→ L'objectif des logs est de sauvergarder chaque action faite par chaque utilisateur pour savoir qu'est-ce qu'ils ont fait, a quel heure, etc.
### Cas Utilisation - Gérer les logs
```plantuml
@startuml model1
scale 1
left to right direction
actor Colocataire as c

package Logs {
    usecase "Faire une action" as UC1
    usecase "Sauvegarder dans la base de données l'action faite" as UC2
}

c --> UC1
UC2 .> UC1 : <<include>>


@enduml
```
### Maquette - Gérer les logs
![Logs.JPG](./View/Images_Maquettes/Logs.JPG)

# Base de données
```plantuml
@startuml model1
scale 1

class Depenses {
  id : INT
  dateDepense : DATE
  titre : VARCHAR[20]
  justificatif : VARCHAR[100]
  montant : FLOAT
  reparti : TINYINT[1]
  idColocataire : INT
  PRIMARY KEY (idDepense)
  FOREIGN KEY (idColocataire) REFERENCES Colocataire(idColocataire)
}

class Colocataire {
    id : INT
    nom : VARCHAR[20]
    prenom : VARCHAR[20]
    age : INT
    numTel : INT
    adresseMail : VARCHAR[50]
    appartement : TINYINT[1]
    PRIMARY KEY (idColocataire)
}

class Compte {
    login : VARCHAR[15]
    password : VARCHAR[15]
    nomColocatare : VARCHAR[20]
    PRIMARY KEY (login)
    UNIQUE KEY (login, password);
}

class Logs {
    id : INT
    identifiant : VARCHAR[50]
    adresseIp : VARCHAR[50]
    dateLog : DateTime
    action : VARCHAR[100]
    PRIMARY KEY (id)
}

Colocataire -> Depenses : "1"   effectue   "*"
Colocataire -d-> Compte : "1" possède "1"
Colocataire -l-> Logs : "1" possède "*"
@enduml
```

### Voici le script SQL
```
USE mysql;
drop database if exists crous;
CREATE DATABASE crous;
USE crous;

 CREATE TABLE Colocataire (
    id INTEGER(10) NOT NULL AUTO_INCREMENT,
    nom VARCHAR(20),
    prenom VARCHAR(20),
    age INTEGER(3),
    numTel INTEGER(10),
    adresseMail VARCHAR(50),
    appartement TINYINT,
    PRIMARY KEY (id)
) ENGINE = InnoDB;

CREATE TABLE Depenses (
    id INTEGER(10) NOT NULL AUTO_INCREMENT,
    dateDepense DATE,
    titre VARCHAR(20),
    justificatif VARCHAR(100),
    montant FLOAT,
    reparti TINYINT,
    idColocataire INTEGER(10) NOT NULL,
    PRIMARY KEY (id)
) ENGINE = InnoDB;

CREATE TABLE Compte (
    login VARCHAR(15) NOT NULL,
    password VARCHAR(15) NOT NULL,
    nomColocataire VARCHAR(20) NOT NULL,
    PRIMARY KEY (login)
) ENGINE = InnoDB;

CREATE TABLE Logs (
    id INTEGER(10) NOT NULL AUTO_INCREMENT,
    identifiant VARCHAR(50),
    adresseIp VARCHAR(50),
    dateLog DATETIME,
    action VARCHAR(100),
    PRIMARY Key (id)
) ENGINE = InnoDB;

ALTER TABLE Depenses ADD CONSTRAINT fk_Colocataire_A_Depenses FOREIGN KEY (idColocataire) REFERENCES Colocataire(id);
ALTER TABLE Compte ADD CONSTRAINT login UNIQUE(login);
ALTER TABLE Compte ADD CONSTRAINT password_unique UNIQUE(password);
```


# Diagramme de Classe
```plantuml
@startuml model1
scale 1

class Depense {
    - id : int
    - date : dateTime
    - titre : string
    - justificatif : string
    - montant : double
    - reparti : bool
    - idColocataire : int
    - state : State
    + int Id() : int
    + DateTime Date() : DateTime
    + string Titre() : string
    + string Justificatif() : string
    + double Montant() : double
    + bool Reparti() : bool
    + int IdColocataire() : int
    + State state() : State
    + Depense (int id,DateTime date, string titre, string justificatif, double montant, bool reparti,int idColocataire, State state)
    + Depense (int id,DateTime date, string titre, string justificatif, double montant,int idColocataire, State state)
    + void Remove() : void
    + string ToString() : string

}
class Depenses {
    - List<Depense> lesDepenses
    + int Count() : int
    + Depense this[(int index)] : Depense
    + void AjouterDepense(Depense nouvelleDepense) : void
    + void SupprimerDepense(Depense depense) : void
    + double Apayer(int idColocataire) : double
    + double AuraitDuPayer() : double
}

class Colocataire {
    - id : int
    - nom : string
    - prenom : string
    - age : int
    - numTel : int
    - adresseMail : string
    - appartement : int
    - state : State
    + int Id() : int
    + string Nom() : string
    + string Prenom() : string
    + int Age() : int
    + int NumTel() : int
    + string AdresseMail() : string
    + int Appartement() : int
    + State state() : State
    + Colocataire(int id, string nom, string prenom, int age, int numTel, string adresseMail, State state) : void
    + void Remove() : void
    + string ToString() : string
}
class Colocataires {
    - List<Colocataire> lesColocataires
    + int Count() : int
    + Colocataire this[(int index)] : Colocataire
    + void AjouterColocataire(Colocataire nouveauColocataire) : void
    + void SupprimerColocataire(Colocataire colocataire) : void
    + int GetIndex(string nom) : int
    + int GetIndex(int index) : int
    + string GetNom(int index) : string
}

class Compte {
    - login : string
    - password : string
    - nomColocataire : string
    + string Login() : string
    + string Password() : string
    + string NomColocataire() : string
    + Compte(string login, string password, string nomColocataire) : void
}

class Comptes {
    - List<Compte> lesComptes
    + int Count() : int
    + Compte this[(int index)] : Compte
    + void AjouterCompte(Compte nouveauCompte) : void
}

class Logs {
    - id : int
    - identifiant : string
    - adresseIp : string
    - dateLog : DateTime
    - action : string
    + Logs(int id, string identifiant, string adresseIp, DateTime dateLog, string action)
    + int Id() : int
    + string Identifiant() : string
    + string AdresseIp() : string
    + DateTime DateLog() : DateTime
    + string Action() : string
}

class CollectionLogs {
    - List<Logs> leslogs
    + int Count() : int
    + Logs this[(int index)] : Logs
    + void AjouterLog(Logs nouveauLogs) : void
}

Colocataire "1" --> "*" Depenses
Colocataire "*" <-- Colocataires
Colocataire "1" --> "*" Logs
Depense "*" <-- Depenses
Colocataire "1" .> "1" Compte : <<include>>
Comptes --> "*" Compte
CollectionLogs "*" <-- Logs

@enduml
```

# Description des méthodes
### Colocataire
**•** **int Id() : int **.....** State state() : State** <br>
→ Accésseurs & Mutateurs des données membres privées<br>
**•** **Colocataire(int id, string nom, string prenom, int age, int numTel, string adresseMail, State state)** <br> 
→ Constructeur <br>
**•** **void Remove() : void** <br>
→ Cette fonction change le State d'un élément a **State.deleted**. On peut l'utiliser pour supprimer un élement (colocataire/dépense) <br>
**•** **string ToString() : string** <br>
→ Cette méthode est utiliser pour afficher les données membres d'un colocataire sous forme d'une chaîne de caractères.
### Colocataires
**•** **int Count() : int**<br>
→ Cette méthode permet de compter le nombre des colocataires dans la collection **lesColocataires**<br>
**•** **Colocataire this[int index] : Colocataire**<br>
→ Cette méthode permet d'avoir l'index d'un élément qu'on spécifie dans la collection<br>
**•** **void AjouterColocataire(Colocataire nouveauColocataire) : void**<br>
→ Cette méthode permet d'ajouter un nouveau colocataire dans la collection **lesColocataires**<br>
**•** **void SupprimerColocataire(Colocataire colocataire) : void**<br>
→ Cette méthode permet de supprimer un colocataire de la collection **lesColocataires**<br>
**•** **int GetIndex(string nom) : int**<br>
→ Cette méthode permet d'avoir le index d'après son nom dans la collection **lesColocataires**
**•** **int GetIndex(int index) : int**<br>
→ Cette méthode permet d'avoir le index d'après l'index de la collection (ex : l'index dans la collection est 0 mais son id dans la base de données est 8, si on met 8, la méthode ne marche pas à cause d'un dépassement d'index)**lesColocataires**
**•** **string GetNom(int index) : string**<br>
→ Cette méthode permet d'avoir le index d'après son nom dans la collection **lesColocataires**
### Depense
**•** **int Id() : int **.....** State state() : State** <br>
→ Accésseurs & Mutateurs des données membres privées<br>
**•** **Depense(int id, DateTime date, string titre, string justificatif, double montant, bool reparti, int IdColocataire, State state)** <br> 
→ Constructeur <br>
**•** **Depense(int id, DateTime date, string titre, string justificatif, double montant, int IdColocataire, State state)** <br> 
→ Constructeur <br>
**•** **void Remove() : void** <br>
→ Cette fonction change le State d'un élément a **State.deleted**. On peut l'utiliser pour supprimer un élement (colocataire/dépense) <br>
**•** **string ToString() : string** <br>
→ Cette méthode est utiliser pour afficher les données membres d'une dépense sous forme d'une chaîne de caractères.
### Depenses
**•** **int Count() : int**<br>
→ Cette méthode permet de compter le nombre des dépenses dans la collection **lesDepenses**<br>
**•** **Depense this[int index] : Depense**<br>
→ Cette méthode permet d'avoir l'index d'un élément qu'on spécifie dans la collection<br>
**•** **void AjouterDepense(Depense nouvelleDepense) : void**<br>
→ Cette méthode permet d'ajouter une nouvelle dépense dans la collection **lesDepenses**<br>
**•** **void SupprimerDepense(Depense depense) : void**<br>
→ Cette méthode permet de supprimer une dépense de la collection **lesDepenses**<br>
**•** **double APayer(int idColocataire) : double**<br>
→ Cette méthode permet de trouver le montant total qu'un colocataire a payé dans les dépenses qui sont pas réparti<br>
**•** **double AuraitDuPayer() : double** <br>
→ Cette méthode calcule le montant total des dépenses mais le divise pas par le nombre de colocataires. Ceci est fait dans un autre endroit.
### Compte
**•** **string Login() : string & string Password() : string** <br>
→ Accésseurs & Mutateurs des données membres privées<br>
**•** **Compte(string login, string password)** <br>
→ Constructeur <br>
### Comptes
**•** **int Count() : int**<br>
→ Cette méthode permet de compter le nombre des dépenses dans la collection **lesComptes**<br>
**•** **Compte this[int index] : Compte**<br>
→ Cette méthode permet d'avoir l'index d'un élément qu'on spécifie dans la collection<br>
**•** **void AjouterCompte(Compte nouveauCompte) : void**<br>
→ Cette méthode permet d'ajouter une nouvelle dépense dans la collection **lesComptes**<br>
### Logs
**•** **int Id() : string ... string Action() : string** <br>
→ Accésseurs & Mutateurs des données membres privées<br>
**•** **Logs(int id, string identifiant, string adresseIp, DateTime dateLog, string action)** <br>
→ Constructeur <br>
### CollectionLogs
**•** **int Count() : int**<br>
→ Cette méthode permet de compter le nombre des dépenses dans la collection **lesLogs**<br>
**•** **Logs this[int index] : Logs**<br>
→ Cette méthode permet d'avoir l'index d'un élément qu'on spécifie dans la collection<br>
**•** **void AjouterLogs(Logs nouveauLogs) : void**<br>
→ Cette méthode permet d'ajouter une nouvelle dépense dans la collection **lesLogs**<br>

