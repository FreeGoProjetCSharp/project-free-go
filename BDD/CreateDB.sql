-- Creator:       MySQL Workbench 6.3.6/ExportSQLite Plugin 0.1.0
-- Author:        Sylvain.GANDINI
-- Caption:       New Model
-- Project:       Name of the project
-- Changed:       2018-12-07 09:04
-- Created:       2018-11-20 11:21
PRAGMA foreign_keys = OFF;

-- Schema: FreeGo
ATTACH "FreeGo.sdb" AS "FreeGo";
BEGIN;
CREATE TABLE "FreeGo"."Ingredients"(
  "IdIngredients" INTEGER PRIMARY KEY NOT NULL,
  "Nom" VARCHAR(45),
  "ExpirationDate" DATE,
  "Quantity" INTEGER,
  "Unit" VARCHAR(45)
);
CREATE TABLE "FreeGo"."Fridge"(
  "IdFridge" INTEGER PRIMARY KEY NOT NULL
);
CREATE TABLE "FreeGo"."User"(
  "IdUser" INTEGER PRIMARY KEY NOT NULL,
  "UserName" VARCHAR(45),
  "UserEmail" VARCHAR(45),
  "UserPassword" VARCHAR(45),
  "Fridge_IdFridge" INTEGER NOT NULL,
  CONSTRAINT "fk_User_Fridge1"
    FOREIGN KEY("Fridge_IdFridge")
    REFERENCES "Fridge"("IdFridge")
);
CREATE INDEX "FreeGo"."User.fk_User_Fridge1_idx" ON "User" ("Fridge_IdFridge");
CREATE TABLE "FreeGo"."ShoppingList"(
  "IdShoppingList" INTEGER NOT NULL,
  "Fridge_IdFridge" INTEGER NOT NULL,
  PRIMARY KEY("IdShoppingList","Fridge_IdFridge"),
  CONSTRAINT "fk_ShoppingList_Fridge1"
    FOREIGN KEY("Fridge_IdFridge")
    REFERENCES "Fridge"("IdFridge")
);
CREATE INDEX "FreeGo"."ShoppingList.fk_ShoppingList_Fridge1_idx" ON "ShoppingList" ("Fridge_IdFridge");
CREATE TABLE "FreeGo"."IngredientsListForFridge"(
  "Fk_IdIngredients" INTEGER NOT NULL,
  "Fk_IdFridge" INTEGER NOT NULL,
  PRIMARY KEY("Fk_IdIngredients","Fk_IdFridge"),
  CONSTRAINT "fk_Ingredients_has_Fridge_Ingredients1"
    FOREIGN KEY("Fk_IdIngredients")
    REFERENCES "Ingredients"("IdIngredients"),
  CONSTRAINT "fk_Ingredients_has_Fridge_Fridge1"
    FOREIGN KEY("Fk_IdFridge")
    REFERENCES "Fridge"("IdFridge")
);
CREATE INDEX "FreeGo"."IngredientsListForFridge.fk_Ingredients_has_Fridge_Fridge1_idx" ON "IngredientsListForFridge" ("Fk_IdFridge");
CREATE INDEX "FreeGo"."IngredientsListForFridge.fk_Ingredients_has_Fridge_Ingredients1_idx" ON "IngredientsListForFridge" ("Fk_IdIngredients");
CREATE TABLE "FreeGo"."IngredientsListInFridge"(
  "Fk_IdFridge" INTEGER NOT NULL,
  "Fk_IdIngredients" INTEGER NOT NULL,
  "Quantity" INTEGER,
  "Unit" VARCHAR(45),
  "Limit" INTEGER,
  PRIMARY KEY("Fk_IdFridge","Fk_IdIngredients"),
  CONSTRAINT "fk_Fridge_has_Ingredients_Fridge1"
    FOREIGN KEY("Fk_IdFridge")
    REFERENCES "Fridge"("IdFridge"),
  CONSTRAINT "fk_Fridge_has_Ingredients_Ingredients1"
    FOREIGN KEY("Fk_IdIngredients")
    REFERENCES "Ingredients"("IdIngredients")
);
CREATE INDEX "FreeGo"."IngredientsListInFridge.fk_Fridge_has_Ingredients_Ingredients1_idx" ON "IngredientsListInFridge" ("Fk_IdIngredients");
CREATE INDEX "FreeGo"."IngredientsListInFridge.fk_Fridge_has_Ingredients_Fridge1_idx" ON "IngredientsListInFridge" ("Fk_IdFridge");
CREATE TABLE "FreeGo"."UserListeForFridge"(
  "Fk_IdUser" INTEGER NOT NULL,
  "Fk_IdFridge" INTEGER NOT NULL,
  PRIMARY KEY("Fk_IdUser","Fk_IdFridge"),
  CONSTRAINT "fk_User_has_Fridge_User"
    FOREIGN KEY("Fk_IdUser")
    REFERENCES "User"("IdUser"),
  CONSTRAINT "fk_User_has_Fridge_Fridge1"
    FOREIGN KEY("Fk_IdFridge")
    REFERENCES "Fridge"("IdFridge")
);
CREATE INDEX "FreeGo"."UserListeForFridge.fk_User_has_Fridge_Fridge1_idx" ON "UserListeForFridge" ("Fk_IdFridge");
CREATE INDEX "FreeGo"."UserListeForFridge.fk_User_has_Fridge_User_idx" ON "UserListeForFridge" ("Fk_IdUser");
CREATE TABLE "FreeGo"."IngredientsInShoppingList"(
  "Fk_IdShoppingList" INTEGER NOT NULL,
  "Fk_IdIngredients" INTEGER NOT NULL,
  "Quantity" INTEGER,
  "Unit" VARCHAR(45),
  PRIMARY KEY("Fk_IdShoppingList","Fk_IdIngredients"),
  CONSTRAINT "fk_ShoppingList_has_Ingredients_ShoppingList1"
    FOREIGN KEY("Fk_IdShoppingList")
    REFERENCES "ShoppingList"("IdShoppingList"),
  CONSTRAINT "fk_ShoppingList_has_Ingredients_Ingredients1"
    FOREIGN KEY("Fk_IdIngredients")
    REFERENCES "Ingredients"("IdIngredients")
);
CREATE INDEX "FreeGo"."IngredientsInShoppingList.fk_ShoppingList_has_Ingredients_Ingredients1_idx" ON "IngredientsInShoppingList" ("Fk_IdIngredients");
CREATE INDEX "FreeGo"."IngredientsInShoppingList.fk_ShoppingList_has_Ingredients_ShoppingList1_idx" ON "IngredientsInShoppingList" ("Fk_IdShoppingList");
COMMIT;
