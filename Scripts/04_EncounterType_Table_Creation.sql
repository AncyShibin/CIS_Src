CREATE TABLE encounter_type
(
    encounter_type_id INT IDENTITY CONSTRAINT encounter_type_pk PRIMARY KEY NONCLUSTERED,
    encounter_type	varchar(200)	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO