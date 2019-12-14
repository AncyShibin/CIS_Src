CREATE TABLE medical_record
(
    medical_record_id INT IDENTITY CONSTRAINT medical_record_pk PRIMARY KEY NONCLUSTERED,
    company_id	int	NULL 
	CONSTRAINT medical_record_company_id_fk
            REFERENCES company,
	facility_id	int	NULL
	CONSTRAINT medical_record_facility_id_fk
            REFERENCES facility,
	encounter_type_id	int	NULL 
	CONSTRAINT medical_record_encounter_type_id_fk
            REFERENCES encounter_type,
	regulatory_id	int	NULL
	CONSTRAINT medical_record_regulatory_id_fk
            REFERENCES regulatory,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO