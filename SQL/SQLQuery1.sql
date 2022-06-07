CREATE DATABASE UsersDB

USE UsersDB

CREATE TABLE RegistrationTable
(
	userId INT IDENTITY NOT NULL,
	userLog VARCHAR(20) NOT NULL,
	userPswrd VARCHAR(20) NOT NULL
)

INSERT INTO RegistrationTable
VALUES ('admin','admin')

SELECT * FROM RegistrationTable