CREATE TABLE facility
(
    faciltiy_id INT IDENTITY CONSTRAINT facility_pk PRIMARY KEY NONCLUSTERED,
    facility_name	varchar(200)	NULL,
    facility_code	varchar(200)	NULL,
	facility_type	varchar(200)	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO

CREATE TABLE visit_type
(
    visit_type_id INT IDENTITY CONSTRAINT visit_type_pk PRIMARY KEY NONCLUSTERED,
    visit_type	varchar(200)	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO