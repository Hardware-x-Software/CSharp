---
hide:
  - toc
---

# Historique des langages de programmation

!!! warning "Note importante"

    Le but de cet historique n'est pas d'être exhaustif en présentant l'intégralité des langages de programmation qui ont existé. Ce serait une tâche absolument impossible et sans grand intérêt. Plutôt que cela, je te propose de passer en revue les différentes évolutions qui sont apparues au fil du temps ainsi que la naissance des principaux langages utilisés de nos jours. Je m'excuse par avance de ne peut-être pas parler de ton langage préféré...

Comme nous l'avons vu dans la section "**Des cailloux à l'informatique**", la première personne à programmer au monde était Ada Lovelace. Elle a programmé la machine analytique de Charles Babbage. Les notes qu'elle a ajoutées pour pouvoir calculer les nombres de Bernouilli ont permis d'établir qu'il s'agissait du tout premier programme informatique jamais créé. De plus, jusque là, les autres machines programmées exécutaient leur "code" séquentiellement. Le programme d'Ada Lovelace contenait quant à lui la toute première **boucle conditionnelle**, un concept propre à la programmation informatique.

Les machines conçues jusque là sont dédiées à une résoudre un problème spécifique. Pour un autre problème, il fallait constuire une nouvelle machine. En 1936, Alan Turing pose le concept abstrait de **machine de Turing**. Il s'agit, pour résumer, d'une machine théorique capable de lire un code qu'on lui soumet pour résoudre un problème donné. Il n'y a plus besoin de construire une nouvelle machine pour résoudre un autre problème, on change le code fournit à la machine pour qu'elle résolve ce nouveau problème. De nos jours, ce code est ce qu'on appelle un **algorithme**. La première machine au monde à devenir _Turing-complet_ est l'ENIAC en 1945 grâce à l'ajout d'une mémoire morte primitive contenant le code à exécuter. Au lieu de refaire les câblages pendant plusieurs jours pour reprogrammer l'ENIAC, il ne faut plus que quelques heures pour le faire travailler sur un nouveau problème.

Durant la Seconde Guerre Mondiale, l'ingénieur allemand Konrad Zuse conçoit _**Plankalkül**_ qu'il considère comme étant le premier **langage de programmation de haut niveau**. Sa conception ne fait pas beaucoup d'écho, par temps de guerre et la préoccupation de Zuse à vendre son ordinateur, le Zuse 3. Ainsi, la première publication à propos de _Plankalkül_ ne sort qu'en 1948. Malgré l'innovation importante qu'il représente, le langage restera inconnu.<br/>
_Plankalkül_ n'a été implémenté qu'en 1975 et le premier **compilateur** pour ce langage n'est finalisé qu'en l'an 2000.

## Compilation et langages modernes
Un compilateur permet de transformer un **code source**, écrit dans un langage de programmation de haut niveau (facilement compréhensible par un être humain) vers un **code objet**, généralement en langage machine compréhensible par une machine (processeur) cible.<br/>
Le premier compilateur, ou en tout cas l'ancêtre d'un compilateur à proprement parler, est le _**A-0 System**_ (_Arithmetic Language version 0_) écrit par Grace Hopper en 1951 pour l'UNIVAC I. Grace Hopper réalise que, au-delà des calculs, l'ordinateur peut lui-même assembler des suites d'instructions isolées, les sous-programmes ou _subroutines_ en anglais, pour constituer un programme complet. Dans le cadre du _**A-0 System**_, les sous-programmes pouvaient convertir du code symbolique mathématique en langage machine. Grace Hopper a enregistré ces _subroutines_ sur une bande magnétique et les a identifié de façon unique avec un code. Après le code de la _subroutine_, on entrait les paramètres d'entrée. Le programme à écrire consistait alors en une succession de codes identifiant les _subroutines_ avec leurs paramètres respectifs. Lors de l'exécution, la machine allait chercher les instructions à exécuter en les retrouvant sur la bande magnétique.<br/>
Il y aura plusieurs itérations pour améliorer cet ancêtre du compilateur, jusqu'au _**B-0**_ (_Business Language Version 0_) renommé _**FLOW-MATIC**_. Pour celui-ci, Grace Hopper a eu la brillante idée dès 1955 qu'un programme informatique peut être écrit en anglais car les lettres étaient d'autres symboles que l'ordinateur pouvait reconnaître et convertir en code machine. Dédié à des applications métiers, le _**FLOW-MATIC**_ a permis à l'UNIVAC I de comprendre 20 mots-clés inspirés de l'anglais de 1955 à 1959.

