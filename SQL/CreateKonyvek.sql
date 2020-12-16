DROP TABLE konyvek;

CREATE TABLE konyvek
	(
		cim VARCHAR2(300) NOT NULL,
		szerzo int NOT NULL,
		kiado VARCHAR2 (200) NOT NULL,
		kiadas_eve DATE NOT NULL,
		isbn_azonosito VARCHAR2(13) NOT NULL,
		nyelv VARCHAR2(80) NOT NULL,
		kategoria VARCHAR2(200) NOT NULL,

		CONSTRAINT pk_konyvek PRIMARY KEY(isbn_azonosito),
		CONSTRAINT ch_konyvek_nyelv CHECK(nyelv IN ('magyar', 'angol', 'nemet', 'spanyol', 'olasz', 'orosz', 'mandarin')),
		CONSTRAINT fk_szerzok FOREIGN KEY(szerzo) REFERENCES szerzok(id)
	);