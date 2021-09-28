# **Application-CROUS**

# Composants logiciels à développer

## 1. Gérer les colocataires
### Objectif
→ L'objectif est de tenir en compte toutes les colocataires qui utilisent l'application ainsi que modifier ou supprimer un colocataire si besoin.
### Cas Utilisation
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
### Maquette
![GLC.PNG](./View/GLC.PNG)
![GLC_Ajouter.PNG](./View/GLC_Ajouter.PNG)
![GLC_Modifier.PNG](./View/GLC_Modifier.PNG)
### Enchaînement Textuel
→ Ajouter un colocataire : on clique sur le bouton "Ajouter". Après, on compléte les champs nécessaires (nom, prénom, age, adresse mail, n° tel). Après avoir fini on clique sur le bouton "Ajouter" pour ajouter le colocataire. <br>
→ Modifier un colocataire : on clique le colocataire qu'on veut modifier dans la liste et on clique sur le bouton "Modifier". On modifier n'importe quels données on choisi et une fois fini, on clique sur le bouton "Modifier". <br>
→ Supprimer un colocataire : on clique le colocataire qu'on veut supprimer dans la liste et on clique sur le bouton "Supprimer". 

## 2. Enregistrer les dépenses
### Objectif
→ L'objectif est d'enregistrer toutes les dépenses faite par chaque colocataire ainsi que les modifier en cas de besoin. Ces données vont être aussi utiliser pour la mise en répartition.
### Cas Utilisation
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
### Maquette
![ELD.PNG](./View/ELD.PNG)
![ELD_Ajouter.PNG](./View/ELD_Ajouter.PNG)
![ELD_Modifier.PNG](./View/ELD_Modifier.PNG)
### Enchaînement Textuel
→ Ajouter une dépense : on clique sur le bouton "Ajouter". Après, on compléte les champs nécessaires (titre, montant, date, qui?) (Le champ "Qui?" est une liste déroulante avec toutes les colocataires enregistré). Finalement, on clique sur le bouton "Ajouter" pour ajouter la dépense. <br>
→ Modifier une dépense : on clique la dépense qu'on veut modifier dans la liste et on clique sur le bouton "Modifier". On modifier n'importe quels données on choisi et une fois fini, on clique sur le bouton "Modifier". <br>
→ Supprimer une dépense : on clique la dépense qu'on veut supprimer dans la liste et on clique sur le bouton "Supprimer". 

## 3. Mise en répartition
### Objectif
→ L'objectif est calculer le montant a payer et donc les soldes à régler sur une certaine période. De plus, on doit avoir le montant total payé par chaque colocataire.
### Cas Utilisation
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
### Maquette
![MER.PNG](./View/MER.PNG)
![MER_Lancer.PNG](./View/MER_Lancer.PNG)
### Enchaînement Textuel
→ On clique sur le bouton "Lancer" pour lancer la mise en répartition. Ensuite on va avoir un tableau qui va nous présenter le montant payé par chaque personne, le montant qu'on aurait dû payer et les soldes à régler.

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
## 1. Colocataire
```plantuml
@startuml model1
scale 1

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

Colocataire_Classe <|-- Colocataire_Collection

@enduml
```
## 2. Depense
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

Depense_Classe <|-- Depense_Collection

@enduml
```





