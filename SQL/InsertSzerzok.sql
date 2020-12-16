CREATE OR REPLACE PROCEDURE sp_InsertSzerzok
	(
		p_nev IN szerzok.nev%type
	)
	authid definer
	AS
		v_id INT;
	BEGIN
		SELECT max(id) into v_id FROM szerzok;

		if v_id is NULL then
			v_id := 0;
		END if;
		v_id := v_id +1;

		INSERT INTO szerzok(id, nev)
			VALUES (v_id, p_nev);
			
	END sp_InsertSzerzok;