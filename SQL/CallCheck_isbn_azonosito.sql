SET serveroutput ON;
DECLARE
	v_call_isbn_azonosito INT;
	v_isbn_azonosito konyvek.isbn_azonosito%type := '9789633702345';
BEGIN
	v_call_isbn_azonosito := sf_check_isbn_azonosito(v_isbn_azonosito);

	if v_call_isbn_azonosito = 1 THEN
		DBMS_OUTPUT.PUT_LINE('Helyes formátum:' ||v_isbn_azonosito);
	ELSE 	
		DBMS_OUTPUT.PUT_LINE('Helytelen formátum:' ||v_isbn_azonosito);
	END if;
END;
	