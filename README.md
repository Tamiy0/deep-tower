# Deep Tower

**Deep Tower** est un jeu de casse-tête 2D vu de dessus, fortement inspiré des mécaniques classiques de *Sokoban*. Ce projet a été développé en C# avec le moteur Godot dans le cadre du Projet Informatique Individuel (P2I) à l'ENSC Bordeaux.

## Présentation

Dans *Deep Tower*, le joueur évolue sur une grille discrétisée et doit faire preuve de logique et d'anticipation. L'objectif est d'atteindre la case cible de chaque niveau tout en esquivant des entités hostiles mouvantes. Les déplacements s'effectuent case par case, demandant une gestion précise de l'espace et des priorités de mouvement pour ne pas se faire attraper.

**Caractéristiques techniques :**
* Développé avec **Godot Engine 4** et **C#**.
* Architecture modulaire (séparation logique/affichage).
* Moteur de règles sur grille discrétisée.
* Algorithme de gestion des collisions et de réservation de cases cibles pour les entités de l'intelligence artificielle.

## Installation

Pour jouer à *Deep Tower*, vous n'avez pas besoin d'installer le moteur Godot.

1. Rendez-vous dans la section [Releases](../../releases) située à droite de cette page.
2. Téléchargez le fichier `.zip` de la dernière version (ex: `DeepTower_v1.0.zip`).
3. Extrayez le contenu du fichier `.zip` dans un dossier sur votre ordinateur.
4. Assurez-vous que le fichier `.exe` et le fichier `.pck` se trouvent bien dans le même dossier.
5. Double-cliquez sur `DeepTower.exe` pour lancer le jeu !


## Comment jouer ?

### But du jeu
Atteindre la case cible pour passer au niveau suivant. Si une entité ennemie vous touche, le niveau est perdu et doit être recommencé.

### Contrôles
* **Flèches directionnelles** (ou **Z, Q, S, D**) : Se déplacer d'une case (Haut, Gauche, Bas, Droite).
* **R** : Recommencer le niveau (en cas de blocage).
* **Espace** : Passer son tour de jeu (toute les entitées bougerons selon leur code sans que le joueur ne bouge)


---
*P2I réalisé par Émile Bonnet - 2025/2026*