En 1957, le _**FORTRAN**_ (_mathematical FORmula TRANslating system_) est déployé. C'est un langage de programmation de haut niveau initialement proposé en 1953 par John Backus pour faciliter les calculs de nombres en virgule flottante sur l'IBM 704. Bien que ses auteurs n'aient pas eu l'idée d'employer des mots-clés en anglais pour faciliter le développement de programmes informatiques, le FORTRAN sera l'un des premiers, si ce n'est le premier, langages informatiques à mettre cette idée en pratique.<br/>
Fortran est un langage généraliste qui continue d'être mis à jour. Sa dernière version est le Fortran 2018 en attendant une version Fortran 202x. Selon l'index TIOBE (juin 2022), Fortran occupe la 26ème place des langages les plus populaires.

Deux autres langages de haut niveau ont été conçus dans les années 50 :

* Le **Lisp** (_list processing_) qui est à la fois le premier **langage fonctionnel** mais aussi le premier **langage moderne interprété** ;
* Le **COBOL** (_COmmon Business Oriented Language_), initialement conçu pour la programmation d'applications de gestion et de nos jours essentiellement utilisé dans les secteurs des banques, assurances, etc.

Fortran, Lisp et Cobol ont inspiré la plupart des langages qui sont apparus ensuite jusqu'à nos jours, directement et indirectement.

## American Standard Code for Information Interchange
Comme nous l'avons vu dans le chapitre qui lui est consacré, le microprocesseur ne sait traiter que des données numériques : des nombres entiers et des nombres à virgule flottante. En aucun cas, le CPU n'est capable de lire un texte directement. Pour y parvenir, il faut créer une table d'association entre un caractère (lettre, ponctuation, etc) et une valeur numérique. Par exemple, il est possible de faire en sorte que le CPU reconnaisse la valeur numérique `14` comme étant la lettre `F`, ou encore la valeur numérique `3` pour le point d'interrogation `?`.

Puisque les premiers langages modernes utilisaient des mots-clés tirés de l'anglais, et donc écrits à l'aide de l'alphabet latin, il a fallu standardiser la façon dont les textes étaient représentés pour les ordinateurs. En effet, avant la standardisation, il existait de nombreux codages de caractères incompatibles entre eux : chaque machine possédait sa propre table d'association. Ainsi, en 1960, l'Organisation Internationale de Normalisation (_International Organization for Standardization_ ou ISO en anglais) crée un comité technique dont le but est de sortir un code standard de transmission de données. En 1963, la première version du code américain normalisé pour l'échange d'information (_American Standard Code for Information Interchange_ ou ASCII) apparaît. Des mises à jour de ce code seront effectuées pour ajouter de nouveaux symboles à des emplacements prévus mais vides jusqu'en 1986, année de la dernière version de l'ASCII en vigueur de nos jours. Grâce à cette standardisation, la lecture de données textuelles peut se faire sans avoir besoin de les convertir au préalable pour une nouvelle machine.

L'ASCII code les caractères sur 7 bits et permet donc de représenter un total de 128 caractères différents, dont 95 caractères imprimables :

* les 26 lettres de l'alphabet latin, chacune en minuscules et en majuscules ;
* les 10 chiffres arabes ;
* des symboles mathématiques,
* des symboles de ponctuation ;
* des symboles spéciaux comme l'esperluette (&) ou le dollar américain ($).

!!! tip "Et pour les autres caractères ?"

    Avec seulement 128 caractères codés, l'ASCII ne peut représenter que les caractères de la langue anglaise. Plusieurs méthodes ont émergé pour ajouter de nouveaux caractères et c'est le standard **Unicode** qui s'est imposé à l'échelle internationale, notamment dans sa forme UTF-8. La première version du standard Unicode date de 1991 et de nouveaux caractères sont régulièrement ajoutés. L'Unicode 14.0 est publié le 9 septembre 2021 et contient 144&nbsp;697 caractères différents.

## Simula et la notion de classe
**Simula** (_SIMple Universal LAnguage_) est un langage méconnu et pourtant qui va initier une révolution dans la programmation. Si Lisp a introduit la programmation fonctionelle, Simula apporte quant à lui la notion de **classe**. Il est en effet le premier langage à implémenter le modèle de classe de Hoare (_record classes_) en 1967, d'après les travaux de Charles Antony Richard Hoare.

Une _record class_ permet de créer des _references_ selon Hoare, chaque référence étant unique dans le programme avec ses propres valeurs. Par exemple, une classe Voiture permet de créer une multitude de Voitures, chacune étant dotée d'une couleur ou d'une motorisation qui lui est propre. Les classe peuvent être _héritée_ et _mises en relation_ les unes avec les autres.

## La programmation orientée objet
Simula 67 ne permet pas encore la **programmation orientée objet** à proprement parler, mais il implémente déjà les principaux concepts de ce paradigme de programmation. Alan Kay sera l'auteur de la programmation orientée objet avec le langage _Flex_ qui donnera ensuite le **Smalltalk**, initié en 1969 et publié en 1980. Les _record classes_ dénommées par Hoare sont ici nommées _classes d'objets_ et les _references_ sont quant à elles baptisées _objets_ dans Smalltalk.

Smalltalk a inspiré plusieurs langages dont les plus connus sont **Ruby**, **Objective-C** ou encore **Java**. Ce dernier a lui-même fortement inspiré le langage **C#** que nous allons justement étudier à partir du prochain chapitre.

## Entre temps...
De nombreux autres langages sont apparus entre la publication de Simula et celle de Smalltalk. S'il n'est pas possible de parler de tous ces langages, il est néanmoins faisable d'en présenter rapidement ceux qui sont encore très utilisés de nos jours. C'est le cas notamment du langage **C**, inventé en 1972 par Dennis Ritchie et rectifié par Brian Kernighan. La version stabilisée du langage est publiée en 1978. C est un langage généraliste dit de _bas niveau_ car il offre des outils pour une gestion très fine de la mémoire ou encore la possibilité d'inclure du code directement en langage assembleur. De fait, C est particulièrement adapté à l'écriture de programmes intimement lié au matériel informatique tels que des pilotes (_drivers_, logiciels communiquant directement avec un matériel donné), des compilateurs, des systèmes d'exploitation et bien d'autres encore. C occupe la deuxième place du classement TIOBE en juin 2022.

Bjarne Stroustrup commence à travailler sur une évolution du langage C intitulée **C with classes** (_C avec des classes_) en 1979, à l'époque où lui et Ritchie travaillent chez Bell. A ce moment-là, le langage C n'est pas encore très connu et son utilisation pour de gros programmes est assez compliquée. Si Simula offre des possibilités intéressantes d'un point de vue programmatique pour écrire de longs programmes, grâce à la notion de classes, il souffre de plusieurs défauts dont une vitesse d'exécution assez lente. Stroustrup s'inspire ainsi de Simula pour apporter la notion de classe au langage C et le rendre plus facile à programmer. En 1983, le langage est renommé en **C++** pour symboliser l'amélioration du langage C et s'enrichie de nombreuses nouvelles fonctionnalités. Le langage est commercialisé pour la première fois en 1985 mais sans être standardisé. Il faudra attendre 1998 pour que le langage soit standardisé par l'ISO face à la popularité grandissante du langage en devenant le **C++98**. De nouveaux standards ont été publiés depuis, ajoutant de nouvelles fonctionnalités également dans sa bibliothèque standard. C++ occupe la quatrième place du classement TIOBE en juin 2022.

## Et de nos jours ?
Le langage **Python** est le dernier langage du top 5 dans le classement TIOBE dont je n'ai pas encore parlé dans cet historique. C'est même le langage le plus populaire en juin 2022 ! A la fin des années 1980, le développeur Guido van Rossum travaille sur le système d'exploitation distribué Amoeba. Amoeba utilisait le _Bourne shell_ (`bsh`) comme interface utilisateur en ligne de commandes mais les appels systèmes étaient difficilement interfaçables avec ce _shell_. Guido van Rossum, qui a également participé au développement du langage **ABC** pour Amoeba, s'inspire de ce dernier pour développer un nouveau langage de script sur son temps libre. Le nom de ce projet est tiré de la série télévisée britannique _Monty Python's Flying Circus_. Van Rossum est resté le développeur principal du projet jusqu'au 12 juillet 2018, date à partir de laquelle il est néanmoins leader du projet ("_Benevolent Dictator for Life_").<br/>
Comme pour ABC, Python utilise l'indentation comme syntaxe. D'autres sources ont permis de forger le langage tel que la gestion des exceptions de **Modula-3** ou encore le langage C. Python est un langage de haut niveau d'abstraction, c'est-à-dire qu'il masque les détails du matériel informatique au développeur. Cet avantage couplé à sa syntaxe facile à appréhender rend non seulement le développement plus rapide mais permet en plus de s'initier à la programmation.

Python est un langage dit **multi-paradigme** puisqu'il permet la programmation impérative structurée, orientée objet et fonctionnelle. Il s'agit également d'un **langage interprété**, en opposition aux **langages compilés**.

La création de nouveaux langages ne s'arrête pas là ! Chaque décennie voit apparaître plusieurs nouveaux langages. S'il est encore un peu tôt pour parler de langages de la décennie en cours, entre 2010 et 2019 quelques langages intéressants sont apparus. Le langage **Rust** par exemple en est un des meilleurs exemples car il gagne en popularité notamment grâce à sa rapidité d'exécution, sa fiabilité et son écosystème pratique.

