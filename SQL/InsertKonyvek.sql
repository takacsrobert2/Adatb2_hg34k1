create or replace procedure spInsert_konyvek
	(
		p_cim 		IN konyvek.cim%type,
		p_szerzo 	IN szerzok.nev%type,
		p_kiado		IN konyvek.kiado%type,
		p_kiadas_eve IN konyvek.kiadas_eve%type,
		p_isbn_azonosito	IN konyvek.isbn_azonosito%type,
		p_nyelv		IN konyvek.nyelv%type,
		p_kategoria		IN konyvek.kategoria%type,

		p_out_rowcnt out int

	)

	authid definer
	as
		v_check_isbn_azonosito int;
	begin
		p_out_rowcnt := 0;

		if v_check_isbn_azonosito = 1 THEN
			INSERT INTO konyvek
				(cim, szerzo, kiado, kiadas_eve, isbn_azonosito, nyelv, kategoria)
			VALUES
				(p_cim, p_szerzo, p_kiado, p_kiadas_eve, p_isbn_azonosito, p_nyelv, p_kategoria);
			p_out_rowcnt := SQL%rowcount;
			COMMIT;
		END if;			

	END spInsert_konyvek;