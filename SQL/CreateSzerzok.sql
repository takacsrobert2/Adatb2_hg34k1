DROP TABLE szerzok;

CREATE TABLE szerzok
(
	id INT NOT NULL,
	nev VARCHAR2(200) NOT NULL,

	CONSTRAINT pk_szerzok PRIMARY KEY (id)
);