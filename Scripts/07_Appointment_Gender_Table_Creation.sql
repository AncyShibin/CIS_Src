CREATE TABLE gender
(
    gender_id   INT IDENTITY
        CONSTRAINT gender_pk
            PRIMARY KEY NONCLUSTERED,
    gender_name NVARCHAR(50)  NOT NULL,
    is_active   BIT DEFAULT 1 NOT NULL,
    modified_on DATETIME2     NOT NULL
)
GO

CREATE TABLE appointment
(
	appointment_id   INT IDENTITY
        CONSTRAINT appointment_pk
            PRIMARY KEY NONCLUSTERED,
	name                     NVARCHAR(500) NOT NULL,
    date_of_birth            DATETIME2,
	gender_id                INT
        CONSTRAINT appointment_genders_gender_id_fk
            REFERENCES gender,
    phone_number         VARCHAR(15),
    mobile_number		 VARCHAR(15),
    email				 NVARCHAR(100),
	po_box				 NVARCHAR(50),
    area				 VARCHAR(30),
    city				 VARCHAR(30),
    country              NVARCHAR(30),
	scheduled_date		 DATETIME2,
    comment              NVARCHAR(999),
	is_active			 BIT DEFAULT 1 NOT NULL,
    modified_on			 DATETIME2     NOT NULL
)
go