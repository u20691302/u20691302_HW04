CREATE TABLE MarineAnimals 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL,
ImgPath varchar(MAX) NOT NULL
);

CREATE TABLE BigCats 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL,
ImgPath varchar(MAX) NOT NULL

);

CREATE TABLE Primates 
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ScientificName varchar(50) NOT NULL,
Habitat varchar(MAX) NOT NULL,
Population INT NOT NULL,
Status varchar(50) NOT NULL,
ImgPath varchar(MAX) NOT NULL
);

INSERT INTO MarineAnimals (ScientificName, Habitat, Population, Status, ImgPath)
VALUES
('Ursus maritimus', 'Artic Ocean', '31000', 'Vulnerable','~/Resources/PolarBear.jpg'),
('Spheniscus mendiculus', 'Oceans', '2000', 'Endangered','~/Resources/GalapagosPenguin.jpg'),
('Cephalorhynchus hectori', 'Oceans', '7000', 'Endangered','~/Resources/HectorsDolphin.jpg'),
('Phocoena sinus', 'Marine (only in the northern Gulf of California)', '10', 'Vulnerable','~/Resources/Vaquita.jpg');

INSERT INTO BigCats(ScientificName, Habitat, Population, Status, ImgPath)
VALUES
('Panthera tigris', 'Tropical rainforests, evergreen forests, temperate forests, mangrove swamps, grasslands, and savannas', '3900', 'Endangered','~/Resources/Tiger.jpg'),
('Panthera pardus orientalis', 'Temperate, Broadleaf, and Mixed Forests', '84', 'Critically Endangered','~/Resources/AmurLeopard.jpg'),
('Panthera uncia', 'High mountains', '6500', 'Vulnerable','~/Resources/SnowLeopard.jpg'),
('Panthera onca', 'Forests, Grasslands', '10001', 'Least Concern / Near Threatened','~/Resources/Jaguar.jpg');

INSERT INTO Primates (ScientificName, Habitat, Population, Status, ImgPath)
VALUES
('Gorilla gorilla and Gorilla beringei', 'Congo Forests', '200000', 'Least Concern / Near Threatened','~/Resources/Gorilla.jpg'),
('Pan paniscus', 'Congo Forests', '50000', 'Endangered','~/Resources/Bonobo.jpg'),
('Pongo abelii, Pongo pygmaeus', 'Signapore, Brunei Forests', '125000', 'Critically Endangered','~/Resources/Orangutan.jpg'),
('Pan troglodytes', 'Forests (moist and dry forests), Savannah Woodlands, and Grassland-Forest mosaics', '299700', 'Endangered','~/Resources/Chimpanzee.jpg');