CREATE OR REPLACE FUNCTION sf_check_isbn_azonosito
	(
		p_isbn_azonosito IN konyvek.isbn_azonosito%type

	)
	return INT
	deterministic

	AS
		v_isbn_azonosito_char CHAR(1);
		v_i INT;
	BEGIN
		if p_isbn_azonosito is NULL THEN
			return 0;
		END if;
		if length(TRIM(p_isbn_azonosito)) = 13 THEN
			v_i := 1;
			while v_i <= 3 loop
				v_isbn_azonosito_char := substr(p_isbn_azonosito, v_i, 1);
				if not (ascii('7') <= ascii(v_isbn_azonosito_char) AND ascii(v_isbn_azonosito_char) <= ascii('9')) THEN
					return 0;
				END if;
				v_i := v_i +1;
			END loop;

			while v_i <= 13 loop
				v_isbn_azonosito_char := substr(p_isbn_azonosito, v_i, 1);
				if not (ascii('0') <= ascii(v_isbn_azonosito_char) AND ascii(v_isbn_azonosito_char) <= ascii('9')) THEN
					return 0;
				END if;
				v_i := v_i + 1;
			END loop;
			return 1;
		END if;
		return 0;

	END sf_check_isbn_azonosito;