-- BASES DE DATOS PROYECTO FINAL POO-BASES
DROP DATABASE VaccinationManagementDB
CREATE DATABASE	VaccinationManagementDB;
USE VaccinationManagementDB;
SET LANGUAGE 'us_english';

-- CREACION DE TABLAS CON SUS LLAVES PRIMARIAS

CREATE TABLE EMPLOYEE(
 id INT PRIMARY KEY,
 employee_name VARCHAR(100) NOT NULL,
 email VARCHAR(100) NOT NULL,
 employee_address VARCHAR(100) NOT NULL,
 employee_type INT NOT NULL,
 id_booth INT NOT NULL,
 id_user INT 
);

CREATE TABLE EMPLOYEE_TYPE(
  id INT PRIMARY KEY,
  employee_type VARCHAR(30) NOT NULL
);

CREATE TABLE BOOTH(
  id INT PRIMARY KEY,
  manager VARCHAR(100) NOT NULL,
  booth_address VARCHAR(100) NOT NULL,
  phone INT NOT NULL,
  email VARCHAR(100) NOT NULL
);

CREATE TABLE LOG_IN(
  id_user INT,
  id_booth INT,
  CONSTRAINT PK_log_in PRIMARY KEY(id_user, id_booth),
  date_time DATETIME NOT NULL
);

CREATE TABLE USERS(
  id INT PRIMARY KEY,
  password_user VARCHAR(30) NOT NULL,
  users VARCHAR(30) NOT NULL
);

CREATE TABLE CITIZEN(
  dui INT PRIMARY KEY,
  citizen_name VARCHAR(100) NOT NULL,
  citizen_address VARCHAR(100) NOT NULL,
  phone INT NOT NULL,
  email VARCHAR(100) NULL,
  intitution_code INT NOT NULL,
  id_employee INT NOT NULL,
  id_special_institution INT NOT NULL,
  id_priority_group INT NOT NULL
);


CREATE TABLE DISEASE(
 id INT PRIMARY KEY IDENTITY,
 disease VARCHAR(100) NOT NULL,
 id_citizen INT 
);

CREATE TABLE SPECIAL_INSTITUTION(
 id INT PRIMARY KEY ,
 inst_name VARCHAR(100) NOT NULL
);

CREATE TABLE PRIORITY_GROUP(
 id INT PRIMARY KEY,
 priority_group VARCHAR(100) NOT NULL
);

CREATE TABLE APPOINTMENT(
 id INT PRIMARY KEY IDENTITY,
 appointment_location VARCHAR(100) NOT NULL,
 appointment_date DATETIME NOT NULL,
 step2_date DATETIME NOT NULL,
 vaccine_date DATETIME NOT NULL,
 id_appointment_type INT NOT NULL,
 id_citizen INT NOT NULL

);

CREATE TABLE APPOINTMENT_TYPE(
 id INT PRIMARY KEY,
 appointment_type VARCHAR(30) NOT NULL
);


CREATE TABLE SIDE_EFFECT(
 id INT PRIMARY KEY IDENTITY,
 effect VARCHAR(100) NOT NULL,
 effect_time DATETIME NOT NULL,
 id_appointment INT NOT NULL
);


-- CREANDO LLAVES FORANEAS

-- EMPLOYEE_TYPE -> EMPLOYEE
ALTER TABLE EMPLOYEE ADD FOREIGN KEY(EMPLOYEE_TYPE) REFERENCES EMPLOYEE_TYPE(id);

--  BOOTH -> EMPLOYEE
ALTER TABLE EMPLOYEE ADD FOREIGN KEY(id_booth) REFERENCES   BOOTH(id);

--  BOOTH -> LOG_IN 
ALTER TABLE LOG_IN ADD FOREIGN KEY(id_booth) REFERENCES   BOOTH(id);

-- USERS -> EMPLOYEE
ALTER TABLE EMPLOYEE ADD FOREIGN KEY(id_user) REFERENCES USERS(id);

-- USERS -> LOG_IN
ALTER TABLE LOG_IN ADD FOREIGN KEY(id_user) REFERENCES USERS(id);

-- EMPLOYEE -> CITIZEN
ALTER TABLE CITIZEN ADD FOREIGN KEY(id_EMPLOYEE) REFERENCES EMPLOYEE(id);

-- CITIZEN -> DISEASE 
ALTER TABLE DISEASE ADD FOREIGN KEY(id_citizen) REFERENCES CITIZEN(dui);

-- SPECIAL_INSTITUTION -> CITIZEN
ALTER TABLE CITIZEN ADD FOREIGN KEY(id_special_institution) REFERENCES SPECIAL_INSTITUTION(id);

