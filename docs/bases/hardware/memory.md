---
hide:
  - toc
---

# La mémoire
Il existe plusieurs types de mémoire dans un ordinateur. Nous allons suivre le cheminement d'un programme du moment où on double-clique dessus jusqu'à son exécution par le processeur.

Tout d'abord, le programme est contenu sur une mémoire qui est permanente y compris quand l'ordinateur est éteint. Il peut s'agir d'un disque dur magnétique ou de mémoire flash comme dans un SSD, une clé USB ou une puce de mémoire flash à l'intérieur d'un smartphone. Un disque dur magnétique ou de la mémoire flash est ce qu'on appelle de la **mémoire de masse**. Elle est abondante dans un ordinateur, actuellement plus téraoctets, et relativement peu chère en comparaison des autres types de mémoires. Plus la mémoire est rapide et, généralement, plus elle est chère et donc moins abondante.

Lorsqu'on souhaite exécuter un programme, il est chargé tout ou partie depuis son emplacement sur la mémoire de masse vers la **mémoire vive** (RAM). Le programme va, au fur et à mesure de son exécution, avoir besoin de données encore présentes sur le disque et devra donc demander leur chargement en mémoire si nécessaire. Cette opération peut prendre plus ou moins de temps, notamment en fonction de la vitesse du disque et le débit disponible sur le bus (SATA, PCI-Express). La RAM est disponible pour le grand public à hauteur de plusieurs gigaoctets.

Comme nous l'avons vu précédemment, l'exécution du programme se déroule à l'intérieur du processeur lequel est doté de **registres**. Avant de leur parvenir, le processeur va charger une partie du programme dans ses **différents niveaux de cache** pour s'alimenter plus rapidement en instructions et en données à traiter. Il met régulièrement à jour son cache depuis ou vers la mémoire vive pour poursuivre l'exécution du programme. Plus la quantité de cache est grande, moins les aller-retours seront fréquents et donc plus le processeur pourra travailler efficacement. Suivant le modèle du processeur et le niveau du cache, la quantité de mémoire pourra aller de plusieurs mégaoctets (cache L3) à quelques centaines de kilooctets (cache L1). Le registres ferment la marche en ne faisant que quelques octets.

## Chargement depuis un périphérique de stockage
Pour un système multitâche, attendre que des données se chargent depuis un périphérique (disque dur, CD, clé USB, etc) vers la mémoire principale monopolise inutilement le microprocesseur. Il existe donc, pour certains bus de données largement utilisés de nos jours, des chargements de données n'impliquant pas directement le processeur. Celui-ci va seulement initier et terminer le transfert des données et c'est un contrôleur annexe qui va s'occuper de faire transférer les données depuis le périphérique. Pendant ce temps, le CPU peut s'adonner à d'autres tâches comme exécuter un ou plusieurs autres processus. Il en va exactement de même pour écrire les données vers l'un de ces périphériques.<br/>
Les détails à ce sujet sortent totalement de la portée des tutoriels à venir donc ils ne seront pas davantage expliqués ici. Cependant, un exemple de contrôleur qui assiste le microprocesseur nous pouvons évoquer l'**accès direct à la mémoire**, ou DMA pour [_Direct Memory Access_](https://fr.wikipedia.org/wiki/Acc%C3%A8s_direct_%C3%A0_la_m%C3%A9moire) en anglais.

## Adressage mémoire
La mémoire principale de l'ordinateur peut-être vue comme une immense rue dans une ville où une case-mémoire serait une maison. Chaque case-mémoire peut accueillir une unique valeur de 8 bits, ce qu'on appelle un **octet**. Un ordinateur _gamer_ moyen possède généralement 16 gigaoctets de RAM en 2022, soit 16 milliards d'octets.

Comme dans une ville, chaque maison a une adresse unique. Dans la mémoire, c'est pareil car une case-mémoire possède sa propre adresse. Ici, l'**adresse mémoire** est un nombre, qui s'incrémente pour chaque case-mémoire successive. On a donc une case-mémoire à l'adresse 0, puis 1, ensuite 2, et ainsi de suite jusqu'à la dernière.

De nos jours, le CPU de nos ordinateurs personnels n'accède plus directement à la mémoire vive par les **adresses physiques**, c'est-à-dire le véritable numéro de l'adresse dans la mémoire. En effet, pour éviter qu'un processus écrive ou accède à la zone de la mémoire utilisée par un autre processus, un composant vient s'intercaler entre le microprocesseur et la RAM. Ce composant est l'**unité de gestion de la mémoire**, abrégé en anglais par MMU pour _memory management unit_. La MMU est intégrée au CPU bien qu'initialement dans un circuit intégré dédié.
Le processeur ne manipule alors plus des adresses physiques lorsqu'il exécute un processus mais des **adresses virtuelles**. Un des rôles de la MMU est de traduire les adresses virtuelles en adresses physiques pour récupérer ou stocker des données dans la RAM. Par le biais de la MMU, le système d'exploitation peut effectuer plusieurs choses intéressantes :

* Tout d'abord, il peut protéger l'accès et l'écriture de données dans des régions de la mémoire vive qui sont occupées par d'autres processus. Cela évite de pouvoir récupérer les données d'un autre processus ou de corrompre/injecter des données dans l'exécution d'un autre processus. Par exemple si un programme vient à consommer toute la mémoire vive du système ;
* Comme pour un disque dur, la mémoire vive peut être fragmentée. Grâce à la MMU, le processeur n'a pas à se préoccuper de cette fragmentation et agit comme la mémoire était contiguë ;
* D'un point de vue d'un processus (et du processeur), la mémoire vive est illimitée grâce à la mémoire virtuelle.

!!! info "Comment fonctionne un débogueur ?"

    Un débogueur est un processus qui s'attache à un autre processus. Il permet d'y détecter les erreurs et problèmes durant son exécution et facilite ainsi la correction de bugs. Il a un accès total à la mémoire du processus attaché pour en inspecter les valeurs voire les modifier au cours de son exécution. Cela vient contredire ce qui a été décrit précédemment quant à la protection de la mémoire des processus à l'aide de la MMU ! Il ne faut pas oublier que c'est le système d'exploitation qui dicte le fonctionnement de la MMU. Or, un débogueur utilise une _interface de programmation_ (API) fournie par le système d'exploitation pour fonctionner.
