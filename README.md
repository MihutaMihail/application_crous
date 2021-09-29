# **Application-CROUS**

# Contexte
Le C.R.O.U.S (Centre Régional de Oeuvres Universitaires et Scolaires) est un établissement public placé sous la tutelle du Ministère de l'Enseignement supérieur. Il a pour mission d'améliorer les conditions de vie et de travail des étudiants de l'académie de Créteil.

L'une des missions principales est le logement des étudiants. Il propose aux éleves habitant en colocation une application mieux organiser leur dépenses et donc leur budget.

# Outils mis en oeuvre
Pour réaliser ce projet on a mis en oeuvre plusiers outils :
1. Visual Studio 2017 (Windows Form, C#, ado.net)
2. Visual Studio Code (PlantUML)
3. Git 
4. MySQL (MySQL Lite pour la base de données)

# Composants logiciels à développer

## 1. Gérer les colocataires
### Objectif 
• L'objectif est de tenir en compte toutes les colocataires qui utilisent l'application ainsi que modifier ou supprimer un colocataire si besoin.
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
![GLC.PNG](./View/GLC.PNG)
![GLC_Ajouter.PNG](./View/GLC_Ajouter.PNG)
![GLC_Modifier.PNG](./View/GLC_Modifier.PNG)
### Enchaînement Textuel - Gérer les colocataires
• <i> **Ajouter un colocataire** </i> <br>
    1. On clique sur le bouton **Ajouter** pour ajouter un nouveau colocataire. <br>
    2. On complète les champs (nom, prénom, age, adresse mail, n° tel). <br>
    3. On cliquer sur le bouton **Ajouter** après pour finir <br>
<br>
• <i> **Modifier un colocataire** </i> <br>
    1. On clique sur le colocataire qu'on veut modifier. <br>
    2. On clique sur le bouton **Modifier** pour modifier les données d'un colocataire<br> 
    3. On modifie les données qu'on a besoin de modifier. <br>
    4. On clique sur le bouton **Modifier** après avoir fini. <br>
<br>
• <i> **Supprimer un colocataire** </i> <br>
    1. On clique sur le colocataire qu'on veut supprimer. <br>
    2. On clique sur le bouton **Supprimer**.

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
    usecase "Saisie une dépense" as UC1
    usecase "Modifier une dépense" as UC2
    usecase "Supprimer une dépense" as UC3
}
c --> UC1
(Justifier la dépense) .> UC1 : <<extends>>
c --> UC2
c --> UC3
@enduml
```
### Maquette - Enregistrer les dépenses
![ELD.PNG](./View/ELD.PNG)
![ELD_Ajouter.PNG](./View/ELD_Ajouter.PNG)
![ELD_Modifier.PNG](./View/ELD_Modifier.PNG)
### Enchaînement Textuel - Enregistrer les dépenses
• <i> **Ajouter une dépense** </i> <br>
    1. On clique sur le bouton **Ajouter** pour ajouter une nouvelle dépense. <br>
    2. On complète les champs (titre, montant, date, qui?) (le "qui?" est une liste déroulante où on va choisir le colocataire qui a effectué cette dépense). <br>
    3. On clique sur le bouton **Ajouter** après avoir fini. <br>

• <i> **Modifier une dépense** </i> <br>
    1. On clique sur la dépense qu'on veut modifier. <br>
    2. On clique sur le bouton **Modifier**.<br>
    2. On modifie les données qu'on a besoin de modifier. <br>
    3. On clique sur le bouton **Modifier** après avoir fini. <br>

• <i> **Supprimer une dépense** </i> <br>
    1. On clique sur la dépense qu'on veut supprimer <br>
    2. On clique sur le bouton **Supprimer** <br>

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
UC3 .> UC1 : <<extends>>
@enduml
```
### Maquette - Mise en répartition
![MER.PNG](./View/MER.PNG)
![MER_Lancer.PNG](./View/MER_Lancer.PNG)
### Enchaînement Textuel - Mise en répartition
→ On clique sur le bouton "Lancer" pour lancer la mise en répartition. Ensuite on va avoir un tableau qui va nous présenter le montant payé par chaque personne, le montant qu'on aurait dû payer et les soldes à régler.

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
    usecase "Réparti les dépenses" as UC3
}
c --> UC1
UC1 ..|> UC2 : <<include>>
UC1 --> UC3

@enduml
```
### Maquette - Solder une période
![.PNG](./View/.PNG)
![.PNG](./View/.PNG)
### Enchaînement Textuel - Solder une période
→ 

# Base de données
```plantuml
@startuml model1
scale 1

class Depenses {
  id : int
  date : date
  titre : string
  justificatif : string
  montant : decimal
  reparti : bool
}

class Colocataire {
    id : int
    nom : string
    prenom : string
    age : int
    numTel : int
    adresseMail : string
}
@enduml
```

# Diagramme de Classe
```plantuml
@startuml model1
scale 1

class Depense_Classe {
    - montant : int
    - titre : string
    - date : date
}
class Depense_Collection {
    - List<Depense> lesDepenses
    + AjouterDepense(int montant, string titre, date date) : void
    + SupprimerDepense() : void
}

class Colocataire_Classe {
    - nom : string
    - prenom : string
    - age : int
    + APayer() : decimal
    + SoldeARegler() : decimal
}
class Colocataire_Collection {
    - List<Colocataire> lesColocataires
    + AjouterColocataire(string nom, string prenom, int age) : void
    + SupprimerColocatire() : void
}

Colocataire_Classe "1" *-- "*" Depense_Classe
Colocataire_Classe "*" *-- Colocataire_Collection
Depense_Classe "*" *-- Depense_Collection

@enduml
```




