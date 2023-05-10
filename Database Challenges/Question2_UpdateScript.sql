UPDATE public."Employee_tbl"
SET "Email" = CONCAT(SUBSTRING("Email", 1, POSITION('@' IN "Email")), 'company', SUBSTRING("Email" FROM POSITION('.' IN "Email") FOR LENGTH("Email"))) 
WHERE "Email" LIKE '%@%';
