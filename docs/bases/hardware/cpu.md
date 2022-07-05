---
hide:
  - toc
---

# Le microprocesseur
!!! warning "Note importante"

    Il ne s'agit pas d'un descriptif complet de l'intérieur d'un processeur. Cette page s'adresse un public large et le but est de vulgariser autant que possible le fonctionnement d'un processeur sans rentrer dans des détails trop techniques. Des mots-clés sont donnés pour aider les personnes souhaitant en savoir plus à faire leurs propres recherches sur le sujet.

Le microprocesseur, Unité Centrale de Traitement ou _Central Processing Unit_ (CPU) en anglais, est souvent appelé le "cerveau" de l'ordinateur. Il est vrai que ce composant informatique sert à effectuer tous les calculs et la logique tels que décrits dans les programmes qu'il exécute. Quand un programme est écrit, il contient une suite d'instructions basiques à faire au processeur. On parle alors de **programmation impérative**. La plupart des processeurs actuels sont de nature impérative en ce sens qu'ils sont faits pour exécuter une succession d'opérations basiques. Nous pouvons imager cela comme une recette de cuisine où chaque étape à réaliser est une instruction.

!!! info "Programme et processus"

    Deux mots sont employés à partir de maintenant : _programme_ et _processus_. Ils désignent deux choses légèrement différentes.<br/>
    Un _programme_ est l'ensemble des instructions. Il n'est pas en cours d'exécution mais se trouve uniquement sur un support de mémoire de stockage comme le disque dur. Par exemple un .exe sous Microsoft Windows.<br/>
    Un _processus_ est une instance d'un programme en cours d'exécution. Il peut y avoir plusieurs instances d'un même programme en cours d'exécution, donc plusieurs processus pour un même programme.

Le processeur fonctionne à l'aide d'électricité et de transistors. Un transistor est un semi-conducteur, c'est-à-dire qu'on peut contrôler s'il laisse ou non passer le courant. Le CPU utilise alors le langage binaire avec uniquement deux valeurs possibles, les **bits** valant 0 (pas de courant) ou 1 (il y a du courant). Le **langage machine**, c'est-à-dire les instructions et les données qu'il traite, est donc constitué de 0 et de 1. Chaque instruction est codée par une suite de bits unique. Ce code est ce qu'on appelle tout simplement l'**opcode** ou _operation code_. L'ensemble des opcodes forme le **jeu d'instructions**. Ils sont déchiffrés par le **séquenceur**.

## Le séquenceur
Une instruction consiste généralement à prendre une ou des données pour effectuer une opération dessus. Le séquenceur du processeur a plusieurs rôles en lien avec le traitement des opérations. Il va commencer par décoder l'instruction, c'est-à-dire voir laquelle dont il s'agit. Une instruction possèdant un opcode unique en langage machine, le séquenceur va donc diriger le traitement des données vers une section du processeur spécifique à cette instruction, souvent à l'intérieur d'une des **unités arithmétiques et logiques**.

## Les unités arithmétiques et logiques
L'unité arithmétique et logique (UAL ou _ALU_ en anglais) est la partie qui va servir à faire les calculs de base en mathématiques (addition, soustraction, division et mulitplication) sur les nombres entiers, des comparaisons entre ces nombres (plus grand que, égal à, différent de, etc). Elle va aussi effectuer des opérations de logique (booléenne). Elle peut servir à faire du décalage de bits que nous aborderons plus tard. A noter qu'un processeur (ou un cœur de processeur) peut contenir plusieurs ALU.

D'autres unités arithméthiques sont quant à elles spécialisées sur les calculs de nombres à virgule. On parle alors d'unité de calcul en virgule flottante, UVF ou FPU en anglais pour _Floating-Point Unit_. D'abord présentes optionnellement dans les ordinateurs via un coprocesseur spécialisé dans ces calculs, elles sont depuis les années 90 intégrées directement dans le CPU. Là aussi, il est possible d'en avoir plusieurs par cœur de processeur pour paralléliser les traitements.

Enfin, des unités de calcul spécialisées dans les calculs vectoriels vont permettre de faire des calculs sur plusieurs valeurs, des vecteurs, simultanément. Elles sont très utilisées en multimédia comme dans les jeux vidéo (calculs accélérés sur des vecteurs 2D ou 3D, matrices, etc).

??? note "Logique booléenne"

    Un petit _aparte_ sur la logique booléenne, sur laquelle nous reviendrons plus tard. La logique booléenne doit son nom au mathématicien britannique George Bool (1815-1864). Aussi appelée algèbre de Bool, il s'agit donc d'une approche algébrique de la logique. Elle met en scène deux valeurs possibles (`VRAI` ou `FAUX`) et quelques opérateurs logiques (`ET`, `OU`, `OU EXCLUSIF`, `NON`). Effectuer une opération logique revient, comme en mathématiques, à prendre un opérateur et, selon cet opérateur, un ou deux opérandes retournant un résultat suivant des règles définies par la logique booléenne. Par exemple, `NON VRAI = FAUX` en toutes circonstances. De la logique mathématique découlent d'autres champs comme le calcul de propositions.

L'ALU peut être découpée en plusieurs parties. Chacune de ces parties, dédiée à une opération donnée, est composée de **portes logiques** (comme le reste du processeur), elles-mêmes constituées de transistors. Une porte logique prend un ou deux bits en entrée et sort le résultat de l'opérateur booléen qu'elle représente. La succession et le branchement uniques de ces portes logiques pour chaque type d'opération va permettre d'obtenir le résultat d'une addition, d'une multiplication, d'une comparaison, etc. Comme les portes logiques ne fournissent le résultat que pour un bit, si le calcul est réalisé sur 32 bits, il faudra dupliquer 32 fois en parallèle le cheminement pour arriver au résultat du nombre entier.

Certaines opérations peuvent être plus longues que d'autres. Il est important de pouvoir synchroniser l'ensemble de ces opérations avec une **horloge**.

## Horloge
Les processeurs que nous utilisons quotidiennement possèdent une horloge interne. On parle de **processeurs synchrones**.
Généralement, l'horloge est un **quartz**, un composant électronique dont la particularité est qu'il oscille à une fréquence stable dès qu'on le stimule électriquement. Cette horloge peut effectuer des tics jusqu'à plusieurs gigahertz (GHz) dans les processeurs modernes, ce qui fait écho à leur fréquence de fonctionnement. L'horloge est essentielle au fonctionnement du processeur car elle permet d'en synchroniser l'ensemble : à chaque cycles, les milliards de transistors au sein du processeur s'ouvrent et se ferment.

En effet, chaque instruction va s'effectuer en un nombre précis de tics d'horloge. Il sera possible d'exécuter plusieurs instructions en un seul cycle pour les plus rapides ; certaines instructions pourront nécessiter un cycle à elles seules quand les plus lentes nécessiteront même plusieurs cycles. Il est indispensable de prédire précisément le nombre de tics nécessaires à l'obtention d'un résultat pour pouvoir aller le récupérer quand il est prêt.

Sans horloge et donc sans synchronisation, il serait difficile de savoir si une opération a rendu son résultat ou si une autre a écrit une autre valeur par dessus ! En effet, pour traiter rapidement les données et les calculs, chaque cœur d'un processeur possède ses propres cases de mémoire extrêmement rapides pour manipuler les données, les **registres**.

## Les registres
Les registres sont donc des cases de mémoire très petites. Chaque registre ne peut contenir qu'une seule donnée et possède un nom pour l'identifier dans une instruction.

En plus des **registres généraux** servant à stocker des valeurs pour les calculs, d'autres types de registres existent.

