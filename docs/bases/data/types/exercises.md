---
hide:
  - toc
---

# Exercices

Voici le moment tant redouté, celui où il va falloir faire chauffer les neurones !<br/>
Pour la correction, clique sur "Corrections" afin de révéler les réponses aux exercices. Je compte sur toi pour ne pas tricher !!

## Nombres entiers

!!! question "Exercices sur les nombres entiers"

    1. Calculer la valeur maximale d'un short, d'un integer et d'un long non signés.
    2. Calculer les valeurs minimale et maximale d'un short, d'un integer et d'un long signé.
    3. Représenter en binaire sur un byte les nombres suivants exprimés en base 10 : 65, 132, -24.
    4. Calculer les valeurs sur un **byte non signé** (8 bits, toujours positif) suivantes en base 10 : `00000110`, `00011011`, `11110000`, `10110110`
    5. Trouver un moyen simple de calculer ces valeurs (indice : la puissance de 2).
    6. Calculer les valeurs précédentes sur byte **signé** (8 bits, pouvant être négatif ou positif) en base 10.

Allez, un peu d'aide si jamais tu bloques.

!!! info "Aide pour les questions sur les nombres entiers relatifs"

    Une astuce pour trouver les nombres négatifs facilement est d'inverser les bits (les 0 deviennent des 1 et vice versa), calculer le nombre obtenu, y ajouter + 1 et placer le signe négatif.

    Par exemple, pour (11111001)~2 :

    1. On inverse les bits : (00000110)~2~ ;
    2. On calcule la valeur en base 10 : on obtient 6 en base 10 ;
    3. On l'incrémente pour obtenir 7 ;
    4. On n'oublie pas le signe (-), ce qui donne la solution recherchée de **-7** en base 10 !


??? success "Corrections des exercices sur les nombres entiers"

    1.  **Calculer la valeur maximale d'un short, d'un integer et d'un long non signés.**
        1.  Un short non signé occupe 2 octets, soit 16 bits. Il peut coder les nombres allant de 0 à 2^16^ - 1 = **65&nbsp;535**.
        2.  Un integer non signé occupe 4 octets, soit 32 bits. Il peut coder les nombres allant de 0 à 2^32^ - 1 = **4&nbsp;294&nbsp;967&nbsp;295**.
        3.  Un long non signé occupe 8 octets, soit 64 bits. Il peut coder les nombres allant de 0 à 2^64^ - 1 = **18&nbsp;446&nbsp;744&nbsp;073&nbsp;709&nbsp;551&nbsp;615**.
    2. **Calculer les valeurs minimale et maximale d'un short, d'un integer et d'un long signé.**
        1.  Un short signé occupe 2 octets, soit 16 bits. Il peut coder les nombres allant de -2^15^ = **-32&nbsp;768** à 2^15^ - 1 = **32&nbsp;767**.
        2.  Un integer signé occupe 4 octets, soit 32 bits. Il peut coder les nombres allant de -2^31^ = **-2&nbsp;147&nbsp;483&nbsp;648** à 2^31^ - 1 = **2&nbsp;147&nbsp;483&nbsp;647**.
        3.  Un long signé occupe 8 octets, soit 64 bits. Il peut coder les nombres allant de -2^63^ = **-9&nbsp;223&nbsp;372&nbsp;036&nbsp;854&nbsp;775&nbsp;808** à 2^63^ - 1 = **9&nbsp;223&nbsp;372&nbsp;036&nbsp;854&nbsp;775&nbsp;807**.
    3. **Représenter en binaire sur un byte les nombres suivants exprimés en base 10 : 65, 132, -24.**
        1. 65 =  (01000001)~2~
        2. 132 = (10000100)~2~ (byte non signé)
        3. -24 = (11101000)~2~
    4. **Calculer les valeurs sur un **byte non signé** (8 bits, toujours positif) suivantes en base 10 : `00000110`, `00011011`, `11110000`, `10110110`**
        1. (00000110)~2~ = 6
        2. (00011011)~2~ = 27
        3. (11110000)~2~ = 240
        4. (10110110)~2~ = 182
    5. **Trouver un moyen simple de calculer ces valeurs (indice : la puissance de 2).**
        1. On attribue une position _p_ à chaque bit, en partant de 0 pour le bit le plus à droite jusqu'à 7 pour le bit le plus à gauche.
        2. On fait la somme des 2^p~1~^ pour les positions _p~1~_ où le bit vaut 1 afin d'obtenir la valeur du nombre en décimal.
        3. Dans le cas de (00011011)~2~, les bits à 1 sont en positions 0, 1, 3 et 4. On calcule donc **2^0^&nbsp;+&nbsp;2^1^&nbsp;+&nbsp;2^3^&nbsp;+&nbsp;2^4^&nbsp;=&nbsp;1&nbsp;+&nbsp;2&nbsp;+&nbsp;8&nbsp;+&nbsp;16&nbsp;=&nbsp;27**.
    6. **Calculer les valeurs précédentes sur byte **signé** (8 bits, pouvant être négatif ou positif) en base 10.**
        1. (00000110)~2~ = 6
        2. (00011011)~2~ = 27
        3. (11110000)~2~ = -16
        4. (10110110)~2~ = -74