## Catégorisation des langages de programmation
Les langages de programmation sont très nombreux. C'est pourquoi cette page ne peut pas tous les présenter indépendamment et n'a pas du tout pour but d'en être une liste exhaustive. La quantité de langages différents, chacun avec ses particularités, a entraîné la création de catégories. Chaque langage se retrouve dans une et même souvent plusieurs catégories différentes à la fois. Je vais t'en présenter quelques unes rapidement.

### Langages interprétés et compilés
Comme nous l'avons vu pour Python, il s'agit d'un langage dit "interprété". Cette catégorie s'oppose à une autre, celle des langages dits "compilés".

Un langage compilé va être traduit en langage machine, avec les instructions binaires qui sont directement comprises par le processeur. Il faut donc un ensemble d'outils pour obtenir ce qu'on appelle un _exécutable_ dont le compilateur qui s'occupe de cette traduction. Le code binaire obtenu est intimement lié au jeu d'instructions du processeur et donc son architecture. Comme le code est directement traduit en langage machine, le programme s'exécutera très rapidement. En revanche, cela signifie aussi qu'un processeur de la famille `x86` ne peut pas exécuter un programme compilé pour un processeur d'architecture `ARMv8` (et vice-versa).

Un langage interprété n'est pas directement converti en langage machine. Il va passer par un programme intermédiaire dont le rôle est de traduire le code source en langage machine au fil de l'exécution. Dans certains cas, l'interpréteur utilise un code intermédiaire appelé _bytecode_. Ce programme intermédiaire est l'**interpréteur**. Le premier langage interprété est le Lisp. Cela présente donc l'avantage de se passer d'une étape potentiellement longue de compilation. Un autre avantage de taille est que le code peut être exécuté indifféremment quelque soit l'architecture du processeur. En effet, c'est à l'interpréteur d'être adapté à l'architecture. La contrepartie est cependant une vitesse d'exécution plus lente par rapport à un programme compilé en langage machine. Cependant, il est à noter que de gros efforts sont faits pour réduire l'écart entre les deux types de procédés.

Certains langages vont encore plus loin en utilisant une **machine virtuelle**. C'est le cas de Java et de C# par exemple. Les programmes sont traduits en _bytecode_, un langage machine pour la machine virtuelle. La machine virtuelle a ensuite le rôle de traduire le _bytecode_ en langage machine pour le processeur-cible. Il est alors possible de distribuer un programme en _bytecode_ et de l'exécuter sur n'importe quel processeur.

!!! note 

    Les notions de "langage compilé" et "langage interprété" sont un peu abusives. Le langage lui-même n'est ni compilé, ni interprété. C'est la façon dont le code source est converti en langage machine qui importe. Si le langage C est usuellement compilé, rien n'empêche d'écrire un interpréteur de langage C. A l'inverse, il est tout à fait possible de compiler du Python en langage machine comme c'est le cas avec Pyjion.

### Paradigmes
Les langages sont aussi classés par rapport aux paradigmes qu'ils permettent d'employer. Nous avons déjà eu l'occasion d'aborder cette notion sans encore l'expliquer. Pour faire simple, en programmation, un paradigme est une façon dont un langage va nous permettre d'écrire un programme (tout ou partie).

Certains langages comme le C ne proposent qu'un seul paradigme, la programmation procédurale. D'autres langages vont proposer plusieurs paradigmes qu'il se possible de mélanger dans un même programme selon les besoins. Par exemple le Rust permet entre autres la programmation procédurale, fonctionnelle ou encore - un peu - orientée objet.


??? info "Sources"

    - https://www.computinghistory.org.uk/det/5487/Grace-Hopper-completes-the-A-0-Compiler/
    - https://www.lemonde.fr/blog/binaire/2015/03/08/la-petulante-grace-hopper/
    - https://www.tiobe.com/tiobe-index/
    - http://www.unicode.org/versions/Unicode14.0.0/
    - https://medium.com/%C3%A9cosyst%C3%A8me-des-langages-de-programmation/simula-le-language-de-lombre-db04c7feb715
    - http://progwww.vub.ac.be/~tjdhondt/ESL/Simula_to_Smalltalk_files/Record-Handling-Hoare.pdf
    - https://amturing.acm.org/award_winners/kay_3972189.cfm
    - https://www.stroustrup.com/
    - https://interstices.info/bjarne-stroustrup-le-pere-de-c-un-langage-qui-a-de-la-classe/
    - https://www.fil.univ-lille1.fr/~marvie/python/introduction.html
    - https://www.rust-lang.org/
    - https://www.trypyjion.com/