---
hide:
  - toc
---

# Les boucles
Nous venons de voir comment exécuter différents parties du code d'un programme suivant des _conditions_. Si le déroulement d'un programme dépendra des conditions satisfaites ou non, une chose reste sûre : le programme va se terminer. Dans le cas où nous voudrions répéter plusieurs fois l'exécution du programme, par exemple un jeu, il nous faudrait relancer autant de fois le programme. Cela est non seulement pénible mais en plus interdit tout comptage de points, car les données d'un programme sont perdues quand il s'arrête.

Heureusement, il existe un moyen de répéter des portions de code dans un programme afin de les lui faire faire exécuter plusieurs fois : les **boucles**.

Une boucle peut se répéter un nombre prédéfini de fois. On rentre une valeur constante en guise de nombre de répétitions.<br/>
Elle peut se répéter indéfiniment. Dans le cas d'un jeu, ni l'ordinateur ni le joueur ne savent à l'avance combien de parties seront jouées.<br/>
Elle peut aussi se répéter un nombre de fois déterminé mais avec un nombre variable. En reprenant un exemple de recette de cuisine, nous ne casserons pas autant d'oeufs, un à un, pour un gâteau suivant que nous le préparions pour 2, 4 ou 6 personnes. Il nous faudra plus ou moins d'oeufs selon le nombre de parts.

Il existe différents type de boucles. Elles s'utilisent de façon similaire et nous choisirons la plus pratique à écrire suivant la situation.

- En général, quand nous avons un nombre - constant ou variable - de répétitions à effectuer, nous utilisons une boucle de type `pour une valeur de tant à tant`. **Pour** se traduisant par **for** en anglais, nous parlerons de boucle `for`.
- Quand nous voulons arrêter une boucle quand une condition devient fausse, nous utilisons la boucle `tant que`, qui se traduit par `while` en anglais.

Une alternative à la boucle `while` est la boucle `do ... while` dont l'utilisation est plus rare.<br/>
`while` débute en vérifiant si la condition est vraie. Elle ne lance donc le premier tour de boucle que si cette condition est vérifiée, sinon tout son code n'est pas exécuté du tout.<br/>
`do ... while` ne vérifie la condition qu'à la fin de l'exécution du code qu'elle contient. Elle nous assure donc d'exécuter au moins une fois ce bout de code.

!!! warning "Boucles infinies"

    L'utilisation de boucle est sujette aux boucles infinies. Cela arrive quand la condition pour laquelle la boucle doit s'arrêter ne peut **jamais** valoir FAUX. Il y a différentes situations possibles comme oublier de modifier la valeur de condition d'une boucle `while` ou attendre une valeur négative d'un nombre entier non signé.
