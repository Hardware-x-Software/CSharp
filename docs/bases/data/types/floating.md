---
hide:
  - toc
---

# Les nombres à virgule flottante
Les nombres entiers permettent des calculs basiques sur un ordinateur mais d'autres nombres sont très utilisés également, les **nombres à virgule**. Il existe deux types de nombres à virgule :

- les **simples** (ou **float**) qui occupent 4 octets ;
- les **doubles** qui occupent 8 octets.

Plus il y a d'octets, plus le nombre sera précis : il pourra représenter plus de chiffres fiables après la virgule. Généralement, on considère pouvoir aller jusqu'à environ 6-7 chiffres après la virgule de façon fiable avec un float, et jusqu'à 13-16 chiffres après la virgule pour un double. Au-delà, il commence à y avoir une trop grande imprécision et on néglige les chiffres suivants. Par exemple, pour un float valant 3.14159266712, on arrondira à 3.1415926 car les chiffres suivants sont faux pour la valeur du nombre Pi.

Leur représentation binaire est plus complexe à comprendre et à calculer que pour les nombres entiers. Cependant, représenter un nombre à virgule en binaire n'a rien d'évident. A l'intérieur de la représentation binaire d'un nombre à virgule flottante, on retrouve trois éléments : le signe, la mantisse et l'exposant. Tous ces éléments peuvent être eux-mêmes représentés par des nombres entiers, ce qui fonctionne bien avec le binaire comme nous l'avons vu juste avant ! L'exposant est là pour positionner la virgule à l'intérieur de la mantisse et donne tout son sens au qualificatif de virgule "flottante". La norme IEEE 754 définit le nombre de bits occupés par chacun de ces éléments pour les floats et pour les doubles.
