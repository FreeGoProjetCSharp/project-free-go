CREATE TABLE Fridge(
  IdFridge INT NOT NULL,
  PRIMARY KEY (IdFridge))

CREATE TABLE User(
  IdUser INT NOT NULL,
  UserName VARCHAR(45) NULL,
  UserEmail VARCHAR(45) NULL,
  UserPassword VARCHAR(45) NULL,
  Fridge_IdFridge INT NOT NULL,
  PRIMARY KEY (IdUser))



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


CREATE TABLE IngredientsListForFridge (
  Fk_IdIngredients INT NOT NULL,
  Fk_IdFridge INT NOT NULL,
  PRIMARY KEY (Fk_IdIngredients, Fk_IdFridge))

CREATE TABLE IngredientsListInFridge (
  Fk_IdFridge INT NOT NULL,
  Fk_IdIngredients INT NOT NULL,
  Quantity INT NULL,
  Unit VARCHAR(45) NULL,
  Limit SMALLINT NULL,
  PRIMARY KEY (Fk_IdFridge, Fk_IdIngredients),
  INDEX fk_Fridge_has_Ingredients_Ingredients1_idx (Fk_IdIngredients ASC),
  INDEX fk_Fridge_has_Ingredients_Fridge1_idx (Fk_IdFridge ASC),
  CONSTRAINT fk_Fridge_has_Ingredients_Fridge1
    FOREIGN KEY (Fk_IdFridge)
    REFERENCES Fridge (IdFridge)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Fridge_has_Ingredients_Ingredients1
    FOREIGN KEY (Fk_IdIngredients)
    REFERENCES Ingredients (IdIngredients)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)

CREATE TABLE IngredientsInShoppingList (
  Fk_IdShoppingList INT NOT NULL,
  Fk_IdIngredients INT NOT NULL,
  Quantity INT NULL,
  Unit VARCHAR(45) NULL,
  PRIMARY KEY (Fk_IdShoppingList, Fk_IdIngredients),
  INDEX fk_ShoppingList_has_Ingredients_Ingredients1_idx (Fk_IdIngredients ASC),
  INDEX fk_ShoppingList_has_Ingredients_ShoppingList1_idx (Fk_IdShoppingList ASC),
  CONSTRAINT fk_ShoppingList_has_Ingredients_ShoppingList1
    FOREIGN KEY (Fk_IdShoppingList)
    REFERENCES ShoppingList (IdShoppingList)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_ShoppingList_has_Ingredients_Ingredients1
    FOREIGN KEY (Fk_IdIngredients)
    REFERENCES Ingredients (IdIngredients)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)