## Logique booléenne

!!! question "Exercices sur la logique booléenne"

    1. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **a ET (b OU NON c)**

    2. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **a XOR (b XOR c)**

    3. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **(a ET b) XOR NON(b OU c)**

    4. Dans la question précédente, compare le résultat de **NON(b OU c)** avec **NON(b) ET NON(c)**. Que peux-tu en déduire ?

!!! info "Aide pour les opérations logiques complexes"

    Procède par étape !

??? success "Corrections des exercices sur la logique booléenne"

    1. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **a ET (b OU NON c)**

        | a | b | c | NON c | b OU NON c | a ET (b OU NON c) |
        |---|---|---|-------|------------|-------------------|
        | 0 | 0 | 0 | 1     | 1          | 0                 |
        | 0 | 0 | 1 | 0     | 0          | 0                 |
        | 0 | 1 | 0 | 1     | 1          | 0                 |
        | 0 | 1 | 1 | 0     | 1          | 0                 |
        | 1 | 0 | 0 | 1     | 1          | 1                 |
        | 1 | 0 | 1 | 0     | 0          | 0                 |
        | 1 | 1 | 0 | 1     | 1          | 1                 |
        | 1 | 1 | 1 | 0     | 1          | 1                 |

    2. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **a XOR (b XOR c)**

        | a | b | c | b XOR c | a XOR (b XOR c) | NOT(a XOR (b XOR c)) |
        |---|---|---|---------|-----------------|----------------------|
        | 0 | 0 | 0 | 0       | 0               | 1                    |
        | 0 | 0 | 1 | 1       | 1               | 0                    |
        | 0 | 1 | 0 | 1       | 1               | 0                    |
        | 0 | 1 | 1 | 0       | 0               | 1                    |
        | 1 | 0 | 0 | 0       | 1               | 0                    |
        | 1 | 0 | 1 | 1       | 0               | 1                    |
        | 1 | 1 | 0 | 1       | 0               | 1                    |
        | 1 | 1 | 1 | 0       | 1               | 0                    |

    3. Pour chaque combinaison de valeur des booléens a, b et c, donne le résultat de l'opération logique suivante :<br/>
        **(a ET b) XOR NON(b OU c)**

        | a | b | c | b OU c | NON(b OU c) | (a ET b) | (a ET b) XOR NON(b OU c) |
        |---|---|---|--------|-------------|----------|--------------------------|
        | 0 | 0 | 0 | 0      | 1           | 0        | 1                        |
        | 0 | 0 | 1 | 1      | 0           | 0        | 0                        |
        | 0 | 1 | 0 | 1      | 0           | 0        | 0                        |
        | 0 | 1 | 1 | 1      | 0           | 0        | 0                        |
        | 1 | 0 | 0 | 0      | 1           | 0        | 1                        |
        | 1 | 0 | 1 | 1      | 0           | 0        | 0                        |
        | 1 | 1 | 0 | 1      | 0           | 1        | 1                        |
        | 1 | 1 | 1 | 1      | 0           | 1        | 1                        |

    4. Dans la question précédente, compare le résultat de **NON(b OU c)** avec **NON(b) ET NON(c)**. Que peux-tu en déduire ?

        | b | c | NON(b) | NON(c) | NON(b) ET NON(c) | NON(b OU c) |
        |---|---|--------|--------|------------------|-------------|
        | 0 | 0 | 1      | 1      | 1                | 1           |
        | 0 | 1 | 1      | 0      | 0                | 0           |
        | 1 | 0 | 0      | 1      | 0                | 0           |
        | 1 | 1 | 0      | 0      | 0                | 0           |
        | 0 | 0 | 1      | 1      | 1                | 1           |
        | 0 | 1 | 1      | 0      | 0                | 0           |
        | 1 | 0 | 0      | 1      | 0                | 0           |
        | 1 | 1 | 0      | 0      | 0                | 0           |

        Le résultat obtenu est identique pour **NON(b OU c)** et **NON(b) ET NON(c)**.<br/>
        On peut en conclure que la négation de la proposition _b OU c_ est proposition _NON b ET NON c_.
