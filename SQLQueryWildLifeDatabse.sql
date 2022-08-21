CREATE TABLE MarineAnimals 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL
);

INSERT INTO MarineAnimals (ScientificName, Habitat, Population, Status)
VALUES
('Ursus maritimus', 'Artic Ocean', '31000', 'Vulnerable'),
('Spheniscus mendiculus', 'Oceans', '2000', 'Endangered'),
('Cephalorhynchus hectori', 'Oceans', '7000', 'Endangered'),
('Phocoena sinus', 'Marine (only in the northern Gulf of California)', '10', 'Vulnerable');