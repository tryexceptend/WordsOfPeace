/*i_course - таблица с информацией о курсе*/
CREATE TABLE i_course
(
	param_name TEXT PRIMARY KEY NOT NULL ,
	param_value TEXT
);
INSERT INTO i_course (param_name, param_value)
VALUES ('Version','v1.0.0'),
	('Base_Lang',NULL),
	('Learn_Lang',NULL),
	('Description',NULL),
	('Authors',NULL);
	
/* Дерево разделов */
CREATE TABLE e_section 
(
	section_id INTEGER PRIMARY KEY,
	name TEXT NOT NULL,
	description TEXT,
	parent INTEGER
);