### Registres généraux
Les registres généraux contiennent les données à traiter en tant qu'opérandes mais aussi les résultats des opérations. Lorsque le séquenceur reçoit une instruction à décoder, celle-ci contient non seulement son opcode mais aussi les registres où récupérer les données et/ou les écrire. Les données d'un registre y restent si elles sont utilisées dans les instructions qui viennent tout prochainement, cela évite d'avoir à aller les chercher de nouveau et donc perdre du temps. Elles sont en revanche stockées et écrasées par d'autres valeurs si elles ne sont pas réutilisées par les quelques instructions suivantes.

??? note "La mémoire cache"

    Le processeur ne contient pas un très grand nombre de registres. Il s'agit d'une mémoire volatile extrêmement rapide mais aussi extrêmement chère. Les données vont et viennent à un rythme très soutenu. Il faut donc aussi pouvoir stocker ces valeurs pour pouvoir les réutiliser plus tard. Certaines instructions ne sont donc pas dédiées au calcul mais au stockage des valeurs depuis les registres vers une mémoire à plus long terme. On pourrait penser à la mémoire principale (RAM) de l'ordinateur mais celle-ci est externe au processeur et donc son accès est très lent. A moins d'avoir une bonne raison de le faire (comme un manque de place), il est préférable pour un processeur moderne d'utiliser sa **mémoire cache**. C'est une mémoire faisant office d'intermédiaire entre les registres et la RAM. Elle se situe à l'intérieur du processeur, donc facilement accessible et est plus rapide que la RAM.

    Les processeurs ont acquis de plus en plus de mémoire cache. De nos jours, elle se découpe en trois couches nommées L1, L2 et L3 - "L" pour _level_ (niveau) en anglais. Le cache L1, le plus proche du processeur, le plus rapide et le plus cher, est souvent dédié à un cœur de processeur et ne fait que quelques centaines de kilo-octets. Le cache L2 est plus grand en taille et généralement commun à tous les cœurs. Enfin le cache L3 est la plus grosse mémoire actuellement présente dans la majorité des processeurs, lui aussi commun à tous les cœurs. Plus un processeur possède de mémoire cache, plus il pourra être performant et fonctionner à son plein potentiel. Un défaut de cache entraîne des ralentissements car il doit faire beaucoup d'aller-retour avec la RAM.

    Cela permet de conserver les données plus longtemps mais toujours de façon volatile : elles sont perdues quand le processus se ferme et/ou l'ordinateur s'arrête. Quand des valeurs stockées en cache (ou en RAM) ont besoin d'être récupérées par le processeur, des instructions servent à aller les chercher. Pour ces opérations consistant à lire et à écrire des données, les registres peuvent contenir des valeurs représentant des adresses mémoire. Nous aurons l'occasion de reparler de l'**adressage mémoire**. Il existe encore plein d'autres types d'instructions servant au bon fonctionnement du processeur et de l'ordinateur au sens large.

### Accumulateur
L'ALU va prendre en entrée un ou deux opérandes pour effectuer une opération dessus. L'un de ces opérandes sera placé dans l'**accumulateur** et l'autre venant d'un registre général par exemple. A la fin de l'opération, l'ALU placera le résultat dans l'accumulateur. Ainsi, s'il y a un besoin immédiat de ce résultat pour une autre opération, il sera déjà prêt pour chaîner les opérations. S'il n'y a plus besoin de cette valeur, elle pourra être stockée dans un registre général jusqu'à en avoir éventuellement de nouveau besoin pour un prochain calcul. L'accumulateur sert donc à stocker des valeurs intermédiaires pour des calculs en plusieurs étapes.

### Compteur ordinal et registre d'instruction
Le **compteur ordinal**, aussi abrégé en PC pour _Program Counter_ en anglais, contient l'**adresse de la prochaine instruction** qui doit être exécutée dans le processus (et non la prochaine instruction elle-même). A chaque début de cycle d'exécution, l'instruction à l'emplacement indiqué par le PC est chargée dans le **registre d'instruction** (IR). La valeur du PC est quant à elle incrémentée pour indiquer l'adresse de l'instruction suivante. Le PC permet donc de savoir où en est l'exécution du processus et l'IR de savoir quelle instruction est à exécuter. Cela est très utile en cas de **commutation de contexte**, par exemple lorsque le processeur doit exécuter plusieurs processus à la fois.

??? note "Commutation de contexte"

    La commutation de contexte a lieu lorsque le processeur exécute plusieurs processus. De notre point de vue, il exécute tous les processus en même temps. La réalité pour le processeur est bien sûr très différente. Un processeur avec une fréquence de plusieurs GHz va beaucoup trop vite pour notre perception du temps si bien qu'il nous semble faire tout à la fois !

    Quand un cœur de processeur est amené à exécuter trois processus A, B et C, il va y avoir un **ordonnancement** établit par le système d'exploitation (s'il est multitâche). Cet ordonnancement va indiquer au processeur l'ordre et la période de temps pour exécuter trois processus. Par exemple : A pendant 2 millisecondes, B pendant 5 millisecondes, C pendant 3 millisecondes, B pendant 6 millisecondes, A pendant 2 millisecondes, etc. L'ordre et la durée d'exécution des processus par intervalle dépendent de l'algorithme de l'ordonnanceur.

    Cependant, le cœur d'un processeur ne peut contenir l'état que d'un seul processus à la fois. Pour passer de A à B, il faut alors sauvegarder l'état du processeur pour le processus A (dans le noyau du système d'exploitation), charger l'état qu'il avait pour le processus B pour ensuite exécuter B. Ces commutations peuvent prendre plus ou moins de temps suivant le processeur et le système d'exploitation utilisé. Ainsi, plus un processeur exécutera de processus en parallèle, plus il sera ralenti car il aura plus de commutation de contexte à effectuer.

### Pointeur de pile
Un programme informatique est une succession d'instructions simples. Cependant, pour structurer le code du programme, les langages de programmation offrent une façon simple de le rendre plus lisible et surtout de le rendre réutilisable : les **fonctions**. Une fonction est donc un bout de code indépendant qui peut prendre des valeurs d'entrée et qui peut retourner une valeur en retour. Lorsqu'une fonction se termine, il faut revenir à l'endroit où elle a été appelée.

De façon plus imagée, on peut imaginer un livre de recettes où pour réaliser un entremet à la page 98, il nous est demandé de réaliser une génoise. La recette de l'entremet lui-même ne nous explique pas comment faire une génoise mais nous renvoie à la page 150. Une fois que la génoise est réalisée, nous revenons à la recette d'entremet pour suivre les instructions à partir de là où nous nous étions arrêtés. A noter que la page 150 pour réaliser une génoise peut-être réutilisée dans plusieurs recettes du livre où il en faut une ! Ce n'est pas la peine de réécrire autant de fois la même recette, un des gros intérêts des fonctions en informatique.

Du fait que les fonctions sont indépendantes, il est possible de les appeler à plusieurs endroits dans le programme. En allant plus loin, il est même possible d'appeler des fonctions dans d'autres fonctions en les imbriquant les unes dans les autres. Pour notre entremet, on peut voir la fonction `realiser_genoise()` contenant elle-même une fonction `battre_oeufs()`.

Pour en revenir au processeur, nous avons vu qu'il possède un compteur ordinal pour savoir quelle est la prochaine instruction à exécuter. Un problème avec les fonctions, c'est que le programme ne peut plus être suivi instruction après instruction : il n'est plus linéaire car il faut faire des aller-retours dans le code ! Reprenons le cas de notre entremet dont la recette est expliquée étape par étape à la page 98. Sauf que nous devons suivre la recette pour faire une génoise. Nous allons donc à la page 150 et nous suivons toutes les instructions pour confectionner la génoise jusqu'à la dernière. A ce stade, si nous étions un processeur uniquement doté d'un compteur ordinal, il nous serait totalement impossible de savoir où revenir car nous n'avons pas mémorisé la page de la recette de l'entremet !

C'est là qu'intervient le **pointeur de pile**. Quand une fonction est appelée, nous avons une **pile d'exécution**. Le but de cette pile est de mémoriser où revenir dans le programme (adresse mémoire) quand chaque fonction appelée se termine. Le mot pile fait sens dans le sens où il s'agit d'une pile d'adresses mémoire : la dernière adresse ajoutée au sommet de la pile est aussi la première à en être retirée. Le pointeur de pile conserve l'endroit où nous nous trouvons dans cette pile.

??? info "Dépassement de la pile d'exécution"

    Comme tout ce qui a trait à la mémoire, la pile d'exécution a une taille limitée. Ainsi, le nombre d'appels de fonction imbriqués ne peut dépasser un certain nombre dépendant du processeur. Si la pile vient à déborder, il va y avoir une écriture des données au-delà de ce qu'il est permis pouvant compromettre l'exécution du programme. Une erreur se produit alors et le programme se termine sous la forme d'un _crash_. On parle de **dépassement de la pile d'exécution** ou de _stack overflow_ en anglais.

### Registre d'état
Contrairement aux autres registres, les bits du **registre d'état** sont indépendants les uns des autres. Il ne servent donc pas à représenter une valeur ensemble, on les lit de façon unitaire pour connaître un état précis du processeur. On parle de **drapeaux** (_flags_ en anglais). Par exemple, pour savoir si le résultat d'une soustraction a donné un résultat négatif on va regarder si le bit correspondant dans le registre d'état vaut 0 (NON) ou 1 (OUI). Cet exemple est très utilisé pour effectuer des branchements conditionnels, par exemple pour exécuter une portion de code uniquement si la valeur A est plus grande que la valeur B.

Il existe au minimum quatre drapeaux dans le registre d'état d'un processeur actuel, d'autres peuvent exister suivant l'architecture :

* **Zéro** (_Zero_), pour savoir si le résultat d'une opération est nul ;
* **Retenue** (_Carry_), pour savoir si le résultat d'une opération a dégagé une retenue que le processeur n'est pas capable de gérer. Par exemple, pour un processeur 8 bits qui détecte une retenue devant s'effectuer sur un neuvième bit inexistant. Ce flag permet d'émuler des calculs de nombres sur plus de bits, par exemple sur 16 bits ici, en propageant la retenue ;
* **Signe** (_Sign_), pour savoir si le résultat d'une opération est négatif ;
* **Dépassement de capacité** (_Overflow_), pour savoir si la valeur d'une opération devrait être codée sur plus de bits que le processeur peut supporter.

## Autres éléments
Nous venons de voir ce qui pourrait être la base commune à tout processeur un minimum moderne. Il existe bien d'autres structures à l'intérieur d'un processeur pour étendre ses possibilités, optimiser son fonctionnement, etc. Nous n'allons pas détailler l'entièreté de ce qui compose un processeur moderne car cette page pourrait faire la taille d'un immeuble !

Le bon fonctionnement du processeur ne peut être assuré sans une mémoire qui contient les instructions et les données à traiter par ces instructions. Nous allons donc voir un peu comment celle-ci s'organise et fonctionne à son tour dans la prochaine partie.


??? info "Intel explique le fonctionnement d'un processeur"

    **Partie 1 :**<br/>
    <iframe width="560" height="315" src="https://www.youtube-nocookie.com/embed/vgPFzblBh7w" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

    **Partie 2 :**<br/>
    <iframe width="560" height="315" src="https://www.youtube-nocookie.com/embed/o_WXTRS2qTY" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

??? info "Sources"

    * https://c9x.me/x86/
    * https://fr.wikibooks.org/wiki/Fonctionnement_d%27un_ordinateur/L%27unit%C3%A9_de_contr%C3%B4le
    * http://www.courstechinfo.be/Techno/CPU.html
    * http://igm.univ-mlv.fr/~dr/XPOSE2011/archi7/proc.html
    * https://ecariou.perso.univ-pau.fr/cours/archi/cours-7-cpu.pdf
