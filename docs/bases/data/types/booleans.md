---
hide:
  - toc
---

# Les booléens
Les **booléens** sont un dernier type de données de base utilisable dans un programme, assez peu connus sous ce nom en dehors de l'informatique principalement.<br/>
Il s'agit du type de données pouvant avoir seulement deux valeurs, celles de vérité de la logique à savoir **VRAI** ou **FAUX**. Les booléens doivent leur nom au logicien, mathématicien et philosophe britannique [George Bool](https://fr.wikipedia.org/wiki/George_Boole).

Pour un calcul mathématique, nous utilisons des opérateurs tels que l'addition ou la multiplication. Avec les booléens, nous pouvons également utiliser des opérateurs logiques. On peut alors parler d'_algèbre booléenne_.

Puisque les booléens ne peuvent prendre que deux valeurs, VRAI ou FAUX, ils sont très simples à représenter pour un ordinateur. Le bit 0 représente FAUX, le bit 1 vaudra VRAI.

!!! note "Remarque sur la taille d'un booléen"

    Les booléens ne peuvent prendre que deux valeurs possibles, VRAI ou FAUX. Ils pourraient donc se coder sur un seul bit.<br/>
    Cependant, la plus petite unité utilisable et **adressable** par un ordinateur contemporain est l'**octet**. Les booléens sont donc codés sur 8 bits bien qu'ils n'en utilisent qu'un seul. Nous l'avons vu plus tôt, la mémoire RAM en particulier est composée de cases mémoires faisant chacune un octet (8 bits). Les données qu'elle stocke doivent donc être réparties sur des multiples de 8 bits, des octets donc, pour être adressables. D'autres contraintes matérielles pour l'optimisation des performances entrent également en jeu comme l'**alignement en mémoire**.

## Opérateurs logiques
Quant aux opérateurs logiques, nous en avons plusieurs :

* **ET (AND) :** le résultat n'est VRAI que si _toutes les valeurs_ sont VRAIES ;
* **OU (OR) :** le résultat est VRAI si _au moins une des valeurs_ est VRAIE ;
* **NON (NOT) :** le résultat est l'inverse de la valeur initiale (le VRAI devient FAUX et vice versa) ;
* **OU EXCLUSIF (XOR) :** le résultat est VRAI si _une et une seule des deux valeurs_ est VRAIE.

Il est possible de dresser un tableau récapitulatif.

| a | b | NON a | NON b | a ET b | a OU b | a XOR b |
|---|---|-------|-------|--------|--------|---------|
| 0 | 0 | 1     | 1     | 0      | 0      | 0       |
| 0 | 1 | 1     | 0     | 0      | 1      | 1       |
| 1 | 0 | 0     | 1     | 0      | 1      | 1       |
| 1 | 1 | 0     | 0     | 1      | 1      | 0       |


## Exemples en français

!!! example "Exemple avec ET"

    > Je pourrai acheter du pain si _la boulangerie est ouverte_ **ET** que _j'ai assez de monnaie_.

    Ici on comprend bien que les deux conditions doivent être remplies.<br/>
    Si la boulangerie est ouverte mais qu'on n'a pas assez d'argent, on ne pourra pas acheter le pain.<br/>
    De même si on a suffisamment de monnaie mais que la boulangerie est, hélas, déjà fermée.

!!! example "Exemple avec OU"

    > Pour rentrer chez moi, je peux prendre _le bus de la ligne 28_ **OU** _le tramway_.

    Deux choix possibles s'offrent à cette personne. Qu'importe le moyen choisi, elle pourra rentrer chez elle même si les deux arrivent en même temps.<br/>
    Ouf, nous voilà rassurés !

!!! example "Exemple avec OU EXCLUSIF"

    > Mince, je n'ai plus assez d'argent sur moi. Je dois choisir entre _les bonbons_ **OU** _les biscuits_.

    Ici aussi, on a deux choix. Cependant, il sera impossible de satisfaire les deux à la fois. On ne rentrera à la maison que soit avec le paquet de bonbons, soit celui de biscuits.

## Comment obtenir des booléens en informatique ?

La première façon d'avoir une valeur booléenne en informatique est tout simplement de l'écrire comme étant VRAIE ou FAUSSE. Mais c'est loin d'être la seule !<br/>
Au-delà de l'utilisation des opérateurs logiques que nous venons de voir, l'ordinateur est aussi apte à faire des **comparaisons** entre deux nombres. Ainsi, si on demande à savoir si 2 est strictement inférieur à 3, on pourra récupérer VRAI. A l'inverse, si on veut savoir si 1/3 est supérieur ou égal à Pi, il nous indiquera FAUX.

Etant donné que le texte se base sur des associations entre les caractères et des nombres, l'ordinateur est là encore capable de vérifier si deux textes sont identiques : il vérifiera que chaque lettre est, une à une, identique à position égale entre les deux chaînes de caractères. Si on prend les deux paronymes `douceur` et `douleur`, tous deux contiennent le même nombre de lettres. Cependant, si le début est identique, ils se différencient à la quatrième lettre : l'un contient un `c` quand l'autre contient un `l`. Les deux lettres n'ont pas la même valeur numérique pour l'ordinateur, les mots sont donc différents. A noter que la comparaison entre deux anagrammes donnera FAUX car les lettres, bien qu'identiques mais mélangées, ne sont pas à la même position. Ainsi `imaginer` et `migraine` seront bien vus comme deux mots différents dès la première lettre : `i` et `m` ne sont pas les mêmes caractères !

!!! info "Remarque sur la sensibilité à la casse"

    Dans un programme informatique, comparer deux mots identiques mais écrits avec une casse différente (majuscule ou minuscule) donnera FAUX. En effet, le code associé à une lettre en majuscule est différent de celui pour la même lettre en minuscule.

    Le caractère `A` est différent du caractère `a` pour un ordinateur ! On parle de **sensibilité à la casse**, ou _case sensitivity_ en anglais. Pour s'affranchir de cette différence si on en a besoin, on pourra basculer les textes à comparer tout en minuscules, par exemple, avant de vérifier s'ils sont identiques. Les systèmes d'exploitation Microsoft Windows appliquent cette solution pour les chemins des fichiers : on peut les écrire aussi bien avec ou sans les majuscules. A l'inverse, les systèmes comme Linux sont, eux, sensibles à la casse.
