\c products;

CREATE TABLE "Products"(
   "Id" serial PRIMARY KEY,
   "Name" VARCHAR (50) UNIQUE NOT NULL,
   "Price" NUMERIC(10,2)
);

INSERT INTO "Products" VALUES (1, 'CTP20', 150.00);
INSERT INTO "Products" VALUES (2, 'Mock product 2', 2000);

\dt