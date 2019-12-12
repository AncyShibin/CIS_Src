CREATE TABLE activity_type
(
    activity_type_id INT IDENTITY CONSTRAINT activity_type_pk PRIMARY KEY NONCLUSTERED,
    activity_number	int	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO

CREATE TABLE facility_and_activity_mapping
(
    facility_and_activity_mapping_id INT IDENTITY CONSTRAINT Facility_and_activity_mapping_pk PRIMARY KEY NONCLUSTERED,
    facility_id	int	NULL 
	CONSTRAINT facility_and_activity_mapping_facility_id_fk
            REFERENCES facility,
	activity_id	int	NULL
	CONSTRAINT facility_and_activity_mapping_activity_id_fk
            REFERENCES activity_type,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO