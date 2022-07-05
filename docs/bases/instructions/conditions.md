---
hide:
  - toc
---

# Les conditions
Après avoir définit les données et les opérations disponibles sur elles, il est temps de savoir ce que l'on peut en faire de façon plus avancée. En particulier, les valeurs et les opérateurs booléens vont être très utiles pour exécuter des portions de code dans un cas mais pas dans un autre. On parle de **condition** ou de **branchement**.

Imaginons un programme qui sert à faire des divisions. Il demande le dividende à l'utilisateur puis le diviseur. Une propriété de la division est qu'il est _impossible de diviser par zéro_. Dans le cadre d'un programme, sans contrôle justement, la division par zéro conduit au mieux à une erreur, au pire au plantage du programme selon le langage utilisé pour le développer. Pour éviter cette situation nous voudrions indiquer à l'utilisateur que la division par zéro est impossible et ne pas effectuer la division par zéro. Nous pourrions avoir ce type de programmation.

```text
demander dividende
demander diviseur

si diviseur == 0, alors :
  écrire "Attention, la division par zéro est impossible !"
sinon :
  écrire "Le résultat de la division est " (dividende / diviseur) "."
```

!!! note "Remarque"

    Il s'agit d'un programme écrit en **pseudocode**. Le pseudocode permet d'écrire un bout de programme sans avoir à connaître un langage de programmation particulier. On peut l'utiliser pour commencer à développer un programme avant même de le faire sur un ordinateur, pour analyser un algorithme, etc.

    Le pseudocode peut servir également pour tout autre chose que l'informatique !

Comme nous le voyons avec ce bout de code, nous avons introduit deux mots importants : `si` et `sinon`. Cela va donc créer une bifurcation dans le code, ce ne seront pas les mêmes instructions qui seront exécutées si le diviseur vaut zéro ou pas. Dans d'autres situations, nous pourrions avoir besoin d'un troisième type de branchement, le `sinon si`.

Prenons un autre exemple où nous devons réaliser un gâteau. Nous voulons mettre du sucre ou une alternative selon ce que nous avons sous la main - ou arrêter de préparer la recette si nous n'en avons aucune !

```text
possède_sucre = faux
possède_sirop_agave = faux
possède_stevia = vrai

si possède_sucre, alors :
  utiliser sucre
sinon si possède_sirop_agave, alors :
  utiliser sirop_agave
sinon si possède_stevia, alors :
  utiliser stevia
sinon :
  arrêter
```

Avec les conditions, nous avons également la possibilité d'utiliser les opérateurs booléens.

```text
vie_personnage = 100
magie_personnage = 100

si vie_personnage == 100 && magie_personnage == 100, alors :
  afficher "Bravo, vous êtes une véritable légende !!!"
sinon si vie_personnage > 50 || magie_personnage > 50, alors :
  afficher "C'est une belle performance !"
sinon si vie_personnage > 1, alors :
  afficher "Ce n'était pas exceptionnel."
sinon :
  afficher "L'histoire retiendra peut-être votre nom..."
```
