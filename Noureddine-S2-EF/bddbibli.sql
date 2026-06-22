CREATE DATABASE IF NOT EXISTS bddbibli
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE bddbibli;

SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS location;
DROP TABLE IF EXISTS livre;
DROP TABLE IF EXISTS adherent;
SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE adherent (
  idadherent INT PRIMARY KEY,
  nom VARCHAR(100),
  prenom VARCHAR(100),
  email VARCHAR(100),
  motdepasse VARCHAR(100),
  dateinscription DATE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE livre (
  idlivre INT PRIMARY KEY,
  titre VARCHAR(150),
  auteur VARCHAR(100),
  genre VARCHAR(50),
  disponibilite VARCHAR(50)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE location (
  idlocation INT AUTO_INCREMENT PRIMARY KEY,
  idlivre INT,
  idadherent INT,
  datelocation DATE,
  dateretour DATE,
  statut VARCHAR(50),
  FOREIGN KEY (idlivre) REFERENCES livre(idlivre),
  FOREIGN KEY (idadherent) REFERENCES adherent(idadherent)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO adherent VALUES
(1, 'Dupont', 'Jean', 'jean.dupont@example.com', '111', '2025-01-01'),
(2, 'Martin', 'Sophie', 'sophie.martin@example.com', '222', '2025-01-01');

INSERT INTO livre VALUES
(1, '1984', 'George Orwell', 'Dystopie', 'OUI'),
(2, 'L''Étranger', 'Albert Camus', 'Roman', 'OUI');

INSERT INTO location (idlivre, idadherent, datelocation, dateretour, statut) VALUES
(1, 1, '2025-06-01', '2025-06-10', 'retourné'),
(2, 2, '2025-06-05', NULL, 'en cours');