-- PRIORITY_GROUP -> CITIZEN 
ALTER TABLE CITIZEN ADD FOREIGN KEY(id_priority_group) REFERENCES PRIORITY_GROUP(id);

-- CITIZEN -> APPOINTMENT
ALTER TABLE APPOINTMENT ADD FOREIGN KEY(id_citizen) REFERENCES CITIZEN(dui);

-- APPOINTMENT -> SIDE_EFFECT
ALTER TABLE SIDE_EFFECT ADD FOREIGN KEY(id_appointment) REFERENCES APPOINTMENT(id);

-- TIPO_APPOINTMENT -> APPOINTMENT
ALTER TABLE APPOINTMENT ADD FOREIGN KEY(id_appointment_type) REFERENCES APPOINTMENT_TYPE(id);

-- INSERTANDO DATOS DE  BOOTH
INSERT INTO BOOTH VALUES(1,'Juan Rodriguez', '29 Cl Pte y 11 Av Nte Bo San Miguelito',77898984,'froloprisegoi-9782@yopmail.com');
INSERT INTO BOOTH VALUES(2,'Mohammed Robledo','Alam Roosevelt 37 Av S 114', 72729030,'touzoutteuzaddo-9085@yopmail.com');
INSERT INTO BOOTH VALUES(3,'Christopher Abril', 'Calle Gerardo Barrios, 17 AV. Sur #412', 70471546, 'dolluxelleddoi-9022@yopmail.com');
INSERT INTO BOOTH VALUES(4,'Ezequiel Alcazar', 'Blvd Del Ej�rc Nac Urb Altos Del Boulevard 50 Av Nte',73942401,'mikeujeiwougu-2946@yopmail.com');
INSERT INTO BOOTH VALUES(5,'Vicente Alarcon', '1� Calle Poniente entre 60� Avenida Norte y Boulevard Constituci�n No. 3549', 71058812,'koimmoissolaxau-8341@yopmail.com');

-- INSERTANDO TIPOS DE EMPLOYEES
INSERT INTO EMPLOYEE_TYPE VALUES(1,'Gestor');
INSERT INTO EMPLOYEE_TYPE VALUES(2,'Vacunador');
INSERT INTO EMPLOYEE_TYPE VALUES(3,'Enfermero');

-- INSERTANDO DATOS DE USERS
INSERT INTO USERS VALUES(1,'ab8qw71m','Gestor_1');
INSERT INTO USERS VALUES(2,'aq00odih','Gestor_2');
INSERT INTO USERS VALUES(3,'1qf4z19j','Gestor_3');
INSERT INTO USERS VALUES(4,'i05gbvmk','Gestor_4');
INSERT INTO USERS VALUES(5,'e9noida8','Gestor_5');
INSERT INTO USERS VALUES(6,'lj543sut','Gestor_6');
INSERT INTO USERS VALUES(7,'25t07myi','Gestor_7');
INSERT INTO USERS VALUES(8,'m23tpmlf','Gestor_8');
INSERT INTO USERS VALUES(9,'fvjvockh','Gestor_9');
INSERT INTO USERS VALUES(10,'6jdqwfks','Gestor_10');


-- INSERTANDO DATOS DE GESTORES
INSERT INTO EMPLOYEE VALUES(1,'Nicole Lorenzo','quettoujouhoiha-5296@yopmail.com','67229 Hauck Knolls Apt. 251 - Columbus, SC / 12511', 1,1,1);
INSERT INTO EMPLOYEE VALUES(2,'Alexander Gomis', 'bannagroigroca-2180@yopmail.com', '3352 Champlin Key Suite 516 - Grand Island, VA / 29787',1,1,2);
INSERT INTO EMPLOYEE VALUES(3,'Joaquin Chavez', 'celouffelleko-5443@yopmail.com', '37858 Wilkinson Orchard Apt. 948 - Shawnee, FL / 30496',1,2,3);
INSERT INTO EMPLOYEE VALUES(4,'Alan Mu�iz', 'timakegouru-5190@yopmail.com', '614 Jerome Valley Apt. 264 - Billings, WA / 00404',1,2,4);
INSERT INTO EMPLOYEE VALUES(5,'Noe Sacristan','lalepebrillu-1814@yopmail.com', '203 Schaefer Manors Apt. 779 - Leesburg, IN / 03956',1,3,5);
INSERT INTO EMPLOYEE VALUES(6,'Lucas Garces', 'wauhafreyaffo-6238@yopmail.com','2830 Angelo Mountain Suite 635 - Livonia, MI / 10200',1,3,6 );
INSERT INTO EMPLOYEE VALUES(7,'Axel Aviles', 'trafoqueigupu-3622@yopmail.com', '5094 Billy Glens Suite 410 - North Little Rock, DE / 70430',1,4,7);
INSERT INTO EMPLOYEE VALUES(8,'Fidel Esteban','rewuqueittalo-7788@yopmail.com', '5606 Simonis Junctions Apt. 673 - Hillsboro, MS / 13134',1,4,8);
INSERT INTO EMPLOYEE VALUES(9,'Norberto Mera','nujoudausseili-3773@yopmail.com', '817 Orval Heights Suite 296 - Council Bluffs, MN / 64949',1,5,9);
INSERT INTO EMPLOYEE VALUES(10,'Raul Mayo', 'somappozagru-9194@yopmail.com', '041 Christopher Manors Apt. 447 - Mobile, ME / 01284',1,5,10);


