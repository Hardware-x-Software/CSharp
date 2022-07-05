---
hide:
  - toc
---

# Les opérations logiques
Nous avons vu pour les booléens la possibilité de faire de l'algèbre booléenne. Elle fait, elle aussi, intervenir plusieurs **opérateurs**. Nous pouvons par ailleurs séparer ces opérateurs en deux catégories : les opérateurs logiques et les opérateurs bit-à-bit.

## Les opérateurs logiques
Nous les avons déjà vu dans la section sur les booléens. Les revoici avec les symboles utilisés dans les langages de programmation pour les représenter :

- ET (`&&` ou plus rarement `and`) ;
- OU (`||` ou plus rarement `or`) ;
- NON (`!` ou plus rarement `not`) ;
- OU EXCLUSIF (`^` ou plus rarement `xor`).

Ces opérateurs **s'effectuent sur deux valeurs booléennes** et donnent **VRAI** ou **FAUX**. On peut en récupérer ce résultat avec l'opérateur d'affectation `=` comme nous l'avons vu auparavant pour les opérations mathématiques.

## Les opérateurs bit-à-bit
Les opérateurs bit-à-bit **s'effectuent sur des valeurs qui ne sont pas forcément booléennes**, comme les nombres. Ils doivent leur nom au fait qu'il s'effectuent bit par bit, un peu comme si chaque bit composant une valeur binaire était un booléen.<br/>
Ils sont très proches en terme de représentation dans le code mais leur effet est très différent. Cela peut être la source de nombreuses erreurs de programmation, attention !

- ET bit-à-bit (`&`) ;
- OU bit-à-bit (`|`) ;
- OU EXCLUSIF (`^`) ;
- inversion de bit (`~`).

On va voir ce que font ces opérateurs par l'exemple.<br/>
Prenons deux valeurs, `a = 1100` et `b = 0110`.

!!! example "ET bit-à-bit"

    On applique la règle de l'opérateur ET sur les deux bits en position 0, sur les bits en position 1, etc.<br/>
    `P.bit` indique la position des bits dans l'exemple ci-dessous.

    ```
    P.bit = 3 2 1 0

    a =     1 1 0 0
    b =     0 1 1 0
    _______________
    a & b = 0 1 0 0
    ```

!!! example "OU bit-à-bit"

    On applique la règle de l'opérateur OU sur les deux bits en position 0, sur les bits en position 1, etc.<br/>
    `P.bit` indique la position des bits dans l'exemple ci-dessous.

    ```
    P.bit = 3 2 1 0

    a =     1 1 0 0
    b =     0 1 1 0
    _______________
    a | b = 1 1 1 0
    ```

!!! example "OU EXCLUSIF (bit-à-bit)"

    On applique la règle de l'opérateur OU EXCLUSIF sur les deux bits en position 0, sur les bits en position 1, etc.<br/>
    `P.bit` indique la position des bits dans l'exemple ci-dessous.

    ```
    P.bit = 3 2 1 0

    a =     1 1 0 0
    b =     0 1 1 0
    _______________
    a ^ b = 1 0 1 0
    ```

!!! example "Inversion de bit"

    L'inversion de bit inverse la valeur de tous les bits : les 0 deviennent des 1 et les 1 deviennent des 0.

    ```
    P.bit = 3 2 1 0

    a =     1 1 0 0
    _______________
    ~a    = 0 0 1 1
    ```
