create or replace procedure sf_GetSzerzoID
(
	p_nev in szerzo.nev%type
);
return INT
deterministic

as
	temp INT;
	temp_cnt INT;
begin
	select count(*) into temp_cnt  FROM szezok where nev = p_nev;

	if temp_cnt = 0 then
		return null;
	else
		SELECT id into temp from szerzok where nev = p_nev;
	end if;

	return temp;

end sf_GetSzerzoID;