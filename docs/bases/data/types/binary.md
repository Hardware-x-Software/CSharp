---
hide:
  - toc
---

# Le binaire
Avant d'aborder le sujet des nombres utilisés dans un programme, parlons un peu de la représentation de ceux-ci en binaire.<br/>
Un ordinateur fonctionne à l'électricité. Or, l'électricité n'a pas d'autre possibilité de varier qu'entre deux états : il y a du courant (0), ou il n'y en a pas (1). Ces valeurs binaires, `0` et `1`, sont les **bits**, pour *binary digits* en anglais. Bien sûr, limiter un ordinateur à compter jusqu'à 1 serait inutile pour des calculs scientifiques complexes ! Il devient plus intéressant de grouper les bits pour obtenir des nombres plus grands.

Revenons sur la façon dont nous comptons en tant qu'humains. Tout système de calcul utilise ce qu'on appelle une base, qui définit - pour simplifier au maximum - à partir de quand on ajoute une puissance. Concrètement, prenons l'exemple de la base 10 que nous utilisons quotidiennement. Nous avons dix chiffres - dix, comme la base donc - allant de 0 à 9. Puis, pour passer à la valeur après 9, nous ajoutons une puissance : la dizaine. On passe alors de 9 à 10, un nombre constitué de deux chiffres. Nous restons à deux chiffres jusqu'à 99 où, pour passer à la valeur suivante, nous ajoutons encore une puissance : la centaine. Voici le schéma que nous obtenons :
```text
   0    1    2    3    4    5    6    7    8    9
  10   11   12   13   14   15   16   17   18   19 [...]   90  91  92  93  94  95  96  97  98  99
 100  101  102  103  104  105  106  107  108  109 [...]  990 991 992 993 994 995 996 997 998 999
1000 1001 1002 1003 1004 1005 1006 ....
```

Maintenant, appliquons le même principe dans le cas où nous ne pouvons plus compter jusqu'à 9 mais uniquement jusqu'à 1 avant d'augmenter la puissance. C'est-à-dire que nous nous comptons en base 2, puisque nous n'avons droit qu'à deux chiffres : 0 et 1. Dès que nous voudrons compter après 1, il faudra alors ajouter une puissance ! Nous obtiendons (10)~2~, puis (11)~2~, puis (100)~2~, (101)~2~, etc... Voici les nombres allant de 0 à 15 en binaire :
```text
   0    1
  10   11
 100  101  110  111
1000 1001 1010 1011 1100 1101 1110 1111
```

!!! info "Remarques"

    Les nombres pairs finissent toujours par 0 et les nombres impairs par 1.<br/>
    Pour distinguer un nombre écrit dans une base autre que la base 10, nous l'écrivons entre parenthèses avec la base en indice.

Pour connaître le nombre de valeurs codables sur un groupe de bits, on utilise tout simplement la formule 2^_n_^ (2 à la puissance _n_) où _n_ est le nombre de bits. Par exemple, pour savoir combien de valeur nous pouvons coder sur 2 bits, nous calculons 2^2^ = 4. En effet, nous pouvons coder les valeurs suivantes : 0 (`00`), 1 (`01`), (10)~2~ et (11)~2~.
