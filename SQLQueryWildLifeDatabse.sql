CREATE TABLE MarineAnimals 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL
);

CREATE TABLE BigCats 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL
);

CREATE TABLE Primates 
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

INSERT INTO BigCats(ScientificName, Habitat, Population, Status)
VALUES
('Panthera tigris', 'Tropical rainforests, evergreen forests, temperate forests, mangrove swamps, grasslands, and savannas', '3900', 'Endangered'),
('Panthera pardus orientalis', 'Temperate, Broadleaf, and Mixed Forests', '84', 'Critically Endangered'),
('Panthera uncia', 'High mountains', '6500', 'Vulnerable'),
('Panthera onca', 'Forests, Grasslands', '10001', 'Least concern / Near threatened');

INSERT INTO Primates (ScientificName, Habitat, Population, Status)
VALUES
('Gorilla gorilla and Gorilla beringei', 'Congo Forests', '200000', 'Least concern / Near threatened'),
('Pan paniscus', 'Congo Forests', '50000', 'Endangered'),
('Pongo abelii, Pongo pygmaeus', 'Signapore, Brunei Forests', '125000', 'Critically Endangered'),
('Pan troglodytes', 'Forests (moist and dry forests), Savannah Woodlands, and Grassland-Forest mosaics', '299700', 'Endangered');