-- INSERTANDO DATOS DE VACUNADORES
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(11,'Leandro Ariza', 'fouxeulluzoufu-2905@yopmail.com','43660 Sanford Islands Suite 637 - Hattiesburg, OR / 50745',2,1);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(12,'Oliver Zafra', 'zobravauttiyau-8373@yopmail.com', '87127 Reichert Summit Suite 508 - Decatur, ND / 09859',2,2);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(13,'Octavio Murcia', 'frussuvaumoute-7839@yopmail.com', '457 Jeffrey Island Suite 593 - Olathe, HI / 24460',2,3);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(14,'Arturo Yuste', 'gonounufeisu-3143@yopmail.com', '87574 Dickinson Walk Suite 756 - Mishawaka, FL / 74665',2,4);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(15,'Isidoro Corral','sudeutrugrazi-9174@yopmail.com', '3524 Jake Ridges Apt. 582 - Huntington, GA / 62981',2,5);

-- INSERTANDO DATOS DE ENFERMEROS
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(16,'Patricio Pe�alver','nigettoifoicre-2818@yopmail.com','63982 Kertzmann Prairie Apt. 403 - Mount Pleasant, SC / 22501',3,1);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(17,'Bonifacio Peral','gunoinnoquomme-5763@yopmail.com','600 Baumbach Roads Suite 029 - Peoria, KY / 94445',3,2);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(18,'Ignacio Iglesias','maceusetebreu-8916@yopmail.com', '44784 Lehner Valleys Suite 683 - East Providence, VA / 66316',3,3);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(19,'Orlando Rodriguez','simeuquequala-5601@yopmail.com','09461 Hoeger Forest Apt. 083 - Bountiful, NY / 00009',3,4);
INSERT INTO EMPLOYEE (id,employee_name,email,employee_address,employee_type,id_booth) VALUES(20,'Julio Parra','boinevoyeupre-6944@yopmail.com','443 Zachery Causeway Suite 195 - Reading, PA / 05051',3,5);

-- INSERTANDO DATOS DE INSTITUCIONES
INSERT INTO SPECIAL_INSTITUTION VALUES(1,'Educacion');
INSERT INTO SPECIAL_INSTITUTION VALUES(2,'Salud');
INSERT INTO SPECIAL_INSTITUTION VALUES(3,'Policia Nacional Civil');
INSERT INTO SPECIAL_INSTITUTION VALUES(4,'Gobierno');
INSERT INTO SPECIAL_INSTITUTION VALUES(5,'Fuerza Armada');
INSERT INTO SPECIAL_INSTITUTION VALUES(6,'Periodismo');
INSERT INTO SPECIAL_INSTITUTION VALUES(7,'Otras');

-- INSERTANDO GRUPOS DE PRIORIDAD
INSERT INTO PRIORITY_GROUP VALUES(1,'Adultos mayores de 60 a�os');
INSERT INTO PRIORITY_GROUP VALUES(2,'Personal del sistema integrado de salud');
INSERT INTO PRIORITY_GROUP VALUES(3,'Encargados de la seguridad nacional');
INSERT INTO PRIORITY_GROUP VALUES(4,'Personas mayores de 18 a�os con DISEASE no transmisibles o alguna discapacidad');
INSERT INTO PRIORITY_GROUP VALUES(5,'Personal del gobierno central');

-- INSERTANDO TIPOS DE APPOINTMENTS
INSERT INTO APPOINTMENT_TYPE VALUES(1,'Primera cita');
INSERT INTO APPOINTMENT_TYPE VALUES(2,'Segunda cita');

SELECT * FROM APPOINTMENT_TYPE