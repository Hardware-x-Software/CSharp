---
hide:
  - toc
---

# Les décalages de bits
Les opérateurs de décalage de bits servent, comme le nom l'indique, à décaler les bits d'une valeur. Il y en a deux, l'un pour un décalage vers la gauche, l'autre pour un décalage vers la droite. Tous deux prennent aussi le nombre de positions qui sont décalées. Leur fonctionnement respectif est légèrement différent.

## Décalage à gauche
Les bits sont décalés vers la gauche, c'est-à-dire vers le bit de poids fort.<br/>
Dans le cas suivant `0010'1111 << 2 = 1011'1100`, le décalage nous fait passer de la valeur 47 à 188 (en base 10). D'un point de vue mathématique, on peut calculer ce décalage de bits en posant 47 × 2^2^ = 47 × 4 = 188.

Pour généraliser, on notera qu'un décalage de bits à gauche se calcule avec la formule **a × 2^b^**, où _a_ est la valeur initiale et _b_ le nombre de bits décalés à gauche.

Etant donné qu'une valeur codée sur un ordinateur a une taille limitée en nombre de bits, **si un bit dépasse le bit de poids fort, sa valeur est perdue**. Les bits de poids faible sont quant à eux **mis à zéro**.
Par exemple, on obtiendrait ceci pour un décalage à gauche où les quatre bits de poids fort sont perdus après le décalage : `0010'1111 << 4 = 1111'0000`. Nous avons perdu les 4 bits de poids fort initiaux `0010`.

Il va sans dire que dans cette situation, la formule pour calculer mathématiquement le résultat d'un décalage à gauche ne s'applique plus !

## Décalage à droite
Les bits sont décalés à droite, vers le bit de poids faible.<br/>
Le comportement de ce décalage **dépendra de l'aspect signé ou non signé** de la valeur.

### Valeur non signée
Si la valeur sur laquelle on effectue le décalage n'est pas signée, donc toujours positive ou nulle, **les bits de poids fort sont mis à zéro**. Le comportement est semblable à celui que nous avons vu juste avant.<br/>
Pour l'exemple `1101'1100 >> 2 = 0011'0111`, on passe de la valeur 220 à 55 (en base 10). Cela revient mathématiquement à calculer 220 ÷ 2^2^ = 55. Pour généraliser la formule, nous calculons **a ÷ 2^b^**, où _a_ est la valeur initiale et _b_ le nombre de bits décalés à droite. Ici aussi, **cette formule ne s'applique que si les bits dépassent pas le bit de poids faible**.

### Valeur signée
Dans le cas où la valeur sur laquelle nous effectuons le décalage à droite est signée, la valeur des bits de poids fort ajoutés dépendra du signe de la valeur.

Si la valeur est positive, nous plaçons toujours des zéros. Par exemple `0101'1100 >> 2 = 0001'0111`.

En revanche, si la valeur est négative, les bits de poids fort sont mis à un. Dans ce nouvel exemple, `1101'0100 >> 2 = 1111'0101`, les deux bits de poids fort introduits valent tous les deux `1`. En base 10, on obtiendrait selon la formule -44 ÷ 2^2^ = -11. Il se trouve que c'est justement bien le cas en binaire aussi !

!!! note "Remarque"

        Un moyen simple de se souvenir du fonctionnement du décalage à droite, sur une valeur signée, c'est que le décalage applique le bit de signe aux bits de poids fort insérés.

**Pour résumer : la formule **a ÷ 2^b^** s'applique pour le décalage à droite dans toutes les situations rencontrées (tant qu'il n'y a pas dépassement du bit de poids faible).**

## Quelle utilité à décaler les bits ?
Nous avons vu comment fonctionne le décalage de bits. Cependant, il serait intéressant de savoir à quoi ça peut nous servir.

Les opérateurs logiques bit-à-bit combinés aux opérateurs de décalage de bits sont très puissants. Comme nous l'avons vu plus tôt, l'ordinateur n'est pas capable d'obtenir une valeur booléenne qui serait stockée sur un unique bit. La "faute" à la façon dont la mémoire est organisée, en octet, et donc comment le processeur peut aller y chercher des infos grâce à l'adresse de l'octet en question.
Si nous voulions stocker par exemple 5 booléens, nous aurions besoin de 8 octets soit 40 bits. Cela peut sembler inutile vis-à-vis de nos ordinateurs dotés de plusieurs gigaoctets de mémoire, mais certains systèmes informatiques ont une **quantité extrêmement limitée de mémoire** et ce type de gain est très recherché.<br/>
Un autre aspect à considérer pour ce type de stockage compressé, c'est le **réseau**. Quand on envoie des données sur le réseau, elles mettent plus ou moins de temps à arriver à l'ordinateur distant suivant la taille qu'elles occupent. S'il y a un moyen de les compresser, nous aurons une communication plus rapide entre les deux machines. Qu'il s'agisse du jeu vidéo, en millisecondes, ou de transactions bancaires, en nanosecondes, chaque économie d'octet compte.

Parmi les autres utilisations du décalage de bits (et des opérateurs bit-à-bit en général), nous pouvons citer l'une des plus connues mais aussi étonnante : le calcul de la [racine carré inverse rapide x^-1/2^](https://fr.wikipedia.org/wiki/Racine_carr%C3%A9e_inverse_rapide), dont on sait qu'elle a été utilisée dans le jeu vidéo _**Quake III Arena**_.
