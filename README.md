# **Application-CROUS**
# Composants logiciels à développer

## 1. Gérer les colocataires
### Objectif
ezdqsdqsdsqdqsdqsdqsdqsqsdsqdsqd
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
![GLC.PNG](./GLC.PNG)
### Enchaînement Textuel

## 2. Enregistrer les dépenses
### Objectif
ezdqsdqsdsqdqsdqsdqsdqsqsdsqdsqd
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

### Enchaînement Textuel

## 3. Mise en répartition
### Objectif
ezdqsdqsdsqdqsdqsdqsdqsqsdsqdsqd
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

### Enchaînement Textuel



