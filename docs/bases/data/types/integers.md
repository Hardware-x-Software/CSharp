---
hide:
  - toc
---

# Les nombres entiers naturels
Un groupe de bits très connu est l'**octet**. Comme son nom l'indique, il s'agit d'un groupe de 8 bits. Par exemple, le nombre 157 peut être représenté en binaire par (10011101)~2~. Au total, un octet permet de représenter 2^8^ = 256 valeurs différentes dont le 0. Cela commence à devenir plus amusant pour programmer ! Cependant, ça reste encore très peu pour faire de gros calculs mathématiques ! Alors on peut grouper les octets par paquets eux aussi, chacun avec leur nom. Voici la liste des groupements d'octets, appelés **types**, généralement utilisables dans les langages informatiques :

- le **byte** (1 octet = 8 bits) ;
- le **short** (2 octets = 16 bits) ;
- le **integer** (4 octets = 32 bits) ;
- le **long** (8 octets = 64 bits).

La valeur maximale d'un nombre entier naturel est de 2^_n_^ - 1, où _n_ est le nombre de bits utilisés pour le coder.

!!! info "Remarque"

    En utilisant la base 2, un ordinateur utilise toujours des nombres d'octets et de bits qui sont des puissances de 2 !

Nous venons de voir comment coder des **nombres entiers naturels** sur un ordinateur. Ils sont toujours positifs ou nuls et donc n'ont pas besoin d'un signe devant eux. En informatique, on parle de **types non signés** pour cette raison.<br/>
Une question pourrait toutefois nous venir à l'esprit : pourquoi donc avons nous des nombres qui sont représentés sur un certain nombre d'octets ? Après tout, le langage binaire permet de représenter toute l'infinité des nombres entiers au même titre que notre base 10 habituelle. Et bien, il se trouve que le processeur - le "cerveau" de l'ordinateur - utilise de petites cases de mémoire pour ses calculs. Or, cette mémoire a une taille extrêmement limitée. Nous avons tous déjà entendu parlé de processeurs 32 et 64 bits. Ce nombre de bits fait référence à la taille des petites cases de mémoire à l'intérieur du processeur pour stocker des nombres entiers. Cela a un impact assez inattendu sur certains calculs qu'on appelle le **dépassement d'entier**.

Prenons un byte non signé (8 bits) valant `11111111`. C'est la valeur maximale qu'il peut prendre, autrement dit 255 en base 10. Que se passe-t-il si nous lui additionnons `1` ? Nous devrions obtenir `100000000` qui ajoute un neuvième bit, mais ce n'est pas possible puisque notre byte ne peut contenir que 8 bits ! La retenue est donc tronquée et nous revenons à `00000000`, soit 0 en base 10. Et oui, comme tout compteur tel que dans une voiture ou un compteur d'eau, la limitation dans la taille des chiffres implique un retour à zéro à cause du dépassement d'entier. Pour une voiture qui arriverait à 999&nbsp;999km, son compteur retomberait à 0km après le prochain kilomètre parcouru tout simplement parce que ce compteur n'a que 6 chiffres !


### Et les nombres entiers relatifs ?
Un autre souci se pose : dans nos calculs, nous avons des nombres positifs mais parfois aussi négatifs ! On parle alors d'entier relatif en mathématiques ou de **type signé** en informatique. Or, comment représenter un nombre négatif avec uniquement des 0 et des 1 ? Justement, si un bit est capable de représenter deux états, il est également possible de représenter deux signes possibles pour un nombre : le signe positif et le signe négatif. Un peu comme nous plaçons le signe (-) devant un nombre négatif, nous utilisons le **bit de poids fort** pour indiquer le signe d'un nombre en binaire. Le bit de poids fort est le bit le plus à gauche d'un byte, short, integer ou long :

- Si le bit de poids fort vaut 0, le nombre est positif ;
- Si le bit de poids fort vaut 1, le nombre est négatif.

Cependant, si nous utilisons un bit pour représenter le signe, il ne peut plus servir à obtenir des valeurs aussi grandes qu'avant ! De fait, un type de nombres entiers signé ne peut pas représenter tous les nombres positifs disponibles avec le même type non signé :

- Valeur négative minimale = -2^(n-1)^ ;
- Valeur positive maximale = 2^(n-1)^ - 1.

Il y a une autre complexité qui s'ajoute. Comme nous l'avons vu pour les nombres entiers naturels, chaque valeur qui se suit est incrémentée de +1 en binaire. C'est un calcul vraiment très simple et peu couteux pour le processeur. Il n'est donc pas possible de représenter la valeur -1 par `10000001` puisque si nous incrémentons pour passer à 0, nous obtiendrions `10000010` qui est bien sûr différent de `00000000`.<br/>
Il se trouve que nous avons vu, dans la partie précédente, qu'en ajoutant 1 à `11111111`, nous revenions à `00000000`. De fait, nous pouvons en déduire que si nous signions cette valeur `11111111`, elle ferait la candidate parfaite pour représenter -1 ! Toujours en pensant à la succession des valeurs en binaire, nous obtiendrions -2 avec `11111110`, ainsi de suite jusqu'à `10000000` (-128 en base 10) en faisant des soustractions de -1 à chaque étape.

Pour résumer, un ordinateur peut coder une _quantité finie_ de valeurs entières **signées** et **non signées**. Plus le **type** contient d'octets (1, 2, 4 ou 8 octets), plus il pourra représenter de valeurs différentes. Les valeurs signées sont amputée de leur bit de poids fort pour représenter le signe et ne peuvent permettre d'avoir un nombre positif aussi grand que les valeurs non signées (uniquement positives ou nulles).
