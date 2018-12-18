CREATE TABLE Fridge(
  IdFridge INTEGER,
  PRIMARY KEY (IdFridge))

CREATE TABLE User(
  IdUser INTEGER,
  UserName VARCHAR(45) NULL,
  UserEmail VARCHAR(45) NULL,
  UserPassword VARCHAR(45) NULL,
  Fridge_IdFridge INT NOT NULL,
  PRIMARY KEY (IdUser))

insert into User (Username, UserEmail, UserPassword,Fridge_IdFridge) values ("leozmoos","leo.zmoos@cpnv.ch","oui",1)
INSERT INTO [Fridge] DEFAULT VALUES;

CREATE TABLE ShoppingList (
  IdShoppingList INT NOT NULL,
  Fridge_IdFridge INT NOT NULL,
  PRIMARY KEY (IdShoppingList, Fridge_IdFridge))



CREATE TABLE Ingredients (
  IdIngredients INT NOT NULL,
  Nom VARCHAR(45) NULL,
  ExpirationDate DATE NULL,
  Quantity INT NULL,
  Unit VARCHAR(45) NULL,
  PRIMARY KEY (IdIngredients))



CREATE TABLE IngredientsListInFridge (
  Fk_IdFridge INT NOT NULL,
  Fk_IdIngredients INT NOT NULL,
  Quantity INT NULL,
  Unit VARCHAR(45) NULL,
  PRIMARY KEY (Fk_IdFridge, Fk_IdIngredients))

CREATE TABLE IngredientsInShoppingList (
  Fk_IdShoppingList INT NOT NULL,
  Fk_IdIngredients INT NOT NULL,
  Quantity INT NULL,
  Unit VARCHAR(45) NULL,
  PRIMARY KEY (Fk_IdShoppingList, Fk_IdIngredients))

