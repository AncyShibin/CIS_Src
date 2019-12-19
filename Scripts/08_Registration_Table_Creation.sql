CREATE TABLE registration
(
	registration_id   INT IDENTITY
        CONSTRAINT registration_pk
            PRIMARY KEY NONCLUSTERED,
	reg_type              NVARCHAR(500) NOT NULL,
	name                  VARCHAR(15),
    date_of_birth         DATETIME2,
	gender_id             INT
        CONSTRAINT registration_genders_gender_id_fk
            REFERENCES gender,
    phone_number          VARCHAR(15),
    mobile_number		  VARCHAR(15),
    email				  NVARCHAR(100),
	reg_address			  NVARCHAR(300),
	po_box				  NVARCHAR(50),
    area				  VARCHAR(30),
    city				  VARCHAR(30),
    country               NVARCHAR(30),
	organization		  NVARCHAR(50),
    physician             NVARCHAR(50),
	member_no			  VARCHAR(50),
    employee_no			  VARCHAR(30),
    validity			  VARCHAR(30),
    network               NVARCHAR(30),
	sub_network		      NVARCHAR(30),
	is_active		   	  BIT DEFAULT 1 NOT NULL,
    modified_on			  DATETIME2     NOT NULL
)
go