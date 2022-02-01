INSERT INTO paymentmethods
VALUES 
(1, 'Gotówka'),
(2, 'Karta płatnicza');

INSERT INTO localizations
VALUES 
(1, 'Wileńska', '58', '80220', 'Gdańsk'),
(2, 'Żeromskiego', '14', '70155', 'Sopot'),
(3, 'Mickiewicza', '22', '60322', 'Gdynia'),
(4, 'Jabłoniowa', '8', '80514', 'Sopot'),
(5, 'Topolowa', '18', '80787', 'Gdańsk');

INSERT INTO services
VALUES 
(1, 'Konsultacja ginekologiczna'),
(2, 'Konsultacja psychologiczna'),
(3, 'Psychoedukacja'),
(4, 'Konsultacja stomatologiczna'),
(5, 'Chirurgiczne usuwanie zębów'),
(6, 'Konsultacja ortopedyczna');

INSERT INTO specializations
VALUES 
(1, 'Ginekolog'),
(2, 'Psycholog'),
(3, 'Stomatolog'),
(4, 'Ortopeda');

INSERT INTO specialists
VALUES 
(1, 'Grzegorz', 'Kowalski', 'grzegorz.kowalski@example.com', '111111111', null, null),         
(2, 'Aneta', 'Wieliczka', 'aneta.wieliczka@example.com', '111111111', null, null),		
(3, 'Justyna', 'Bury', 'justyna.bury@example.com', '111111111', null, null),			
(4, 'Krzysztof', 'Zakościelny', 'krzysztof.zakościelny@example.com', '111111111', null, null),	
(5, 'Robert', 'Dębski', 'robert.debski@example.com', '111111111', null, null);			

INSERT INTO specialistspecialization
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,3);

INSERT INTO servicespecialist
VALUES
(1,1),
(2,2),
(3,2),
(4,3),
(5,3),
(6,4),
(4,5),
(5,5);

INSERT INTO localizationspecialist
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5);

