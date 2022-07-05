---
hide:
  - toc
---

# Les opérations mathématiques
Comme nous venons de le voir, un ordinateur est apte à utiliser des nombres. Avec ces nombres, nous pouvons réaliser des calculs mathématiques. Les opérations de base sont directement cablées dans les processeurs. On parle alors d'**implémentation matérielle**, ce qui offre les meilleures performances possible et donc qui permet à ces opérations d'être réalisées très rapidement.<br/>
Les voici avec le symbole, qu'on appelle **opérateur**, généralement utilisé pour les représenter dans du code :

- l'**addition** (`+`) ;
- la **soustraction** (`-`) ;
- la **multiplication** (`*`) ;
- la **division** (`/`) donnant le _quotient_ ;
- le **modulo** (`%`) représentant le _reste_ d'une division entière.

Si on a besoin de stocker une valeur, on pourra compter sur l'opérateur d'**affectation** (`=`) qui permet de donner une valeur à une variable.

!!! example "Exemple de division et de modulo"
    Pour mieux comprendre le modulo, prenons l'exemple de la division **216 ÷ 7**, où le dividence est `216` et le diviseur est `7`. Posons-la et faisons le calcul à la main :
    ![Division 216 / 7 posée](images/division_exemple.svg){ align=right }

    Le résultat que nous obtenons est un quotient valant `30` et un reste valant `6`.<br/>
    En faisant le calcul avec des nombres entiers dans un programme informatique, la division `216/7` nous donnera donc `30`. L'opération `216%7` nous fournira le reste, c'est-à-dire `6`.

Toutes les autres opérations plus complexes devront être codées à partir de ces opérations-ci. On parlera donc d'**implémentation logicielle**. Bien que plus flexible car on peut facilement modifier le code source d'un programme, l'implémentation logicielle est également plus lente. Les performances d'une telle implémentation dépendra essentiellement de la complexité avec laquelle elle est mise en oeuvre.
Par exemple, pour calculer une valeur _v_ au carré, on fera la multiplication `v * v`. Cela reste très rapide !<br/>
Pour calculer une racine carré, il existe différentes façons de procéder mais toutes se baseront sur ces opérations basiques et le calcul fera intervenir beaucoup plus d'étapes que pour celui du carré. La racine carré est donc plus lente à calculer que le carré. Il faut cependant relativiser avec la rapidité de nos processeurs modernes !

On peut donc dire que pour faire un calcul complexe, un ordinateur le décomposera en une multitude d'opérations simples qu'il sera à même de réaliser matériellement.
