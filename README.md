# 1º Projeto de Linguagens de Programação II 2018/2019

## Who did this project?

* __Inês Gonçalves__
  * a21702076

* __Inês Nunes__
  * a21702520

## Git repository

We worked in a git repository that can be found here: 
[link](https://github.com/ineesgoncalvees/Projeto1_PL2) .

## Task distribution

Both of the members participated equally in the project, it being done
with both of them next to each other, working in both computers.

* __Inês Gonçalves__
  * Classes: GamesInfo, GamesList, InterfaceManager, Program.
  * Helped with the fluxogram;
  * Made the UML;
  * Helped with the comments.

* __Inês Nunes__
  * Classes: GamesInfo, GamesList, InterfaceManager, Program.
  * Added comments;
  * Made the fluxogram.
  * Made the report.

## Our solution

### Architecture

For this project, we used _classes_, _lists_, _foreach_, _ToString_ and a _StreamReader_ to read
our _games.csv_ file.

The game starts by rendering the menu to the player, being given three options.
According to the input, a _switch case_ will call the corresponding methods.

When the player chooses "1", an ID will be asked. If it doesn't recognize the input, 
a error message will be shown and the player will be asked to put a new one.
If it's valid, then, a CheckID() method will be called.

The _CheckID()_ will run a foreach to check if the ID given is a valid one, and if it is,
it will _override_ the ToString with the correct information.
Our _ToString()_ consists in all parameters needed for the game's information.

### UML Diagram

<p align="center">
  <img src="https://i.imgur.com/gBYts6N.png" alt="UML diagram"/>
</p>

### Fluxogram

<p align="center">
  <img src="https://i.imgur.com/c7mOK2U.png" alt="Fluxogram"/>
</p>

## Conclusions

With this project, we learned how to better use a _List_ and we have a better understanding
of the _StreamReader_.

Unfortunately, we could not finish all the project due to not knowing how to properly do the rest.
We felt like we struggled a lot with the search method, and although we understand what is being given
during class, we do not know how to apply that knowledge on a project this complex.

## References

* <a name="ref1">[1]</a> Whitaker, R. B. (2016). The C# Player's Guide
  (3rd Edition). Starbound Software.
